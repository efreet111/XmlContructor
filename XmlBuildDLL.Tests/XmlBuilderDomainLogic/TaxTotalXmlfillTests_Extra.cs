using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.BaseClass.Modelresponse.UBL2._1;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class TaxTotalXmlfillTests_Extra
    {
        [TestMethod]
        public void FillTaxTotal_IncludesRounding_WhenDefaultProvided()
        {
            var tax = new TaxTotal
            {
                TaxAmount = 10m,
                TaxAmount_currencyID = "COP",
                RoundingAmount = null,
                TaxSubtotal = new List<TaxSubtotal>
                {
                    new TaxSubtotal
                    {
                        TaxableAmount = 100m,
                        TaxableAmount_currencyID = "COP",
                        TaxAmount = 10m,
                        TaxAmount_currencyID = "COP",
                        Percent = 10m,
                        TaxScheme_ID = "01",
                        TaxScheme_Name = "IVA"
                    }
                }
            };
            int dec = 2;
            var node = TaxTotalXmlfill.FillTaxTotal(tax, ref dec, "0.5");

            Assert.IsNotNull(node);
            var rounding = node.Element(NamespaceProvider.Cbc + "RoundingAmount");
            Assert.IsNotNull(rounding);
            Assert.AreEqual("0.50", rounding.Value);
            Assert.AreEqual("COP", rounding.Attribute("currencyID")?.Value);
        }
    }
}
