using System;
using System.Linq;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.BaseClass.AccountingCustomerParty;
using AccountingCustomerParty = XmlBuildDLL.BaseClass.AccountingCustomerParty.AccountingCustomerParty;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class AccountingCustomerPartyXmlFillTests
    {
        //[TestMethod]
        //public void AccountingCustomerParty_ValidData_ReturnsExpectedXml()
        //{
        //    var docObj = new AccountingCustomerParty
        //    {
        //        AdditionalAccountID = 1,
        //        PartyIdentificationID = "AgencyID",
        //        PartyIdentificationIDSchemeAgencyID = "SchemeID",
        //        PartyIdentificationIDSchemeAgencyName = "SchemeName",
        //        RegistrationName = "PID001",
        //        PartyIdentificationIDSchemeID = "SchemeID",
        //        PartyName = "Cliente S.A."
        //    };
        //    var result = AccountingCustomerPartyXmlFill.FillAccountingCustomerParty(docObj);
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual("1", result.Element(NamespaceProvider.Cbc + "AdditionalAccountID")?.Value);
        //    Assert.AreEqual("Cliente S.A.", result.Descendants(NamespaceProvider.Cbc + "Name").FirstOrDefault()?.Value);
        //}
    }
}
