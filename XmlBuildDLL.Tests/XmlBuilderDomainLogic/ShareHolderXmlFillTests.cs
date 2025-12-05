using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class ShareHolderXmlFillTests
    {
        [TestMethod]
        public void FillShareHolder_ReturnsXElement()
        {
            var obj = new ShareHolderParty();
            var result = ShareHolderXmlFill.FillShareHolder(obj);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(XElement));
        }
    }
}
