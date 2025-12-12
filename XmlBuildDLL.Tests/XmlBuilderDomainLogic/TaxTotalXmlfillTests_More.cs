using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.BaseClass.Modelresponse.UBL2._1;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class TaxTotalXmlfillTests_More
    {
        [TestMethod]
        public void FillTaxTotal_MultipleSubtotals_AndEvidenceIndicator()
        {
            var tax = new TaxTotal
            {
                TaxAmount = 300m,
                TaxAmount_currencyID = "COP",
                TaxEvidenceIndicator = "true",
                TaxSubtotal = new List<TaxSubtotal>
                {
                    new TaxSubtotal
                    {
                        TaxableAmount = 1000m,
                        TaxableAmount_currencyID = "COP",
                        TaxAmount = 190m,
                        TaxAmount_currencyID = "COP",
                        Percent = 19m,
                        TaxScheme_ID = "01",
                        TaxScheme_Name = "IVA"
                    },
                    new TaxSubtotal
                    {
                        TaxableAmount = 500m,
                        TaxableAmount_currencyID = "COP",
                        TaxAmount = 110m,
                        TaxAmount_currencyID = "COP",
                        Percent = 22m,
                        TaxScheme_ID = "ZZ",
                        TaxScheme_Name = "IMP"
                    }
                }
            };
            int dec = 2;
            var node = TaxTotalXmlfill.FillTaxTotal(tax, ref dec, null);

            Assert.IsNotNull(node);
            Assert.AreEqual("TaxTotal", node.Name.LocalName);
            Assert.AreEqual("300.00", node.Element(NamespaceProvider.Cbc + "TaxAmount")?.Value);
            Assert.AreEqual("COP", node.Element(NamespaceProvider.Cbc + "TaxAmount")?.Attribute("currencyID")?.Value);
            Assert.AreEqual("true", node.Element(NamespaceProvider.Cbc + "TaxEvidenceIndicator")?.Value);

            var subtotals = node.Elements(NamespaceProvider.Cac + "TaxSubtotal");
            int count = 0;
            foreach (var _ in subtotals) count++;
            Assert.AreEqual(2, count);
        }
    }
}
