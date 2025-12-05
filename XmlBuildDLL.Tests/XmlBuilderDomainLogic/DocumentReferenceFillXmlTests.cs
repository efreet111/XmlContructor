using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class DocumentReferenceFillXmlTests
    {
        [TestMethod]
        public void FillDocumentReference_ValidData_ReturnsExpectedXml()
        {
            var obj = new AdditionalDocumentReference
            {
                ID = "DOCREF001",
                UUID = "uuid-docref",
                UUID_SchemeName = "SchemeDOCREF",
                IssueDate = new DateTime(2023, 12, 1),
                DocumentTypeCode = "DTCREF01",
                DocumentType = "Referencia",
                DocumentStatusCode = "Active",
                DocumentDescription = new System.Collections.Generic.List<string> { "DescDR1", "DescDR2" },
                StartDate = new DateTime(2023, 12, 1),
                EndDate = new DateTime(2023, 12, 2)
            };
            var result = DocumentReferenceFillXml.FillDocumentReference(obj);
            Assert.IsNotNull(result);
            Assert.AreEqual("DOCREF001", result.Element(NamespaceProvider.Cbc + "ID")?.Value);
            Assert.AreEqual("uuid-docref", result.Element(NamespaceProvider.Cbc + "UUID")?.Value);
            Assert.AreEqual("SchemeDOCREF", result.Element(NamespaceProvider.Cbc + "UUID")?.Attribute("schemeName")?.Value);
            Assert.AreEqual("2023-12-01", result.Element(NamespaceProvider.Cbc + "IssueDate")?.Value);
            Assert.AreEqual("DTCREF01", result.Element(NamespaceProvider.Cbc + "DocumentTypeCode")?.Value);
            Assert.AreEqual("Referencia", result.Element(NamespaceProvider.Cbc + "DocumentType")?.Value);
            Assert.AreEqual("Active", result.Element(NamespaceProvider.Cbc + "DocumentStatusCode")?.Value);
            var descriptions = result.Elements(NamespaceProvider.Cbc + "DocumentDescription");
            CollectionAssert.AreEquivalent(new[] { "DescDR1", "DescDR2" }, System.Linq.Enumerable.ToList(System.Linq.Enumerable.Select(descriptions, x => x.Value)));
            var validityPeriod = result.Element(NamespaceProvider.Cbc + "ValidityPeriod");
            Assert.IsNotNull(validityPeriod);
            Assert.AreEqual("2023-12-01", validityPeriod.Element(NamespaceProvider.Cbc + "StartDate")?.Value);
            Assert.AreEqual("2023-12-02", validityPeriod.Element(NamespaceProvider.Cbc + "EndDate")?.Value);
        }
    }
}
