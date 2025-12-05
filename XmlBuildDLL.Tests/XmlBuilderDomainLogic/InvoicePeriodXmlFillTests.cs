using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class InvoicePeriodXmlFillTests
    {
        [TestMethod]
        public void FillInvoicePeriod_ValidData_ReturnsExpectedXml()
        {
            var obj = new InvoicePeriod
            {
                StartDate = new DateTime(2023, 6, 1),
                StartTime = new DateTime(2023, 6, 1, 8, 30, 0),
                EndDate = new DateTime(2023, 6, 30),
                EndTime = new DateTime(2023, 6, 30, 17, 0, 0)
            };

            var result = InvoicePeriodXmlFill.FillInvoicePeriod(obj);
            Assert.IsNotNull(result);
            Assert.AreEqual("2023-06-01", result.Element(NamespaceProvider.Cbc + "StartDate")?.Value);
            Assert.AreEqual("08:30:00", result.Element(NamespaceProvider.Cbc + "StartTime")?.Value);
            Assert.AreEqual("2023-06-30", result.Element(NamespaceProvider.Cbc + "EndDate")?.Value);
            Assert.AreEqual("05:00:00", result.Element(NamespaceProvider.Cbc + "EndTime")?.Value); // 12h format
        }
    }
}
