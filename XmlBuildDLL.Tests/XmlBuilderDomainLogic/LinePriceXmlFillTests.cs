using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class LinePriceXmlFillTests
    {
        [TestMethod]
        public void FillLinePrice_CreatesPrice_WithAmountAndBaseQuantity()
        {
            var dec = 4;
            var line = new InvoiceLine
            {
                PriceAmount = 12.5m,
                PriceAmount_currencyID = "USD",
                BaseQuantity = 3m,
                BaseQuantity_unitCode = "EA"
            };

            var node = LinePriceXmlFill.FillLinePrice(line, ref dec);
            Assert.IsNotNull(node);
            Assert.AreEqual("Price", node.Name.LocalName);

            var amt = node.Element(NamespaceProvider.Cbc + "PriceAmount");
            Assert.AreEqual("12.5000", amt?.Value);
            Assert.AreEqual("USD", amt?.Attribute("currencyID")?.Value);

            var baseQty = node.Element(NamespaceProvider.Cbc + "BaseQuantity");
            Assert.AreEqual("3.0000", baseQty?.Value);
            Assert.AreEqual("EA", baseQty?.Attribute("unitCode")?.Value);
        }

        [TestMethod]
        public void FillLinePrice_ReturnsNull_WhenNoElements()
        {
            var dec = 2;
            var line = new InvoiceLine();
            var node = LinePriceXmlFill.FillLinePrice(line, ref dec);
            Assert.IsNull(node);
        }
    }
}
