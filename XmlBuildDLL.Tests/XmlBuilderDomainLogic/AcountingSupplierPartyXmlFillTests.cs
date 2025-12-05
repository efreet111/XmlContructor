using System;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.Modelresponse;
using System.Linq;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class AcountingSupplierPartyXmlFillTests
    {
        [TestMethod]
        public void FillAcountingSupplierParty_ValidData_ReturnsExpectedXml()
        {
            var obj = new AcountingSupplierParty
            {
                AdditionalAccountID = 1,
                AdditionalAccountID_SchemeAgencyID = "AgencyID",
                AdditionalAccountID_SchemeID = "SchemeID",
                AdditionalAccountID_SchemeName = "SchemeName",
                PartyName = "Proveedor S.A."
            };
            var result = AcountingSupplierPartyXmlFill.FillAcountingSupplierParty(obj);
            Assert.IsNotNull(result);
            Assert.AreEqual("1", result.Element(NamespaceProvider.Cbc + "AdditionalAccountID")?.Value);
            Assert.AreEqual("Proveedor S.A.", result.Descendants(NamespaceProvider.Cbc + "Name").FirstOrDefault()?.Value);
        }
    }
}
