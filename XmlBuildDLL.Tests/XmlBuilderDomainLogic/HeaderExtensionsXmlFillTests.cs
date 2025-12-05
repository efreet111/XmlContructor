using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.DocumentClass.UBL2._1;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class HeaderExtensionsXmlFillTests
    {
        [TestMethod]
        public void HeaderExtensions_AddsExtensions()
        {
            XElement docXml = new XElement("Root");
            var baseObj = new BillingDocument21Object();
            HeaderExtensionsXmlFill.HeaderExtensions(ref docXml, baseObj);
            Assert.IsTrue(docXml.HasElements);
        }
    }
}
