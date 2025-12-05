using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.Modelresponse;
using System.Collections.Generic;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class DespatchDocumentReferenceXmlFillTests
    {
        [TestMethod]
        public void FillDespatchDocumentReference_ValidData_ReturnsExpectedXml()
        {
            var obj = new DespatchDocumentReference
            {
                ID = "DREF123",
                UUID = "uuid-xyz",
                UUID_SchemeName = "SchemeX",
                IssueDate = new DateTime(2023, 7, 10),
                DocumentTypeCode = "DTC01",
                DocumentType = "Remision",
                DocumentStatusCode = "Active",
                DocumentDescription = new List<string> { "DescA", "DescB" },
                StartDate = new DateTime(2023, 7, 10),
                EndDate = new DateTime(2023, 7, 11)
            };

            var result = DespatchDocumentReferenceXmlFill.FillDespatchDocumentReference(obj);
            Assert.IsNotNull(result);
            Assert.AreEqual("DREF123", result.Element(NamespaceProvider.Cbc + "ID")?.Value);
            Assert.AreEqual("2023-07-10", result.Element(NamespaceProvider.Cbc + "IssueDate")?.Value);
            Assert.AreEqual("DTC01", result.Element(NamespaceProvider.Cbc + "DocumentTypeCode")?.Value);
            Assert.AreEqual("Remision", result.Element(NamespaceProvider.Cbc + "DocumentType")?.Value);
            Assert.AreEqual("Active", result.Element(NamespaceProvider.Cbc + "DocumentStatusCode")?.Value);
            var descriptions = result.Elements(NamespaceProvider.Cbc + "DocumentDescription");
            CollectionAssert.AreEquivalent(new[] { "DescA", "DescB" }, System.Linq.Enumerable.ToList(System.Linq.Enumerable.Select(descriptions, x => x.Value)));
            var validityPeriod = result.Element(NamespaceProvider.Cac + "ValidityPeriod");
            Assert.IsNotNull(validityPeriod);
            Assert.AreEqual("2023-07-10", validityPeriod.Element(NamespaceProvider.Cbc + "StartDate")?.Value);
            Assert.AreEqual("2023-07-11", validityPeriod.Element(NamespaceProvider.Cbc + "EndDate")?.Value);
        }
    }
}
