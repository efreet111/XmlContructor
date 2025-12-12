using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Globalization;
using XmlBuildDLL.BaseClass.Modelresponse.UBL2._1;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class TaxSubTotalXmlFill
    {
        internal static XElement FillTaxSubtotal(List<TaxSubtotal> taxSubtotals, XElement nodeTotal, ref int cantidadDecimales)
        {
            if (taxSubtotals != null)
            {
                if (taxSubtotals.Count > 0)
                {
                    foreach (TaxSubtotal rowSub in taxSubtotals)
                    {
                        XElement taxsubTotal = new XElement(NamespaceProvider.Cac + "TaxSubtotal");

                        if (!String.IsNullOrEmpty(rowSub.TaxableAmount.ToString()) && !String.IsNullOrEmpty(rowSub.TaxableAmount_currencyID))
                            taxsubTotal.Add(new XElement(
                                NamespaceProvider.Cbc + "TaxableAmount",
                                rowSub.TaxableAmount.ToString(string.Format(CultureInfo.InvariantCulture, "F{0}", cantidadDecimales), CultureInfo.InvariantCulture),
                                new XAttribute("currencyID", rowSub.TaxableAmount_currencyID)
                            ));

                        if (!String.IsNullOrEmpty(rowSub.TaxAmount.ToString()) && !String.IsNullOrEmpty(rowSub.TaxAmount_currencyID))
                            taxsubTotal.Add(new XElement(
                                NamespaceProvider.Cbc + "TaxAmount",
                                rowSub.TaxAmount.ToString(string.Format(CultureInfo.InvariantCulture, "F{0}", cantidadDecimales), CultureInfo.InvariantCulture),
                                new XAttribute("currencyID", rowSub.TaxAmount_currencyID)
                            ));

                        // Percent debe ser hijo directo de TaxSubtotal
                        if (rowSub.Percent.HasValue)
                        {
                            var percentVal = rowSub.Percent.Value;
                            string percentStr;
                            if (percentVal == Math.Truncate(percentVal))
                            {
                                // entero -> sin decimales
                                percentStr = percentVal.ToString("0", CultureInfo.InvariantCulture);
                            }
                            else
                            {
                                // con decimales -> máximo 2 decimales
                                percentStr = percentVal.ToString("0.##", CultureInfo.InvariantCulture);
                            }
                            taxsubTotal.Add(new XElement(NamespaceProvider.Cbc + "Percent", percentStr));
                        }

                        if (rowSub.BaseUnitMeasure.HasValue && !String.IsNullOrEmpty(rowSub.BaseUnitMeasure_unitCode))
                            taxsubTotal.Add(new XElement(
                                NamespaceProvider.Cbc + "BaseUnitMeasure",
                                rowSub.BaseUnitMeasure.Value.ToString(string.Format(CultureInfo.InvariantCulture, "F{0}", cantidadDecimales), CultureInfo.InvariantCulture),
                                new XAttribute("unitCode", rowSub.BaseUnitMeasure_unitCode)
                            ));

                        if (rowSub.PerUnitAmount.HasValue && !String.IsNullOrEmpty(rowSub.PerUnitAmount_currencyID))
                            taxsubTotal.Add(new XElement(
                                NamespaceProvider.Cbc + "PerUnitAmount",
                                rowSub.PerUnitAmount.Value.ToString(string.Format(CultureInfo.InvariantCulture, "F{0}", cantidadDecimales), CultureInfo.InvariantCulture),
                                new XAttribute("currencyID", rowSub.PerUnitAmount_currencyID)
                            ));

                        if (!String.IsNullOrEmpty(rowSub.TaxScheme_ID) && !String.IsNullOrEmpty(rowSub.TaxScheme_Name))
                        {
                            XElement taxCategory = new XElement(NamespaceProvider.Cac + "TaxCategory");

                            if (!String.IsNullOrWhiteSpace(rowSub.TaxScheme_ID))
                            {
                                taxCategory.Add(
                                    new XElement(NamespaceProvider.Cac + "TaxScheme",
                                        new XElement(NamespaceProvider.Cbc + "ID", rowSub.TaxScheme_ID),
                                        new XElement(NamespaceProvider.Cbc + "Name", rowSub.TaxScheme_Name)));
                            }

                            if (taxCategory.HasElements)
                                taxsubTotal.Add(taxCategory);
                        }

                        if (taxsubTotal.HasElements)
                            nodeTotal.Add(taxsubTotal);
                    }
                }
            }

            return nodeTotal;
        }

    }
}
