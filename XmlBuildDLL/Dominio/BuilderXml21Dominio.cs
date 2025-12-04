using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.DocumentClass.UBL2._1;

namespace XmlBuildDLL.Dominio
{
    public class BuilderXml21Dominio
    {
        protected XElement documentXML;
        protected XDocument doc;
        protected XNamespace xmlns;
        protected XNamespace cac;
        protected XNamespace cbc;
        protected XNamespace ds;
        protected XNamespace ext;
        protected XNamespace xsi;
        protected XNamespace udt;
        protected XNamespace qdt;
        protected XNamespace sts;
        protected XNamespace xades;
        protected XNamespace xades141;
        protected XNamespace sig;
        protected XNamespace sac;
        protected XNamespace sbc;
        protected XNamespace ipt;
        public virtual String BuildXML(BaseDocument21 obj, ref int cantidadDecimales, List<string> nombres)
        {
            LoadNameSpace();

            XDeclaration declaration = new XDeclaration("1.0", "utf-8", "no");

            XDocument doc = new XDocument(declaration);

            XElement documentXML = new XElement(xmlns + obj.TypeDocument);

            documentXML.Add(new XAttribute("xmlns", xmlns));

            HeaderExtensions(ref documentXML, obj);

            //Namespace Invoice
            XNamespace nsInvoice = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2     http://docs.oasis-open.org/ubl/os-UBL-2.1/xsd/maindoc/UBL-Invoice-2.1.xsd";
            documentXML.Add(new XAttribute(xsi + "schemaLocation", nsInvoice.ToString()));

            documentXML.Add(new XElement(cbc + "UBLVersionID", obj.UBLVersionID)); // crear catalagos para 2.1 

            bool customizationIdNormal = true;

            #region Sector Salud
            if (obj.EsEscenarioSectorSalud("1"))
            {
                customizationIdNormal = false;
                string schemeId = "";

                if (obj.InvoiceTypeCode == Constantes.TipoDocumento.FacturaNacional)
                {
                    // schemeId = "SS-CUFE";
                }
                if (obj.InvoiceTypeCode == Constantes.TipoDocumento.FacturaContingenciaEmisor)
                {
                    schemeId = "SS-CUDE";
                }
                if (obj.InvoiceTypeCode == Constantes.TipoDocumento.FacturaContingenciaDian)
                {
                    schemeId = "SS-CUDE";
                }
                documentXML.Add(new XElement(cbc + "CustomizationID", obj.sectorSalud.IdPersonalizacion));
                //documentXML.Add(new XElement(cbc + "CustomizationID", obj.sectorSalud.IdPersonalizacion, new XAttribute("schemeID", schemeId)));
            }
            if (obj.EsEscenarioSectorSalud("2"))
            {
                customizationIdNormal = false;
                documentXML.Add(new XElement(cbc + "CustomizationID", obj.sectorSalud.IdPersonalizacion));
            }
            if (obj.EsEscenarioSectorSalud("3"))
            {
                customizationIdNormal = false;
                documentXML.Add(new XElement(cbc + "CustomizationID", obj.sectorSalud.IdPersonalizacion));
            }
            if (obj.EsEscenarioSectorSalud("4"))
            {
                customizationIdNormal = false;
                documentXML.Add(new XElement(cbc + "CustomizationID", obj.sectorSalud.IdPersonalizacion));
            }
            if (obj.EsEscenarioSectorSalud("5"))
            {
                customizationIdNormal = false;
                documentXML.Add(new XElement(cbc + "CustomizationID", obj.sectorSalud.IdPersonalizacion));
            }
            #endregion Sector Salud

            if (customizationIdNormal)
            {
                documentXML.Add(new XElement(cbc + "CustomizationID", obj.CustomizationID));
            }

            documentXML.Add(new XElement(cbc + "ProfileID", obj.ProfileID));
            documentXML.Add(new XElement(cbc + "ProfileExecutionID", obj.ProfileExecutionID)); // el namespace en doc DIAN dice dcc, revisar fue un error 
            documentXML.Add(new XElement(cbc + "ID", obj.ID));
            documentXML.Add(new XElement(cbc + "UUID", obj.UUID, new XAttribute("schemeName", obj.UUID_schemeName), new XAttribute("schemeID", obj.UUID_schemeID))); // deberia ser llenado por un catalogo

            documentXML.Add(new XElement(cbc + "IssueDate", obj.IssueDate.ToString("yyyy-MM-dd")));

            documentXML.Add(new XElement(cbc + "IssueTime", obj.IssueTime.ToString("HH:mm:ss") + "-05:00"));

            if (obj.DueDate.HasValue)
            {
                documentXML.Add(new XElement(cbc + "DueDate", obj.DueDate.Value.ToString("yyyy-MM-dd")));
            }

            documentXML.Add(new XElement(cbc + "InvoiceTypeCode", obj.InvoiceTypeCode));

            if (obj.Extensible != null)
            {
                foreach (ExtensiblesNote rowNote in obj.Extensible)
                {
                    if (rowNote != null)
                    {
                        if (rowNote.Type == "Text")
                            if (!string.IsNullOrEmpty(rowNote.Value))
                                documentXML.Add(new XElement(cbc + "Note", rowNote.Value));
                    }
                }
            }

            if (obj.TaxPointDate.HasValue)
            {
                documentXML.Add(new XElement(cbc + "TaxPointDate", obj.TaxPointDate.Value.ToString("yyyy-MM-dd")));
            }

            documentXML.Add(new XElement(cbc + "DocumentCurrencyCode", obj.DocumentCurrencyCode));
            documentXML.Add(new XElement(cbc + "LineCountNumeric", obj.LineCountNumeric));

            XElement nodeInvoicePeriod = FillInvoicePeriod(obj);
            if (nodeInvoicePeriod != null && nodeInvoicePeriod.HasElements)
                documentXML.Add(nodeInvoicePeriod);

            if (obj.OrderReference != null)
            {
                foreach (OrderReference OrderReferenceLine in obj.OrderReference)
                {
                    XElement nodeOrderReference = FillOrderReference(cac, OrderReferenceLine);
                    if (nodeOrderReference != null && nodeOrderReference.HasElements)
                        documentXML.Add(nodeOrderReference);
                }
            }

            if (obj.BillingReference != null)
            {
                foreach (BillingReference BillingReferenceLine in obj.BillingReference)
                {
                    XElement nodeBillingReference = FillBillingReference(cac, BillingReferenceLine, obj);
                    if (nodeBillingReference != null && nodeBillingReference.HasElements)
                        documentXML.Add(nodeBillingReference);
                }
            }

            if (obj.DespatchDocumentReference != null)
            {
                foreach (DespatchDocumentReference despatchDocumentReference in obj.DespatchDocumentReference)
                {
                    XElement nodeDespatchDocumentReference = FillDespatchDocumentReference(cac, despatchDocumentReference);
                    if (nodeDespatchDocumentReference != null && nodeDespatchDocumentReference.HasElements)
                        documentXML.Add(nodeDespatchDocumentReference);
                }
            }

            if (obj.ReceiptDocumentReference != null)
            {
                foreach (ReceiptDocumentReference receiptDocumentReference in obj.ReceiptDocumentReference)
                {
                    XElement nodeReceiptDocumentReference = FillReceiptDocumentReference(cac, receiptDocumentReference);
                    if (nodeReceiptDocumentReference != null && nodeReceiptDocumentReference.HasElements)
                        documentXML.Add(nodeReceiptDocumentReference);
                }
            }

            if (obj.AdditionalDocumentReference != null)
            {
                foreach (AdditionalDocumentReference rowAD in obj.AdditionalDocumentReference)
                {
                    XElement nodeAdicionalDocRef = FillAdditionalDocumentReference(rowAD, obj);
                    if (nodeAdicionalDocRef != null && nodeAdicionalDocRef.HasElements)
                        documentXML.Add(nodeAdicionalDocRef);
                }
            }

            XElement nodeSupplierParty = FillAcountingSupplierParty(cac, obj);
            if (nodeSupplierParty != null && nodeSupplierParty.HasElements)
            {
                documentXML.Add(nodeSupplierParty);
            }

            XElement nodeCustomerParty = FillAccountingCustomerParty(cac, obj);
            if (nodeCustomerParty != null && nodeCustomerParty.HasElements)
            {
                documentXML.Add(nodeCustomerParty);
            }

            XElement nodeBuyersCustomerParty = FillBuyerCustomerParty(cac, obj);
            if (nodeBuyersCustomerParty != null && nodeBuyersCustomerParty.HasElements)
            {
                documentXML.Add(nodeBuyersCustomerParty);
            }

            XElement nodeTaxRepParty = FillTaxRepresentativeParty(obj.TaxRepresentativeParty);
            if (nodeTaxRepParty != null && nodeTaxRepParty.HasElements)
            {
                documentXML.Add(nodeTaxRepParty);
            }

            XElement nodeDelivery = FillDelivery(cac, obj.Delivery);
            if (nodeDelivery != null && nodeDelivery.HasElements)
            {
                documentXML.Add(nodeDelivery);
            }

            if (obj.DeliveryTerms != null)
            {
                XElement nodeAllowanceDelivery = null;
                XElement nodeLocation = null;
                if (obj.DeliveryTerms.AllowanceCharge != null)
                {
                    nodeAllowanceDelivery = FillAllowanceCharge(cac, obj.DeliveryTerms.AllowanceCharge, ref cantidadDecimales);
                }

                if (obj.DeliveryTerms.DeliveryLocation != null)
                {
                    XElement address = FillAddress(obj.DeliveryTerms.DeliveryLocation, "Address");
                    if (address != null && address.HasElements)
                    {
                        nodeLocation = new XElement(cac + "DeliveryLocation", address);
                    }
                }

                XElement nodedeliveryTerms = FillDeliveryTerms(nodeLocation, nodeAllowanceDelivery, obj);
                if (nodedeliveryTerms != null && nodedeliveryTerms.HasElements)
                {
                    documentXML.Add(nodedeliveryTerms);
                }
            }

            if (obj.PaymentMeans != null)
            {
                foreach (PaymentMeans rowP in obj.PaymentMeans)
                {
                    XElement nodePaymentMeans = FillPaymentMeans(rowP);
                    if (nodePaymentMeans != null && nodePaymentMeans.HasElements)
                    {
                        documentXML.Add(nodePaymentMeans);
                    }
                }
            }

            XElement nodePaymentTerms = FillPaymentTerms(cac, obj.PaymentTerms);
            if (nodePaymentTerms != null && nodePaymentTerms.HasElements)
            {
                documentXML.Add(nodePaymentTerms);
            }

            #region SectorSalud
            if (obj.EsEscenarioSectorSalud("2"))
            {
                for (int i = 0; i < obj.PrepaidPayment.Count(); i++)
                {
                    int counter = i + 1;

                    // Verificar si hay un valor en la lista 'nombres' antes de intentar acceder a él
                    if (nombres.Count > i)
                    {
                        string nombre = nombres[i];

                        XElement OutPrepaidPay = FillPrepaidPaymentNodesSector2(ref cantidadDecimales, obj.PrepaidPayment[i], nombre, counter);

                        if (OutPrepaidPay != null && OutPrepaidPay.HasElements)
                        {
                            documentXML.Add(OutPrepaidPay);
                        }
                    }
                    else
                    {
                        // Manejar el caso en el que no hay un valor correspondiente en la lista 'nombres'
                        XElement OutPrepaidPay = FillPrepaidPaymentNodes(ref cantidadDecimales, obj.PrepaidPayment[i], counter);
                        if (OutPrepaidPay != null && OutPrepaidPay.HasElements)
                        {
                            documentXML.Add(OutPrepaidPay);
                        }
                    }
                }
            }

            else

                for (int i = 0; i < obj.PrepaidPayment.Count(); i++)
                {
                    int counter = i + 1;
                    //documentXml.Add(nodePrepaidPayment);
                    XElement OutPrepaidPay = FillPrepaidPaymentNodes(ref cantidadDecimales, obj.PrepaidPayment[i], counter);
                    if (OutPrepaidPay != null && OutPrepaidPay.HasElements)
                    {
                        documentXML.Add(OutPrepaidPay);
                    }
                }


            #endregion


            if (obj.AllowanceCharge != null)
            {
                foreach (AllowanceCharge allowance in obj.AllowanceCharge)
                {
                    XElement nodeAlowance = FillAllowanceCharge(cac, allowance, ref cantidadDecimales);
                    if (nodeAlowance != null && nodeAlowance.HasElements)
                    {
                        documentXML.Add(nodeAlowance);
                    }
                }
            }



            XElement nodePaymentExchangeRate = FillPaymentExchangeRate(cac, obj.PaymentExchangeRate, ref cantidadDecimales);
            if (nodePaymentExchangeRate != null && nodePaymentExchangeRate.HasElements)
            {
                documentXML.Add(nodePaymentExchangeRate);
            }

            XElement nodePaymentAlternativeExchangeRate = FillPaymentAlternativeExchangeRate(cac, obj.PaymentAlternativeExchangeRate, ref cantidadDecimales);
            if (nodePaymentAlternativeExchangeRate != null && nodePaymentAlternativeExchangeRate.HasElements)
            {
                documentXML.Add(nodePaymentAlternativeExchangeRate);
            }

            if (obj.TaxTotal != null)
            {
                foreach (TaxTotal tax in obj.TaxTotal)
                {
                    XElement nodeTaxTotal = FillTaxTotal(cac, tax, ref cantidadDecimales, obj.ValorPorDefectoRedondeoAplicado);
                    if (nodeTaxTotal != null && nodeTaxTotal.HasElements)
                    {
                        documentXML.Add(nodeTaxTotal);
                    }
                }
            }

            if (obj.WithholdingTaxTotal != null)
            {
                foreach (WithholdingTaxTotal taxR in obj.WithholdingTaxTotal)
                {
                    XElement nodeWithholdingTaxTotal = FillWithholdingTaxTotal(cac, taxR, ref cantidadDecimales);
                    if (nodeWithholdingTaxTotal != null && nodeWithholdingTaxTotal.HasElements)
                    {
                        documentXML.Add(nodeWithholdingTaxTotal);
                    }
                }
            }

            XElement nodelegalMonetary = FillLegalMonetaryTotal("LegalMonetaryTotal", ref cantidadDecimales, obj);
            if (nodelegalMonetary != null && nodelegalMonetary.HasElements)
            {
                documentXML.Add(nodelegalMonetary);
            }

            FillInvoiceLine(cac, ref documentXML, "InvoiceLine", "Invoiced", ref cantidadDecimales, obj);

            doc.Add(documentXML);

            string xmlPlano = doc.ToString();

            //Si tiene algun nodo de sector salud o de exportacion corrige el CustomTagGeneral
            if (obj.TieneNodoSectorSalud())
            {
                ReemplazarPrimeraOcurrenciaTexto(ref xmlPlano, "<CustomTagGeneral", ">", "<CustomTagGeneral>");
                ReemplazarPrimeraOcurrenciaTexto(ref xmlPlano, "<Group", "=", "<Group schemeName=");
            }
            else
            {
                foreach (ExtensiblesNote extensiblesNote in obj.Extensible)
                {
                    if (extensiblesNote != null && extensiblesNote.Type == "XML")
                    {
                        if (extensiblesNote.ID == "FEXP1" || extensiblesNote.ID == "FEXP2" || extensiblesNote.ID == "FEXP3")
                        {
                            ReemplazarPrimeraOcurrenciaTexto(ref xmlPlano, "<CustomTagGeneral", ">", "<CustomTagGeneral>");
                            ReemplazarPrimeraOcurrenciaTexto(ref xmlPlano, "<Group", "=", "<Group schemeName=");
                        }
                        else if (extensiblesNote.Name == "INTE1")
                        {
                            ReemplazarPrimeraOcurrenciaTexto(ref xmlPlano, "<CustomTagGeneral xmlns", ">", "<CustomTagGeneral>");
                        }
                    }
                }
            }

            return Utils.EncodeToBase64(xmlPlano);
        }

    }
}
