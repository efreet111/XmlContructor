using System;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.BaseClass.Modelresponse.UBL2._1;
using System.Globalization;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class TaxTotalXmlfill
    {
        internal static XElement FillTaxTotal(TaxTotal objTaxTotal, ref int cantidadDecimales, string valorPorDefectoRedondeoAplicado)
        {
            XElement taxTotal = null;

            if (objTaxTotal != null)
            {
                taxTotal = new XElement(NamespaceProvider.Cac + "TaxTotal");

                TaxTotal row = objTaxTotal;

                if (!String.IsNullOrEmpty(row.TaxAmount.ToString()) && !String.IsNullOrEmpty(row.TaxAmount_currencyID))
                    taxTotal.Add(new XElement(NamespaceProvider.Cbc + "TaxAmount",
                        row.TaxAmount.ToString(string.Format(CultureInfo.InvariantCulture, "F{0}", cantidadDecimales), CultureInfo.InvariantCulture),
                        new XAttribute("currencyID", row.TaxAmount_currencyID)
                    ));

                if (String.IsNullOrEmpty(row.RoundingAmount) && !String.IsNullOrEmpty(valorPorDefectoRedondeoAplicado))
                {
                    row.RoundingAmount = valorPorDefectoRedondeoAplicado;
                }

                if (!String.IsNullOrEmpty(row.RoundingAmount))
                {
                    // Parse con cultura invariante para evitar problemas con separadores decimales según configuración regional
                    var roundingDecimal = decimal.Parse(row.RoundingAmount, CultureInfo.InvariantCulture);
                    row.RoundingAmount = roundingDecimal.ToString(string.Format(CultureInfo.InvariantCulture, "F{0}", cantidadDecimales), CultureInfo.InvariantCulture);
                    taxTotal.Add(new XElement(NamespaceProvider.Cbc + "RoundingAmount", row.RoundingAmount, new XAttribute("currencyID", row.TaxAmount_currencyID)));
                }

                if (!String.IsNullOrEmpty(row.TaxEvidenceIndicator))
                    taxTotal.Add(new XElement(NamespaceProvider.Cbc + "TaxEvidenceIndicator", (row.TaxEvidenceIndicator == "true" ? "true" : "false")));

                //TaxSubTotals
                if (row.TaxSubtotal != null)
                {
                    taxTotal = TaxSubTotalXmlFill.FillTaxSubtotal(row.TaxSubtotal, taxTotal, ref cantidadDecimales);
                }
            }
            return taxTotal;
        }
    }
}
