using System.Collections.Generic;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.BaseClass.Modelresponse.UBL2._1;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class WithholdingTaxTotalXmlFillTests
    {
        [TestMethod]
        public void FillWithholdingTaxTotal_CreatesNode_WithAmountAndSubtotals()
        {
            // arrange
            var dec = 2;
            var wtt = new WithholdingTaxTotal
            {
                TaxAmount = 50m,
                TaxAmount_currencyID = "COP",
                TaxSubtotal = new List<TaxSubtotal>
                {
                    new TaxSubtotal
                    {
                        TaxableAmount = 200m,
                        TaxableAmount_currencyID = "COP",
                        TaxAmount = 50m,
                        TaxAmount_currencyID = "COP",
                        Percent = 25m,
                        TaxScheme_ID = "06",
                        TaxScheme_Name = "ReteFuente"
                    }
                }
            };

            // act
            var node = WithholdingTaxTotalXmlFill.FillWithholdingTaxTotal(wtt, ref dec);

            // assert
            Assert.IsNotNull(node);
            Assert.AreEqual("WithholdingTaxTotal", node.Name.LocalName);

            var taxAmount = node.Element(NamespaceProvider.Cbc + "TaxAmount");
            Assert.IsNotNull(taxAmount);
            Assert.AreEqual("50.00", taxAmount.Value);
            Assert.AreEqual("COP", taxAmount.Attribute("currencyID")?.Value);

            var taxSubtotal = node.Element(NamespaceProvider.Cac + "TaxSubtotal");
            Assert.IsNotNull(taxSubtotal);
            Assert.AreEqual("200.00", taxSubtotal.Element(NamespaceProvider.Cbc + "TaxableAmount")?.Value);
            Assert.AreEqual("COP", taxSubtotal.Element(NamespaceProvider.Cbc + "TaxableAmount")?.Attribute("currencyID")?.Value);
            Assert.AreEqual("50.00", taxSubtotal.Element(NamespaceProvider.Cbc + "TaxAmount")?.Value);
            Assert.AreEqual("COP", taxSubtotal.Element(NamespaceProvider.Cbc + "TaxAmount")?.Attribute("currencyID")?.Value);
            Assert.AreEqual("25", taxSubtotal.Element(NamespaceProvider.Cbc + "Percent")?.Value);

            var scheme = taxSubtotal.Element(NamespaceProvider.Cac + "TaxCategory")?.Element(NamespaceProvider.Cac + "TaxScheme");
            Assert.IsNotNull(scheme);
            Assert.AreEqual("06", scheme.Element(NamespaceProvider.Cbc + "ID")?.Value);
            Assert.AreEqual("ReteFuente", scheme.Element(NamespaceProvider.Cbc + "Name")?.Value);
        }

        [TestMethod]
        public void FillWithholdingTaxTotal_ReturnsNull_WhenObjectIsNull()
        {
            var dec = 2;
            var node = WithholdingTaxTotalXmlFill.FillWithholdingTaxTotal(null, ref dec);
            Assert.IsNull(node);
        }
    }
}
