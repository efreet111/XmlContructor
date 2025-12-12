using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.DocumentClass.UBL2._1;
using XmlBuildDLL.Transversal;
using System.Globalization; // agregado para InvariantCulture

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class InvoiceLineXmlFill
    {
        internal virtual void FillInvoiceLine(ref XElement document, string sLineNodeName, string sQuantityPrefix, ref int cantidadDecimales, BillingDocument21Object obj)
        {
            if (obj.InvoiceLine != null)
            {
                if (obj.InvoiceLine.Count > 0)
                {
                    foreach (InvoiceLine row in obj.InvoiceLine)
                    {
                        XElement line = new XElement(NamespaceProvider.Cac + sLineNodeName);

                        // ID puede ser int/struct; usar comparación con 0 y agregar solo si tiene valor
                        // Evitar ToString() sobre strings null
                        if (row.ID != 0)
                        {
                            if (!String.IsNullOrEmpty(row.ID_schemeID))
                            {
                                line.Add(new XElement(NamespaceProvider.Cbc + "ID", row.ID, new XAttribute("schemeID", row.ID_schemeID)));
                            }
                            else
                            {
                                line.Add(new XElement(NamespaceProvider.Cbc + "ID", row.ID));
                            }
                        }

                        // UUID es string; no llamar ToString() si puede ser null
                        if (!String.IsNullOrEmpty(row.UUID))
                            line.Add(new XElement(NamespaceProvider.Cbc + "UUID", row.UUID));

                        if (!String.IsNullOrEmpty(row.Note))
                            line.Add(new XElement(NamespaceProvider.Cbc + "Note", row.Note));

                        // Usar Quantity para decidir y formatear con punto decimal fijo
                        // Quantity es decimal (struct); comparar contra 0 si se requiere presencia
                        if (row.Quantity != 0m)
                            line.Add(new XElement(
                                NamespaceProvider.Cbc + sQuantityPrefix + "Quantity",
                                row.Quantity.ToString(string.Format(CultureInfo.InvariantCulture, "F{0}", cantidadDecimales), CultureInfo.InvariantCulture),
                                new XAttribute("unitCode", row.Quantity_unitCode)));

                        if (row.LineExtensionAmount != 0m && !String.IsNullOrEmpty(row.LineExtensionAmountCurrencyID))
                            line.Add(new XElement(
                                NamespaceProvider.Cbc + "LineExtensionAmount",
                                row.LineExtensionAmount.ToString(string.Format(CultureInfo.InvariantCulture, "F{0}", cantidadDecimales), CultureInfo.InvariantCulture),
                                new XAttribute("currencyID", row.LineExtensionAmountCurrencyID)
                            ));

                        if (obj.InvoiceTypeCode == HelpersConstantes.TipoDocumento.Fact || obj.InvoiceTypeCode == HelpersConstantes.TipoDocumento.FactExportacion || obj.InvoiceTypeCode == HelpersConstantes.TipoDocumento.FactContingenciaEmisor) //Si es Invoice
                        {
                            line.Add(new XElement(NamespaceProvider.Cbc + "FreeOfChargeIndicator", (row.FreeOfChargeIndicator ? "true" : "false")));
                        }
                        //InvoicePeriod 
                        #region InvoicePeriod
                        if (row.InvoicePeriod != null)
                        {

                            foreach (InvoicePeriod invoicePeriod in row.InvoicePeriod)
                            {
                                XElement nodeInvoicePeriod = InvoicePeriodXmlFill.FillInvoicePeriod(invoicePeriod);
                                if (nodeInvoicePeriod != null)
                                {
                                    line.Add(nodeInvoicePeriod);
                                }
                            }
                        }

                        #endregion InvoicePeriod
                        #region AlternativeConditionPrice   
                        if (row.AlternativeConditionPrice != null)
                        {
                            XElement nodeAlternativeConditionPrice = new XElement(NamespaceProvider.Cac + "PricingReference");

                            foreach (AlternativeConditionPrice altCon in row.AlternativeConditionPrice)
                            {
                                XElement conditionPrice = AlternativeConditionPriceXmlFill.FillAlternativeConditionPrice(altCon, ref cantidadDecimales);
                                if (conditionPrice.HasElements)
                                    nodeAlternativeConditionPrice.Add(conditionPrice);
                            }

                            if (nodeAlternativeConditionPrice != null && nodeAlternativeConditionPrice.HasElements)
                                line.Add(nodeAlternativeConditionPrice);

                        }

                        #endregion

                        #region cac:AllowanceCharge

                        if (row.AllowanceCharge != null)
                        {
                            foreach (AllowanceCharge rowAllowanceCharge in row.AllowanceCharge)
                            {
                                XElement allowanceCharge = AllowanceChargeXmlFill.FillAllowanceCharge(rowAllowanceCharge, ref cantidadDecimales);
                                if (allowanceCharge != null)
                                    line.Add(allowanceCharge);
                            }
                        }

                        #endregion

                        #region cac:TaxTotal

                        if (row.TaxTotal != null)
                        {
                            if (row.TaxTotal.Count > 0)
                            {
                                foreach (TaxTotal rowTaxtotal in row.TaxTotal)
                                {
                                    XElement taxTotalLine = TaxTotalXmlfill.FillTaxTotal(rowTaxtotal, ref cantidadDecimales, obj.ValorPorDefectoRedondeoAplicado);
                                    if (taxTotalLine != null)
                                        line.Add(taxTotalLine);
                                }
                            }
                        }

                        #endregion

                        #region WithholdingTaxTotal - Retenciones 
                        if (row.WithholdingTaxTotal != null)
                        {
                            foreach (WithholdingTaxTotal taxR in row.WithholdingTaxTotal)
                            {
                                XElement nodeWithholdingTaxTotal = WithholdingTaxTotalXmlFill.FillWithholdingTaxTotal(taxR, ref cantidadDecimales);
                                if (nodeWithholdingTaxTotal != null && nodeWithholdingTaxTotal.HasElements)
                                    line.Add(nodeWithholdingTaxTotal);
                            }
                        }

                        #endregion

                        #region de:Item

                        XElement item = LineItemsXmlFill.FillLineItem(row, obj.CustomizationID, ref cantidadDecimales);
                        if (item != null)
                            line.Add(item);



                        #endregion
 
                        #region de:Price

                        XElement price = LinePriceXmlFill.FillLinePrice(row, ref cantidadDecimales);

                        if (price != null)
                            line.Add(price);

                        #endregion

                        document.Add(line);
                    }
                }
            }
        }

    }
}
