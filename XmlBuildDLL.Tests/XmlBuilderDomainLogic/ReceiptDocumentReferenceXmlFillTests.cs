using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class ReceiptDocumentReferenceXmlFillTests
    {
        [TestMethod]
        public void FillReceiptDocumentReference_ValidData_ReturnsExpectedXml()
        {
            var obj = new ReceiptDocumentReference
            {
                ID = "123",
                UUID = "abc-uuid",
                UUID_SchemeName = "TestScheme",
                IssueDate = new DateTime(2023, 5, 1),
                DocumentTypeCode = "DT01",
                DocumentType = "Factura",
                DocumentStatusCode = "Active",
                DocumentDescription = new System.Collections.Generic.List<string> { "Desc1", "Desc2" },
                StartDate = new DateTime(2023, 5, 1),
                EndDate = new DateTime(2023, 5, 2)
            };

            var result = ReceiptDocumentReferenceXmlFill.FillReceiptDocumentReference(obj);
            Assert.IsNotNull(result);
            Assert.AreEqual("123", result.Element(NamespaceProvider.Cbc + "ID")?.Value);
            Assert.AreEqual("abc-uuid", result.Element(NamespaceProvider.Cbc + "UUID")?.Value);
            Assert.AreEqual("TestScheme", result.Element(NamespaceProvider.Cbc + "UUID")?.Attribute("schemeName")?.Value);
            Assert.AreEqual("2023-05-01", result.Element(NamespaceProvider.Cbc + "IssueDate")?.Value);
            Assert.AreEqual("DT01", result.Element(NamespaceProvider.Cbc + "DocumentTypeCode")?.Value);
            Assert.AreEqual("Factura", result.Element(NamespaceProvider.Cbc + "DocumentType")?.Value);
            Assert.AreEqual("Active", result.Element(NamespaceProvider.Cbc + "DocumentStatusCode")?.Value);
            var descriptions = result.Elements(NamespaceProvider.Cbc + "DocumentDescription");
            CollectionAssert.AreEquivalent(new[] { "Desc1", "Desc2" }, System.Linq.Enumerable.ToList(System.Linq.Enumerable.Select(descriptions, x => x.Value)));
            var validityPeriod = result.Element(NamespaceProvider.Cac + "ValidityPeriod");
            Assert.IsNotNull(validityPeriod);
            Assert.AreEqual("2023-05-01", validityPeriod.Element(NamespaceProvider.Cbc + "StartDate")?.Value);
            Assert.AreEqual("2023-05-02", validityPeriod.Element(NamespaceProvider.Cbc + "EndDate")?.Value);
        }
    }
}
