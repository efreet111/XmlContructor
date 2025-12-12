using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.BaseClass.Modelresponse.UBL2._1;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class AlternativeConditionPriceXmlFillTests
    {
        [TestMethod]
        public void FillAlternativeConditionPrice_CreatesNode_WhenDataPresent()
        {
            var dec = 2;
            var alt = new AlternativeConditionPrice
            {
                PriceAmount = 80m,
                PriceAmount_currencyID = "USD",
                PriceTypeCode = "01"
            };

            var node = AlternativeConditionPriceXmlFill.FillAlternativeConditionPrice(alt, ref dec);

            Assert.IsNotNull(node);
            Assert.AreEqual("AlternativeConditionPrice", node.Name.LocalName);

            var amt = node.Element(NamespaceProvider.Cbc + "PriceAmount");
            Assert.IsNotNull(amt);
            Assert.AreEqual("80.00", amt.Value);
            Assert.AreEqual("USD", amt.Attribute("currencyID")?.Value);

            var type = node.Element(NamespaceProvider.Cbc + "PriceTypeCode");
            Assert.IsNotNull(type);
            Assert.AreEqual("01", type.Value);
        }

        [TestMethod]
        public void FillAlternativeConditionPrice_ReturnsEmpty_WhenNoFields()
        {
            var dec = 2;
            var alt = new AlternativeConditionPrice();
            var node = AlternativeConditionPriceXmlFill.FillAlternativeConditionPrice(alt, ref dec);
            Assert.IsNotNull(node);
            Assert.IsFalse(node.HasElements);
        }
    }
}
