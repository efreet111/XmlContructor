using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class ShareholderPartyXmlFillTests
    {
        [TestMethod]
        public void FillShareholderParty_ReturnsXElement()
        {
            var obj = new PartyLegalEntity();
            var result = ShareholderPartyXmlFill.FillShareholderParty(obj);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(XElement));
        }
    }
}
