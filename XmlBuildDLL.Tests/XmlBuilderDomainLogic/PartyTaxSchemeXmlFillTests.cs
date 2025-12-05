using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class PartyTaxSchemeXmlFillTests
    {
        [TestMethod]
        public void FillPartyTaxScheme_ReturnsXElement()
        {
            var obj = new PartyTaxScheme();
            var result = PartyTaxSchemeXmlFill.FillPartyTaxScheme("ns", obj);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(XElement));
        }
    }
}
