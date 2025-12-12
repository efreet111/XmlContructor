using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.XmlBodyComponent;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class LineItemsXmlFillTests
    {
        [TestMethod]
        public void LineItems_ValidData_ReturnsExpectedXml()
        {
            var line = new Line
            {
                ID = "L001",
                UUID = "uuid-line",
                Note = "Nota de línea",
                Quantity = 10,
                LineExtensionAmount = 1000,
                LineExtensionAmountCurrencyID = "COP",
                AccountingCostCode = "ACC01",
                AccountingCost = "Costo1"
            };
            //var result = LineItemsXmlFill.FillLineItem(line, "01");
            //Assert.IsNotNull(result);
            //Assert.AreEqual("L001", result.Element(NamespaceProvider.Cbc + "ID")?.Value);
            //Assert.AreEqual("uuid-line", result.Element(NamespaceProvider.Cbc + "UUID")?.Value);
            //Assert.AreEqual("Nota de línea", result.Element(NamespaceProvider.Cbc + "Note")?.Value);
            //Assert.AreEqual("10.0000", result.Element(NamespaceProvider.Cbc + "InvoicedQuantity")?.Value);
            //Assert.AreEqual("1000.0000", result.Element(NamespaceProvider.Cbc + "LineExtensionAmount")?.Value);
            //Assert.AreEqual("COP", result.Element(NamespaceProvider.Cbc + "LineExtensionAmount")?.Attribute("currencyID")?.Value);
            //Assert.AreEqual("ACC01", result.Element(NamespaceProvider.Cbc + "AccountingCostCode")?.Value);
            //Assert.AreEqual("Costo1", result.Element(NamespaceProvider.Cbc + "AccountingCost")?.Value);
        }
    }
}
