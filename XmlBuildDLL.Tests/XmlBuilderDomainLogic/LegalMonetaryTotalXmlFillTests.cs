using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.ComonXmlComponent;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class LegalMonetaryTotalXmlFillTests
    {
        [TestMethod]
        public void LegalMonetaryTotal_ValidData_ReturnsExpectedXml()
        {
            var docObj = new LegalMonetaryTotal
            {
                LineExtensionAmount = 1000,
                LineExtensionAmountCurrencyID = "COP",
                TaxExclusiveAmount = 900,
                TaxExclusiveAmountCurrencyID = "COP",
                PayableAmount = 1100,
                PayableAmountCurrencyID = "COP"
            };
            var result = LegalMonetaryTotalXmlFill.LegalMonetaryTotal(docObj);
            Assert.IsNotNull(result);
            Assert.AreEqual("1000.0000", result.Element(NamespaceProvider.Cbc + "LineExtensionAmount")?.Value);
            Assert.AreEqual("COP", result.Element(NamespaceProvider.Cbc + "LineExtensionAmount")?.Attribute("currencyID")?.Value);
            Assert.AreEqual("900.0000", result.Element(NamespaceProvider.Cbc + "TaxExclusiveAmount")?.Value);
            Assert.AreEqual("COP", result.Element(NamespaceProvider.Cbc + "TaxExclusiveAmount")?.Attribute("currencyID")?.Value);
            Assert.AreEqual("1100.0000", result.Element(NamespaceProvider.Cbc + "PayableAmount")?.Value);
            Assert.AreEqual("COP", result.Element(NamespaceProvider.Cbc + "PayableAmount")?.Attribute("currencyID")?.Value);
        }
    }
}
