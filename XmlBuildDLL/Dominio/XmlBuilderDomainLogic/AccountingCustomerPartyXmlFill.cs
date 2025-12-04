using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.AccountingCustomerParty;
using static XmlBuildDLL.BaseClass.ComonXmlComponent.Catalogos;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class AccountingCustomerPartyXmlFill
    {

        public static XElement AccountingCustomerParty(AccountingCustomerParty docObj)
        {
            var fe = NamespaceProvider.Fe;
            var cac = NamespaceProvider.Cac;
            var cbc = NamespaceProvider.Cbc;
            XElement CustomerParty = new XElement(fe + "AccountingCustomerParty");

            XElement CAdditionalAccountID = new XElement(cbc + "AdditionalAccountID", docObj.AdditionalAccountID);
            CustomerParty.Add(CAdditionalAccountID);

            XElement CParty = new XElement(fe + "Party");

            if (docObj.PartyIdentificationID != "" && docObj.PartyIdentificationID != null)
            {
                XElement CPartyIdentification = new XElement(cac + "PartyIdentification",
                        new XElement(cbc + "ID", docObj.PartyIdentificationID,
                            new XAttribute("schemeAgencyID", Catalog.DIAN_ID),
                            new XAttribute("schemeAgencyName", Catalog.DIAN_AgencyName),
                            new XAttribute("schemeID", docObj.PartyIdentificationIDSchemeID)
                    )
                );
                CParty.Add(CPartyIdentification);
            }

            if (docObj.PartyName != "")
            {
                XElement SPartyName = new XElement(cac + "PartyName",
                    new XElement(cbc + "Name", docObj.PartyName)
                );
                CParty.Add(SPartyName);
            }

            if (docObj.Address != null)
            {
                var CPhysicalLocation = AddressXmlFill.Address(docObj.Address);

                if (CPhysicalLocation != null)
                    CParty.Add(CPhysicalLocation);
            }

            if (docObj.TaxLevelCode != "")
            {
                XElement CPartyTaxScheme = new XElement(fe + "PartyTaxScheme",
                    new XElement(cbc + "TaxLevelCode", docObj.TaxLevelCode),
                    new XElement(cac + "TaxScheme")
                    );
                CParty.Add(CPartyTaxScheme);
            }

            if (docObj.RegistrationName != "")
            {
                XElement CRegistrationName = new XElement(fe + "PartyLegalEntity",
                    new XElement(cbc + "RegistrationName", docObj.RegistrationName)
                );
                CParty.Add(CRegistrationName);
            }

            if (docObj.Telephone != "")
            {
                XElement CTelephone = new XElement(cac + "Contact",
                    new XElement(cbc + "Telephone", docObj.Telephone)
                );
                CParty.Add(CTelephone);
            }

            if (docObj.PartyPerson != null)
            {
                XElement CPerson = new XElement(fe + "Person");


                if (docObj.PartyPerson.ID > 0)
                    CPerson.Add(new XElement(cbc + "ID", docObj.PartyPerson.ID,
                        new XAttribute("schemeName", docObj.PartyPerson.schemeName))
                        );

                if (docObj.PartyPerson.FirstName != "")
                    CPerson.Add(new XElement(cbc + "FirstName", docObj.PartyPerson.FirstName));

                if (docObj.PartyPerson.FamilyName != "")
                    CPerson.Add(new XElement(cbc + "FamilyName", docObj.PartyPerson.FamilyName));


                if (docObj.PartyPerson.IdentityDocumentReference != null)
                {
                    XElement CPartyIdentityDocumentReference = new XElement(fe + "IdentityDocumentReference");
                    foreach (var item in docObj.PartyPerson.IdentityDocumentReference)
                    {
                        CPartyIdentityDocumentReference = new XElement(cbc + "ID", item.ID,
                                     new XAttribute("schemeName", docObj.PartyPerson.schemeName));

                        if (string.IsNullOrEmpty(item.Name))
                        {
                            XElement CPartyIssuerParty = new XElement(fe + "IssuerParty");

                            XElement CPartyPersonPartyName = new XElement(fe + "PartyName",
                                     new XElement(cbc + "Name", item.Name)
                                    );

                            XElement CPartyPersonPostalAddress = new XElement(fe + "PostalAddress",
                                   new XElement(cbc + "Country", item.Country)
                                  );

                            CPartyIssuerParty.Add(CPartyPersonPartyName);
                            CPartyIssuerParty.Add(CPartyPersonPostalAddress);
                            CPartyIdentityDocumentReference.Add(CPartyIssuerParty);
                        }

                        CPartyIdentityDocumentReference.Add(CPartyIdentityDocumentReference);
                    }
                    CPerson.Add(CPartyIdentityDocumentReference);

                    if (docObj.PartyPerson.ResidenceAddress != null)
                    {
                        XElement CPartyResidenceAddress = new XElement(fe + "ResidenceAddress");

                        if (docObj.PartyPerson.ResidenceAddress.ID > 0)
                            CPartyResidenceAddress.Add(new XElement(fe + "PartyName", docObj.PartyPerson.ResidenceAddress.ID),
                                      new XAttribute("schemeName", docObj.PartyPerson.ResidenceAddress.schemeName)
                                      );

                        if (docObj.PartyPerson.ResidenceAddress.CityName != "")
                            CPartyResidenceAddress.Add(new XElement(cbc + "CityName", docObj.PartyPerson.FirstName));


                        if (docObj.PartyPerson.ResidenceAddress.Line != "")
                        {
                            XElement CPartyAddressLine = new XElement(fe + "AddressLine",
                               new XElement(cbc + "Line", docObj.PartyPerson.ResidenceAddress.Line)
                                  );
                            CPartyResidenceAddress.Add(CPartyAddressLine);
                        }

                        if (docObj.PartyPerson.ResidenceAddress.Country != "")
                            CPartyResidenceAddress.Add(new XElement(cbc + "Country", docObj.PartyPerson.FirstName));

                        CPerson.Add(CPartyResidenceAddress);
                    }

                    if (CPerson.HasElements)
                        CParty.Add();

                    if (docObj.PartyPerson.ID > 0)
                        CPerson.Add(new XElement(cbc + "ID", docObj.PartyPerson.ID,
                            new XAttribute("schemeName", docObj.PartyPerson.schemeName))
                            );

                }

                CustomerParty.Add(CParty);

            }
            return CustomerParty;
        }

    }
}
