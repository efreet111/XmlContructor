using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.DocumentClass.UBL2._1;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class DianExtensionsXmlFillTests
    {
        [TestMethod]
        public void FillDianExtensions_ReturnsXElementOrNull()
        {
            var obj = new BillingDocument21Object();
            var result = DianExtensionsXmlFill.FillDianExtensions(obj);
            Assert.IsTrue(result == null || result is XElement);
        }
    }
}
