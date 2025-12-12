using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.Modelresponse; // <-- Asegúrate de que esta es la ruta correcta

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class AddressXmlFillTests
    {
        [TestMethod]
        public void FillAddress_ValidData_ReturnsExpectedXml()
        {
            var adrs = new Address
            {
                Department = "Antioquia",
                CitySubdivisionName = "Subdiv1",
                CityName = "Medellin",
                AddressLine = "Calle 123",
                CountryIdentificationCode = "CO"
            };
            var result = AddressXmlFill.FillAddress(adrs, "Address");
            Assert.IsNotNull(result);
            var addressEl = result; // result ya es cac:Address
            Assert.IsNotNull(addressEl);
            Assert.AreEqual("Antioquia", addressEl.Element(NamespaceProvider.Cbc + "Department")?.Value);
            Assert.AreEqual("Subdiv1", addressEl.Element(NamespaceProvider.Cbc + "CitySubdivisionName")?.Value);
            Assert.AreEqual("Medellin", addressEl.Element(NamespaceProvider.Cbc + "CityName")?.Value);
            Assert.AreEqual("CO", addressEl.Element(NamespaceProvider.Cac + "Country")?.Element(NamespaceProvider.Cbc + "IdentificationCode")?.Value);
        }
    }
}
