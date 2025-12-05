using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass;
using XmlBuildDLL.BaseClass.AccountingSupplierParty;
using XmlBuildDLL.BaseClass.AccountingCustomerParty;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class PartyBuilderTests
    {
        [TestMethod]
        public void BuildSupplierParty_ValidData_ReturnsExpectedXml()
        {
            var doc = new OrquestatorXmlClass
            {
                AccountingSupplierParty = new AccountingSupplierParty
                {
                    AdditionalAccountID = 1,
                    PartyIdentificationID = "SUPPID001",
                    PartyIdentificationID_schemeID = "SchemeID",
                    PartyName = "Proveedor S.A.",
                    TaxLevelCode = "TLC01",
                    RegistrationName = "Registro Proveedor",
                    Telephone = "987654321"
                }
            };
            var result = PartyBuilder.BuildSupplierParty(doc);
            Assert.IsNotNull(result);
            Assert.AreEqual("SUPP001", result.Element(NamespaceProvider.Cbc + "AdditionalAccountID")?.Value);
        }

        [TestMethod]
        public void BuildCustomerParty_ValidData_ReturnsExpectedXml()
        {
            var doc = new OrquestatorXmlClass
            {
                AccountingCustomerParty = new AccountingCustomerParty
                {
                    AdditionalAccountID = 1,
                    PartyIdentificationID = "CUSTPID001",
                    PartyIdentificationIDSchemeID = "SchemeID",
                    PartyName = "Cliente S.A.",
                    TaxLevelCode = "TLC02",
                    RegistrationName = "Registro Cliente",
                    Telephone = "123456789"
                }
            };
            var result = PartyBuilder.BuildCustomerParty(doc);
            Assert.IsNotNull(result);
            Assert.AreEqual("CUST001", result.Element(NamespaceProvider.Cbc + "AdditionalAccountID")?.Value);
        }
    }
}
