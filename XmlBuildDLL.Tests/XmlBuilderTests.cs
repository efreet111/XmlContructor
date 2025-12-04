using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL;
using XmlBuildDLL.BaseClass;
using XmlBuildDLL.BaseClass.XmlBodyComponent;
using XmlBuildDLL.BaseClass.Dianheaders;
using System;
using System.Collections.Generic;

namespace XmlBuildDLL.Tests
{
    [TestClass] 
    public class XmlBuilderTests
    {
        [TestMethod]
        public void XmlDocument_ShouldReturnValidXml_ForInvoiceType01()
        {
            // Arrange
            var orquestator = new OrquestatorXmlClass
            {
                BodyXml = new BodyXml
                {
                    TypeDocumentCode = "01",
                    ID = "12345",
                    UUID = "ABC-123-XYZ",
                    IssueDate = DateTime.Now,
                    IssueTime = DateTime.Now.TimeOfDay,
                    InvoiceTypeCode = "01",
                    Note = "Test note",
                    DocumentCurrencyCode = "COP"
                },
                AccountingSupplierParty = new XmlBuildDLL.BaseClass.AccountingSupplierParty.AccountingSupplierParty(),
                AccountingCustomerParty = new XmlBuildDLL.BaseClass.AccountingCustomerParty.AccountingCustomerParty(),
                TaxTotal = new List<XmlBuildDLL.BaseClass.ComonXmlComponent.TaxTotal>(),
                LegalMonetaryTotal = new XmlBuildDLL.BaseClass.ComonXmlComponent.LegalMonetaryTotal(),
                Line = new List<XmlBuildDLL.BaseClass.XmlBodyComponent.Line>()
            };

            var builder = new XmlBuilder();

            // Act
            var response = builder.XmlDocument(orquestator);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsFalse(string.IsNullOrWhiteSpace(response.xml));
            Assert.IsTrue(response.xml.Contains("Invoice"));
            Assert.IsTrue(response.xml.Contains("UBLVersionID"));
            Assert.IsTrue(response.xml.Contains("ProfileID"));
        }
    }
}
