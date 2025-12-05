using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class OrderReferenceXmlFillTests
    {
        [TestMethod]
        public void FillOrderReference_ValidData_ReturnsExpectedXml()
        {
            var obj = new OrderReference
            {
                ID = "ORD001",
                SalesOrderID = "SO001",
                UUID = "uuid-ord",
                UUIDSchemeName = "SchemeORD",
                IssueDate = new DateTime(2023, 10, 1),
                IssueTime = new DateTime(2023, 10, 1, 14, 0, 0),
                CustomerReference = "CUSTREF001",
                OrderTypeCode = "OTC01"
            };
            var result = OrderReferenceXmlFill.FillOrderReference("ns", obj);
            Assert.IsNotNull(result);
            Assert.AreEqual("ORD001", result.Element(NamespaceProvider.Cbc + "ID")?.Value);
            Assert.AreEqual("SO001", result.Element(NamespaceProvider.Cbc + "SalesOrderID")?.Value);
            Assert.AreEqual("uuid-ord", result.Element(NamespaceProvider.Cbc + "UUID")?.Value);
            Assert.AreEqual("SchemeORD", result.Element(NamespaceProvider.Cbc + "UUID")?.Attribute("schemeName")?.Value);
            Assert.AreEqual("2023-10-01", result.Element(NamespaceProvider.Cbc + "IssueDate")?.Value);
            Assert.AreEqual("02:00:00", result.Element(NamespaceProvider.Cbc + "IssueTime")?.Value); // 12h format
            Assert.AreEqual("CUSTREF001", result.Element(NamespaceProvider.Cbc + "CustomerReference")?.Value);
            Assert.AreEqual("OTC01", result.Element(NamespaceProvider.Cbc + "OrderTypeCode")?.Value);
        }
    }
}
