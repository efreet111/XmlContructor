using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.DocumentClass.UBL2._1;
using XmlBuildDLL.Dominio.Namespaces;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.Transversal;

namespace XmlBuildDLL.Dominio
{
    public class BuilderXmlInvoiceDominio
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
        protected XNamespace sac;
        protected XNamespace sbc;
        protected XNamespace ipt;

        private readonly INamespaceProvider _namespaceProvider;

        public BuilderXmlInvoiceDominio()
            : this(new DefaultNamespaceProvider())
        {
        }

        public BuilderXmlInvoiceDominio(INamespaceProvider namespaceProvider)
        {
            _namespaceProvider = namespaceProvider ?? new DefaultNamespaceProvider();
        }

        public virtual String BuildXML(BillingDocument21Object BillingObj, ref int cantidadDecimales, List<string> nombres)
        {
            // Inicializar namespaces desde el proveedor
            xmlns = _namespaceProvider.Ubl;
            cac = _namespaceProvider.Cac;
            cbc = _namespaceProvider.Cbc;
            ds = _namespaceProvider.Ds;
            ext = _namespaceProvider.Ext;
            xsi = _namespaceProvider.Xsi;
            udt = _namespaceProvider.Udt;
            qdt = _namespaceProvider.Qdt;
            sts = _namespaceProvider.Sts;
            xades = _namespaceProvider.Xades;
            xades141 = _namespaceProvider.Xades141;
            sac = _namespaceProvider.Sac;
            sbc = _namespaceProvider.Sbc;
            ipt = _namespaceProvider.Ipt;

            XDeclaration declaration = new XDeclaration("1.0", "utf-8", "no");

            XDocument doc = new XDocument(declaration);

            XElement documentXML = new XElement(xmlns + BillingObj.TypeDocument);

            documentXML.Add(new XAttribute("xmlns", xmlns));

            // Reemplaza la llamada estática por una instancia de HeaderExtensionsXmlFill
            HeaderExtensionsXmlFill.HeaderExtensions(ref documentXML, BillingObj);

            //Namespace Invoice
            XNamespace nsInvoice = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2     http://docs.oasis-open.org/ubl/os-UBL-2.1/xsd/maindoc/UBL-Invoice-2.1.xsd";
            documentXML.Add(new XAttribute(xsi + "schemaLocation", nsInvoice.ToString()));

            documentXML.Add(new XElement(cbc + "UBLVersionID", BillingObj.UBLVersionID)); // crear catalagos para 2.1 

            bool customizationIdNormal = true;

            if (customizationIdNormal)
            {
                documentXML.Add(new XElement(cbc + "CustomizationID", BillingObj.CustomizationID));
            }

            documentXML.Add(new XElement(cbc + "ProfileID", BillingObj.ProfileID));
            documentXML.Add(new XElement(cbc + "ProfileExecutionID", BillingObj.ProfileExecutionID)); // el namespace en doc DIAN dice dcc, revisar fue un error 
            documentXML.Add(new XElement(cbc + "ID", BillingObj.ID));
            documentXML.Add(new XElement(cbc + "UUID", BillingObj.UUID, new XAttribute("schemeName", BillingObj.UUIDSchemeName), new XAttribute("schemeID", BillingObj.UUIDSchemeID))); // deberia ser llenado por un catalogo

            documentXML.Add(new XElement(cbc + "IssueDate", BillingObj.IssueDate.ToString("yyyy-MM-dd")));

            documentXML.Add(new XElement(cbc + "IssueTime", BillingObj.IssueTime.ToString("HH:mm:ss") + "-05:00"));

            if (BillingObj.DueDate.HasValue)
            {
                documentXML.Add(new XElement(cbc + "DueDate", BillingObj.DueDate.Value.ToString("yyyy-MM-dd")));
            }

            documentXML.Add(new XElement(cbc + "InvoiceTypeCode", BillingObj.InvoiceTypeCode));

            if (BillingObj.Extensible != null)
            {
                foreach (ExtensiblesNote rowNote in BillingObj.Extensible)
                {
                    if (rowNote != null)
                    {
                        if (rowNote.Type == "Text")
                            if (!string.IsNullOrEmpty(rowNote.Value))
                                documentXML.Add(new XElement(cbc + "Note", rowNote.Value));
                    }
                }
            }

            if (BillingObj.TaxPointDate.HasValue)
            {
                documentXML.Add(new XElement(cbc + "TaxPointDate", BillingObj.TaxPointDate.Value.ToString("yyyy-MM-dd")));
            }

            documentXML.Add(new XElement(cbc + "DocumentCurrencyCode", BillingObj.DocumentCurrencyCode));
            documentXML.Add(new XElement(cbc + "LineCountNumeric", BillingObj.LineCountNumeric));

            XElement nodeInvoicePeriod = InvoicePeriodXmlFill.FillInvoicePeriod(BillingObj.InvoicePeriod);
            if (nodeInvoicePeriod != null && nodeInvoicePeriod.HasElements)
                documentXML.Add(nodeInvoicePeriod);

            if (BillingObj.OrderReference != null)
            {
                foreach (OrderReference OrderReferenceLine in BillingObj.OrderReference)
                {
                    XElement nodeOrderReference = OrderReferenceXmlFill.FillOrderReference(cac, OrderReferenceLine);
                    if (nodeOrderReference != null && nodeOrderReference.HasElements)
                        documentXML.Add(nodeOrderReference);
                }
            }

            if (BillingObj.BillingReference != null)
            {
                foreach (BillingReference BillingReferenceLine in BillingObj.BillingReference)
                {
                    XElement nodeBillingReference = BillingReferenceXmlFill.FillBillingReference(BillingReferenceLine, BillingObj.TypeDocument.ToString());
                    if (nodeBillingReference != null && nodeBillingReference.HasElements)
                        documentXML.Add(nodeBillingReference);
                }
            }

            if (BillingObj.DespatchDocumentReference != null)
            {
                foreach (DespatchDocumentReference despatchDocumentReference in BillingObj.DespatchDocumentReference)
                {
                    XElement nodeDespatchDocumentReference = DespatchDocumentReferenceXmlFill.FillDespatchDocumentReference(despatchDocumentReference);
                    if (nodeDespatchDocumentReference != null && nodeDespatchDocumentReference.HasElements)
                        documentXML.Add(nodeDespatchDocumentReference);
                }
            }

            if (BillingObj.ReceiptDocumentReference != null)
            {
                foreach (ReceiptDocumentReference receiptDocumentReference in BillingObj.ReceiptDocumentReference)
                {
                    XElement nodeReceiptDocumentReference = ReceiptDocumentReferenceXmlFill.FillReceiptDocumentReference(receiptDocumentReference);
                    if (nodeReceiptDocumentReference != null && nodeReceiptDocumentReference.HasElements)
                        documentXML.Add(nodeReceiptDocumentReference);
                }
            }

            if (BillingObj.AdditionalDocumentReference != null)
            {
                foreach (AdditionalDocumentReference rowAD in BillingObj.AdditionalDocumentReference)
                {
                    XElement nodeAdicionalDocRef = AdditionalDocumentReferenceXmlFill.FillAdditionalDocumentReference(rowAD);
                    if (nodeAdicionalDocRef != null && nodeAdicionalDocRef.HasElements)
                        documentXML.Add(nodeAdicionalDocRef);
                }
            }

            XElement nodeSupplierParty = AcountingSupplierPartyXmlFill.FillAcountingSupplierParty( BillingObj.AcountingSupplierParty);
            if (nodeSupplierParty != null && nodeSupplierParty.HasElements)
            {
                documentXML.Add(nodeSupplierParty);
            }

            //XElement nodeCustomerParty = FillAccountingCustomerParty(cac, BillingObj);
            //if (nodeCustomerParty != null && nodeCustomerParty.HasElements)
            //{
            //    documentXML.Add(nodeCustomerParty);
            //}

            //XElement nodeBuyersCustomerParty = FillBuyerCustomerParty(cac, BillingObj);
            //if (nodeBuyersCustomerParty != null && nodeBuyersCustomerParty.HasElements)
            //{
            //    documentXML.Add(nodeBuyersCustomerParty);
            //}

            //XElement nodeTaxRepParty = FillTaxRepresentativeParty(BillingObj.TaxRepresentativeParty);
            //if (nodeTaxRepParty != null && nodeTaxRepParty.HasElements)
            //{
            //    documentXML.Add(nodeTaxRepParty);
            //}

            //XElement nodeDelivery = FillDelivery(cac, BillingObj.Delivery);
            //if (nodeDelivery != null && nodeDelivery.HasElements)
            //{
            //    documentXML.Add(nodeDelivery);
            //}

            //if (BillingObj.DeliveryTerms != null)
            //{
            //    XElement nodeAllowanceDelivery = null;
            //    XElement nodeLocation = null;
            //    if (BillingObj.DeliveryTerms.AllowanceCharge != null)
            //    {
            //        nodeAllowanceDelivery = FillAllowanceCharge(cac, BillingObj.DeliveryTerms.AllowanceCharge, ref cantidadDecimales);
            //    }

            //    if (BillingObj.DeliveryTerms.DeliveryLocation != null)
            //    {
            //        XElement address = FillAddress(BillingObj.DeliveryTerms.DeliveryLocation, "Address");
            //        if (address != null && address.HasElements)
            //        {
            //            nodeLocation = new XElement(cac + "DeliveryLocation", address);
            //        }
            //    }

            //    XElement nodedeliveryTerms = FillDeliveryTerms(nodeLocation, nodeAllowanceDelivery, BillingObj);
            //    if (nodedeliveryTerms != null && nodedeliveryTerms.HasElements)
            //    {
            //        documentXML.Add(nodedeliveryTerms);
            //    }
            //}

            //if (BillingObj.PaymentMeans != null)
            //{
            //    foreach (PaymentMeans rowP in BillingObj.PaymentMeans)
            //    {
            //        XElement nodePaymentMeans = FillPaymentMeans(rowP);
            //        if (nodePaymentMeans != null && nodePaymentMeans.HasElements)
            //        {
            //            documentXML.Add(nodePaymentMeans);
            //        }
            //    }
            //}

            //XElement nodePaymentTerms = FillPaymentTerms(cac, BillingObj.PaymentTerms);
            //if (nodePaymentTerms != null && nodePaymentTerms.HasElements)
            //{
            //    documentXML.Add(nodePaymentTerms);
            //}

            //#region SectorSalud
            //if (BillingObj.EsEscenarioSectorSalud("2"))
            //{
            //    for (int i = 0; i < BillingObj.PrepaidPayment.Count(); i++)
            //    {
            //        int counter = i + 1;

            //        // Verificar si hay un valor en la lista 'nombres' antes de intentar acceder a él
            //        if (nombres.Count > i)
            //        {
            //            string nombre = nombres[i];

            //            XElement OutPrepaidPay = FillPrepaidPaymentNodesSector2(ref cantidadDecimales, BillingObj.PrepaidPayment[i], nombre, counter);

            //            if (OutPrepaidPay != null && OutPrepaidPay.HasElements)
            //            {
            //                documentXML.Add(OutPrepaidPay);
            //            }
            //        }
            //        else
            //        {
            //            // Manejar el caso en el que no hay un valor correspondiente en la lista 'nombres'
            //            XElement OutPrepaidPay = FillPrepaidPaymentNodes(ref cantidadDecimales, BillingObj.PrepaidPayment[i], counter);
            //            if (OutPrepaidPay != null && OutPrepaidPay.HasElements)
            //            {
            //                documentXML.Add(OutPrepaidPay);
            //            }
            //        }
            //    }
            //}

            //else

            //    for (int i = 0; i < BillingObj.PrepaidPayment.Count(); i++)
            //    {
            //        int counter = i + 1;
            //        //documentXml.Add(nodePrepaidPayment);
            //        XElement OutPrepaidPay = FillPrepaidPaymentNodes(ref cantidadDecimales, BillingObj.PrepaidPayment[i], counter);
            //        if (OutPrepaidPay != null && OutPrepaidPay.HasElements)
            //        {
            //            documentXML.Add(OutPrepaidPay);
            //        }
            //    }


            //#endregion


            //if (BillingObj.AllowanceCharge != null)
            //{
            //    foreach (AllowanceCharge allowance in BillingObj.AllowanceCharge)
            //    {
            //        XElement nodeAlowance = FillAllowanceCharge(cac, allowance, ref cantidadDecimales);
            //        if (nodeAlowance != null && nodeAlowance.HasElements)
            //        {
            //            documentXML.Add(nodeAlowance);
            //        }
            //    }
            //}



            //XElement nodePaymentExchangeRate = FillPaymentExchangeRate(cac, BillingObj.PaymentExchangeRate, ref cantidadDecimales);
            //if (nodePaymentExchangeRate != null && nodePaymentExchangeRate.HasElements)
            //{
            //    documentXML.Add(nodePaymentExchangeRate);
            //}

            //XElement nodePaymentAlternativeExchangeRate = FillPaymentAlternativeExchangeRate(cac, BillingObj.PaymentAlternativeExchangeRate, ref cantidadDecimales);
            //if (nodePaymentAlternativeExchangeRate != null && nodePaymentAlternativeExchangeRate.HasElements)
            //{
            //    documentXML.Add(nodePaymentAlternativeExchangeRate);
            //}

            //if (BillingObj.TaxTotal != null)
            //{
            //    foreach (TaxTotal tax in BillingObj.TaxTotal)
            //    {
            //        XElement nodeTaxTotal = FillTaxTotal(cac, tax, ref cantidadDecimales, BillingObj.ValorPorDefectoRedondeoAplicado);
            //        if (nodeTaxTotal != null && nodeTaxTotal.HasElements)
            //        {
            //            documentXML.Add(nodeTaxTotal);
            //        }
            //    }
            //}

            //if (BillingObj.WithholdingTaxTotal != null)
            //{
            //    foreach (WithholdingTaxTotal taxR in BillingObj.WithholdingTaxTotal)
            //    {
            //        XElement nodeWithholdingTaxTotal = FillWithholdingTaxTotal(cac, taxR, ref cantidadDecimales);
            //        if (nodeWithholdingTaxTotal != null && nodeWithholdingTaxTotal.HasElements)
            //        {
            //            documentXML.Add(nodeWithholdingTaxTotal);
            //        }
            //    }
            //}

            //XElement nodelegalMonetary = FillLegalMonetaryTotal("LegalMonetaryTotal", ref cantidadDecimales, BillingObj);
            //if (nodelegalMonetary != null && nodelegalMonetary.HasElements)
            //{
            //    documentXML.Add(nodelegalMonetary);
            //}

            //FillInvoiceLine(cac, ref documentXML, "InvoiceLine", "Invoiced", ref cantidadDecimales, BillingObj);

            //doc.Add(documentXML);

            //string xmlPlano = doc.ToString();

            ////Si tiene algun nodo de sector salud o de exportacion corrige el CustomTagGeneral
            //if (BillingObj.TieneNodoSectorSalud())
            //{
            //    ReemplazarPrimeraOcurrenciaTexto(ref xmlPlano, "<CustomTagGeneral", ">", "<CustomTagGeneral>");
            //    ReemplazarPrimeraOcurrenciaTexto(ref xmlPlano, "<Group", "=", "<Group schemeName=");
            //}
            //else
            //{
            //    foreach (ExtensiblesNote extensiblesNote in BillingObj.Extensible)
            //    {
            //        if (extensiblesNote != null && extensiblesNote.Type == "XML")
            //        {
            //            if (extensiblesNote.ID == "FEXP1" || extensiblesNote.ID == "FEXP2" || extensiblesNote.ID == "FEXP3")
            //            {
            //                ReemplazarPrimeraOcurrenciaTexto(ref xmlPlano, "<CustomTagGeneral", ">", "<CustomTagGeneral>");
            //                ReemplazarPrimeraOcurrenciaTexto(ref xmlPlano, "<Group", "=", "<Group schemeName=");
            //            }
            //            else if (extensiblesNote.Name == "INTE1")
            //            {
            //                ReemplazarPrimeraOcurrenciaTexto(ref xmlPlano, "<CustomTagGeneral xmlns", ">", "<CustomTagGeneral>");
            //            }
            //        }
            //    }
            //}
            string xmlPlano = documentXML.ToString();
            return HelpersCodificador.EncodeBase64(xmlPlano);
        }

    }
}
