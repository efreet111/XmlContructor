using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass;
using System.Collections.Generic;
using XmlBuildDLL.BaseClass.Dianheaders;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class AdditionalInformationXmlFillTests
    {
        [TestMethod]
        public void FillAdditionalInformation_ValidData_ReturnsExpectedXml()
        {
            var docObj = new OrquestatorXmlClass
            {
                ExtensionFields = new List<ExtensionsFree>
                {
                    new ExtensionsFree { AdditionalPropertyID = "ID1", AdditionalPropertyValue = "Value1" },
                    new ExtensionsFree { AdditionalPropertyID = "ID2", AdditionalPropertyValue = "Value2" }
                }
            };
            var result = AdditionalInformationXmlFill.FillAdditionalInformation(docObj);
            Assert.IsNotNull(result);
            Assert.AreEqual(NamespaceProvider.Cac + "AdditionalInformation", result.Name.ToString());
        }
    }
}
