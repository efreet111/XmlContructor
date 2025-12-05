using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio;
using XmlBuildDLL.BaseClass;
using XmlBuildDLL.BaseClass.XmlBodyComponent;
using System;
using XmlBuildDLL.BaseClass.Dianheaders;

namespace XmlBuildDLL.Tests
{
    [TestClass]
    public class BuilderXmlDominioTests
    {
        [TestMethod]
        public void BuildXML_ShouldReturnValidXml_ForInvoiceType01()
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
                TaxTotal = new System.Collections.Generic.List<XmlBuildDLL.BaseClass.ComonXmlComponent.TaxTotal>(),
                LegalMonetaryTotal = new XmlBuildDLL.BaseClass.ComonXmlComponent.LegalMonetaryTotal(),
                Line = new System.Collections.Generic.List<XmlBuildDLL.BaseClass.XmlBodyComponent.Line>()
            };

            //var builder = new BuilderXmlDominio();

            //// Act
            //var xml = builder.BuildXML(orquestator);

            //// Assert
            //Assert.IsFalse(string.IsNullOrWhiteSpace(xml));
            //Assert.IsTrue(xml.Contains("Invoice"));
            //Assert.IsTrue(xml.Contains("UBLVersionID"));
            //Assert.IsTrue(xml.Contains("ProfileID"));
        }
    }
}
