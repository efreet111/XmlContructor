using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using System.Collections.Generic;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class AdditionalDocumentReferenceXmlFillTests
    {
        [TestMethod]
        public void FillAdditionalDocumentReference_ValidData_ReturnsExpectedXml()
        {
            var obj = new AdditionalDocumentReference
            {
                ID = "AD123",
                UUID = "uuid-ad",
                UUID_SchemeName = "SchemeAD",
                IssueDate = new DateTime(2023, 8, 1),
                DocumentTypeCode = "ADC01",
                DocumentType = "Adjunto",
                DocumentStatusCode = "Active",
                DocumentDescription = new List<string> { "DescAD1", "DescAD2" },
                StartDate = new DateTime(2023, 8, 1),
                EndDate = new DateTime(2023, 8, 2)
            };

            var result = AdditionalDocumentReferenceXmlFill.FillAdditionalDocumentReference(obj);
            Assert.IsNotNull(result);
            Assert.AreEqual("AD123", result.Element(NamespaceProvider.Cbc + "ID")?.Value);
            Assert.AreEqual("uuid-ad", result.Element(NamespaceProvider.Cbc + "UUID")?.Value);
            Assert.AreEqual("SchemeAD", result.Element(NamespaceProvider.Cbc + "UUID")?.Attribute("schemeName")?.Value);
            Assert.AreEqual("2023-08-01", result.Element(NamespaceProvider.Cbc + "IssueDate")?.Value);
            Assert.AreEqual("ADC01", result.Element(NamespaceProvider.Cbc + "DocumentTypeCode")?.Value);
            Assert.AreEqual("Adjunto", result.Element(NamespaceProvider.Cbc + "DocumentType")?.Value);
            Assert.AreEqual("Active", result.Element(NamespaceProvider.Cbc + "DocumentStatusCode")?.Value);
            var descriptions = result.Elements(NamespaceProvider.Cbc + "DocumentDescription");
            CollectionAssert.AreEquivalent(new[] { "DescAD1", "DescAD2" }, System.Linq.Enumerable.ToList(System.Linq.Enumerable.Select(descriptions, x => x.Value)));
            var validityPeriod = result.Element(NamespaceProvider.Cac + "ValidityPeriod");
            Assert.IsNotNull(validityPeriod);
            Assert.AreEqual("2023-08-01", validityPeriod.Element(NamespaceProvider.Cbc + "StartDate")?.Value);
            Assert.AreEqual("2023-08-02", validityPeriod.Element(NamespaceProvider.Cbc + "EndDate")?.Value);
        }
    }
}
