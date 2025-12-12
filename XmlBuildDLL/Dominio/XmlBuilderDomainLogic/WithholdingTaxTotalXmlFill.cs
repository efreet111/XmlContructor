using System;
using System.Linq;
using System.Xml.Linq;
using System.Globalization;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class WithholdingTaxTotalXmlFill
    {
        internal static XElement FillWithholdingTaxTotal(WithholdingTaxTotal objTaxTotal, ref int cantidadDecimales)
        {
            XElement taxTotal = null;

            if (objTaxTotal != null)
            {
                taxTotal = new XElement(NamespaceProvider.Cac + "WithholdingTaxTotal");

                WithholdingTaxTotal row = objTaxTotal;

                if (!String.IsNullOrEmpty(row.TaxAmount.ToString()) && !String.IsNullOrEmpty(row.TaxAmount_currencyID))
                    taxTotal.Add(new XElement(
                        NamespaceProvider.Cbc + "TaxAmount",
                        row.TaxAmount.ToString(string.Format(CultureInfo.InvariantCulture, "F{0}", cantidadDecimales), CultureInfo.InvariantCulture),
                        new XAttribute("currencyID", row.TaxAmount_currencyID)
                    ));

                // TaxSubTotals
                if (row.TaxSubtotal != null)
                {
                    // Conversión explícita de la lista si es necesario
                    var taxSubtotals = row.TaxSubtotal.Cast<XmlBuildDLL.BaseClass.Modelresponse.UBL2._1.TaxSubtotal>().ToList();
                    taxTotal = TaxSubTotalXmlFill.FillTaxSubtotal(taxSubtotals, taxTotal, ref cantidadDecimales);
                }
            }

            return taxTotal;
        }
    }
}
