using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class ShareholderPartyPartyTests
    {
        [TestMethod]
        public void FillShareholderPartyParty_ReturnsXElement()
        {
            var obj = new PartyLegalEntity();
            var result = ShareholderPartyParty.FillShareholderPartyParty(obj);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(XElement));
        }
    }
}
