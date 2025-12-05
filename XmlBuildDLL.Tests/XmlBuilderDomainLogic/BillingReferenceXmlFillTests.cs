using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class BillingReferenceXmlFillTests
    {
        [TestMethod]
        public void FillBillingReference_ValidData_ReturnsExpectedXml()
        {
            var obj = new BillingReference
            {
                InvoiceID = "INV001",
                InvoiceUUID = "uuid-inv",
                InvoiceschemeName = "SchemeINV",
                InvoiceIssueDate = new DateTime(2023, 11, 1)
            };
            var result = BillingReferenceXmlFill.FillBillingReference(obj, "Invoice");
            Assert.IsNotNull(result);
            var invoiceDocRef = result.Element(NamespaceProvider.Cac + "InvoiceDocumentReference");
            Assert.IsNotNull(invoiceDocRef);
            Assert.AreEqual("INV001", invoiceDocRef.Element(NamespaceProvider.Cbc + "ID")?.Value);
            Assert.AreEqual("uuid-inv", invoiceDocRef.Element(NamespaceProvider.Cbc + "UUID")?.Value);
            Assert.AreEqual("SchemeINV", invoiceDocRef.Element(NamespaceProvider.Cbc + "UUID")?.Attribute("schemeName")?.Value);
            Assert.AreEqual("2023-11-01", invoiceDocRef.Element(NamespaceProvider.Cbc + "IssueDate")?.Value);
        }
    }
}
