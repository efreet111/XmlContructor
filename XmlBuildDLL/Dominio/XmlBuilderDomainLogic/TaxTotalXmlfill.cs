using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.ComonXmlComponent;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class TaxTotalXmlfill
    {
        public static XElement TaxTotal(TaxTotal TaxTotal)
        {
            var fe = NamespaceProvider.Fe;
            var cac = NamespaceProvider.Cac;
            var cbc = NamespaceProvider.Cbc;

            XElement GTaxTotal = new XElement(fe + "TaxTotal");

            GTaxTotal.Add(new XElement(cbc + "TaxAmount", TaxTotal.TaxAmount.ToString("0.0000"),
                new XAttribute("currencyID", TaxTotal.TaxAmount_currencyID)
                ));

            GTaxTotal.Add(new XElement(cbc + "TaxEvidenceIndicator", TaxTotal.TaxEvidenceIndicator.ToLower()));

            if (TaxTotal.TaxSubtotal != null)
            {
                if (TaxTotal.TaxSubtotal.Count > 0)
                {
                    foreach (var GSubtotal in TaxTotal.TaxSubtotal)
                    {
                        XElement taxSubtotal = new XElement(fe + "TaxSubtotal");

                        taxSubtotal.Add(new XElement(cbc + "TaxableAmount", GSubtotal.TaxableAmount.ToString("0.0000"),
                            new XAttribute("currencyID", GSubtotal.TaxableAmount_currencyID)
                            ));

                        taxSubtotal.Add(new XElement(cbc + "TaxAmount", GSubtotal.TaxAmount.ToString("0.0000"),
                            new XAttribute("currencyID", GSubtotal.TaxAmount_currencyID)
                            ));

                        taxSubtotal.Add(new XElement(cbc + "Percent", GSubtotal.Percent.ToString("0.0000")));

                        taxSubtotal.Add(new XElement(cac + "TaxCategory",
                            new XElement(cac + "TaxScheme",
                                new XElement(cbc + "ID", GSubtotal.TaxScheme_ID)
                            )
                        ));

                        GTaxTotal.Add(taxSubtotal);
                    }

                }
            }

            return GTaxTotal;
        }

    }
}
