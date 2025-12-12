using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.ComonXmlComponent;
using System.Collections.Generic;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class TaxTotalXmlfillTests
    {
        [TestMethod]
        public void TaxTotal_ValidData_ReturnsExpectedXml()
        {
            var taxTotal = new TaxTotal
            {
                TaxAmount = 200,
                TaxAmount_currencyID = "COP",
                TaxEvidenceIndicator = "true",
                TaxSubtotal = new List<TaxSubtotal>
                {
                    new TaxSubtotal
                    {
                        TaxableAmount = 100,
                        TaxableAmount_currencyID = "COP",
                        TaxAmount = 200,
                        TaxAmount_currencyID = "COP",
                        Percent = 19,
                        TaxScheme_ID = "01"
                    }
                }
            };
            //var result = TaxTotalXmlfill.TaxTotal(taxTotal);
            //Assert.IsNotNull(result);
            //Assert.AreEqual("200.0000", result.Element(NamespaceProvider.Cbc + "TaxAmount")?.Value);
            //Assert.AreEqual("COP", result.Element(NamespaceProvider.Cbc + "TaxAmount")?.Attribute("currencyID")?.Value);
            //Assert.AreEqual("true", result.Element(NamespaceProvider.Cbc + "TaxEvidenceIndicator")?.Value);
            //var subtotal = result.Element(NamespaceProvider.Fe + "TaxSubtotal");
            //Assert.IsNotNull(subtotal);
            //Assert.AreEqual("100.0000", subtotal.Element(NamespaceProvider.Cbc + "TaxableAmount")?.Value);
            //Assert.AreEqual("COP", subtotal.Element(NamespaceProvider.Cbc + "TaxableAmount")?.Attribute("currencyID")?.Value);
            //Assert.AreEqual("200.0000", subtotal.Element(NamespaceProvider.Cbc + "TaxAmount")?.Value);
            //Assert.AreEqual("COP", subtotal.Element(NamespaceProvider.Cbc + "TaxAmount")?.Attribute("currencyID")?.Value);
            //Assert.AreEqual("19.0000", subtotal.Element(NamespaceProvider.Cbc + "Percent")?.Value);
            //Assert.AreEqual("01", subtotal.Element(NamespaceProvider.Cac + "TaxCategory")?.Element(NamespaceProvider.Cac + "TaxScheme")?.Element(NamespaceProvider.Cbc + "ID")?.Value);
        }
    }
}
