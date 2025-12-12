using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass;
using static XmlBuildDLL.BaseClass.ComonXmlComponent.Catalogos;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    public static class PartyBuilder
    {
        public static XElement BuildSupplierParty(OrquestatorXmlClass doc)
        {
            var fe = NamespaceProvider.Fe;
            var cac = NamespaceProvider.Cac;
            var cbc = NamespaceProvider.Cbc;

            XElement SupplierParty = new XElement(fe + "AccountingSupplierParty");

            // Format AdditionalAccountID with SUPP prefix and zero padding
            string supplierAccountId = doc.AccountingSupplierParty?.AdditionalAccountID > 0
                ? $"SUPP{doc.AccountingSupplierParty.AdditionalAccountID:000}"
                : string.Empty;
            XElement SAdditionalAccountID = new XElement(cbc + "AdditionalAccountID", supplierAccountId);
            SupplierParty.Add(SAdditionalAccountID);

            XElement SParty = new XElement(fe + "Party");

            if (!string.IsNullOrEmpty(doc.AccountingSupplierParty.PartyIdentificationID))
            {
                XElement SPartyIdentification = new XElement(cac + "PartyIdentification",
                        new XElement(cbc + "ID", doc.AccountingSupplierParty.PartyIdentificationID,
                            new XAttribute("schemeAgencyID", Catalog.DIAN_ID),
                            new XAttribute("schemeAgencyName", Catalog.DIAN_AgencyName),
                            new XAttribute("schemeID", doc.AccountingSupplierParty.PartyIdentificationID_schemeID)
                    )
                );
                SParty.Add(SPartyIdentification);
            }

            if (!string.IsNullOrEmpty(doc.AccountingSupplierParty.PartyName))
            {
                XElement SPartyName = new XElement(cac + "PartyName",
                    new XElement(cbc + "Name", doc.AccountingSupplierParty.PartyName)
                );
                SParty.Add(SPartyName);
            }

            if (doc.AccountingSupplierParty.Address != null)
            {
                var SPhysicalLocation = BuildAddress(doc.AccountingSupplierParty.Address);
                if (SPhysicalLocation != null)
                    SParty.Add(SPhysicalLocation);
            }

            if (!string.IsNullOrEmpty(doc.AccountingSupplierParty.TaxLevelCode))
            {
                XElement SPartyTaxScheme = new XElement(fe + "PartyTaxScheme",
                    new XElement(cbc + "TaxLevelCode", doc.AccountingSupplierParty.TaxLevelCode),
                    new XElement(cac + "TaxScheme")
                    );
                SParty.Add(SPartyTaxScheme);
            }

            if (!string.IsNullOrEmpty(doc.AccountingSupplierParty.RegistrationName))
            {
                XElement SRegistrationName = new XElement(fe + "PartyLegalEntity",
                    new XElement(cbc + "RegistrationName", doc.AccountingSupplierParty.RegistrationName)
                );
                SParty.Add(SRegistrationName);
            }

            if (!string.IsNullOrEmpty(doc.AccountingSupplierParty.Telephone))
            {
                XElement STelephone = new XElement(cac + "Contact",
                    new XElement(cbc + "Telephone", doc.AccountingSupplierParty.Telephone)
                );
                SParty.Add(STelephone);
            }

            if (!string.IsNullOrEmpty(doc.AccountingSupplierParty.FirstName) || !string.IsNullOrEmpty(doc.AccountingSupplierParty.FamilyName) || !string.IsNullOrEmpty(doc.AccountingSupplierParty.MiddleName))
            {
                XElement SPerson = new XElement(fe + "Person");

                if (!string.IsNullOrEmpty(doc.AccountingSupplierParty.FirstName))
                    SPerson.Add(new XElement(cbc + "FirstName", doc.AccountingSupplierParty.FirstName));

                if (!string.IsNullOrEmpty(doc.AccountingSupplierParty.FamilyName))
                    SPerson.Add(new XElement(cbc + "FamilyName", doc.AccountingSupplierParty.FamilyName));

                if (!string.IsNullOrEmpty(doc.AccountingSupplierParty.MiddleName))
                    SPerson.Add(new XElement(cbc + "MiddleName", doc.AccountingSupplierParty.MiddleName));

                if (SPerson.HasElements)
                    SParty.Add(SPerson);
            }

            SupplierParty.Add(SParty);

            return SupplierParty;
        }

        public static XElement BuildCustomerParty(OrquestatorXmlClass doc)
        {
            var fe = NamespaceProvider.Fe;
            var cac = NamespaceProvider.Cac;
            var cbc = NamespaceProvider.Cbc;

            XElement CustomerParty = new XElement(fe + "AccountingCustomerParty");

            // Format AdditionalAccountID with CUST prefix and zero padding
            string customerAccountId = doc.AccountingCustomerParty?.AdditionalAccountID > 0
                ? $"CUST{doc.AccountingCustomerParty.AdditionalAccountID:000}"
                : string.Empty;
            XElement CAdditionalAccountID = new XElement(cbc + "AdditionalAccountID", customerAccountId);
            CustomerParty.Add(CAdditionalAccountID);

            XElement CParty = new XElement(fe + "Party");

            if (!string.IsNullOrEmpty(doc.AccountingCustomerParty.PartyIdentificationID))
            {
                XElement CPartyIdentification = new XElement(cac + "PartyIdentification",
                        new XElement(cbc + "ID", doc.AccountingCustomerParty.PartyIdentificationID,
                            new XAttribute("schemeAgencyID", Catalog.DIAN_ID),
                            new XAttribute("schemeAgencyName", Catalog.DIAN_AgencyName),
                            new XAttribute("schemeID", doc.AccountingCustomerParty.PartyIdentificationIDSchemeID)
                    )
                );
                CParty.Add(CPartyIdentification);
            }

            if (!string.IsNullOrEmpty(doc.AccountingCustomerParty.PartyName))
            {
                XElement SPartyName = new XElement(cac + "PartyName",
                    new XElement(cbc + "Name", doc.AccountingCustomerParty.PartyName)
                );
                CParty.Add(SPartyName);
            }

            if (doc.AccountingCustomerParty.Address != null)
            {
                var CPhysicalLocation = BuildAddress(doc.AccountingCustomerParty.Address);
                if (CPhysicalLocation != null)
                    CParty.Add(CPhysicalLocation);
            }

            if (!string.IsNullOrEmpty(doc.AccountingCustomerParty.TaxLevelCode))
            {
                XElement CPartyTaxScheme = new XElement(fe + "PartyTaxScheme",
                    new XElement(cbc + "TaxLevelCode", doc.AccountingCustomerParty.TaxLevelCode),
                    new XElement(cac + "TaxScheme")
                    );
                CParty.Add(CPartyTaxScheme);
            }

            if (!string.IsNullOrEmpty(doc.AccountingCustomerParty.RegistrationName))
            {
                XElement CRegistrationName = new XElement(fe + "PartyLegalEntity",
                    new XElement(cbc + "RegistrationName", doc.AccountingCustomerParty.RegistrationName)
                );
                CParty.Add(CRegistrationName);
            }

            if (!string.IsNullOrEmpty(doc.AccountingCustomerParty.Telephone))
            {
                XElement CTelephone = new XElement(cac + "Contact",
                    new XElement(cbc + "Telephone", doc.AccountingCustomerParty.Telephone)
                );
                CParty.Add(CTelephone);
            }

            if (doc.AccountingCustomerParty.PartyPerson != null)
            {
                XElement CPerson = new XElement(fe + "Person");

                if (doc.AccountingCustomerParty.PartyPerson.ID > 0)
                    CPerson.Add(new XElement(cbc + "ID", doc.AccountingCustomerParty.PartyPerson.ID,
                        new XAttribute("schemeName", doc.AccountingCustomerParty.PartyPerson.schemeName))
                        );

                if (!string.IsNullOrEmpty(doc.AccountingCustomerParty.PartyPerson.FirstName))
                    CPerson.Add(new XElement(cbc + "FirstName", doc.AccountingCustomerParty.PartyPerson.FirstName));

                if (!string.IsNullOrEmpty(doc.AccountingCustomerParty.PartyPerson.FamilyName))
                    CPerson.Add(new XElement(cbc + "FamilyName", doc.AccountingCustomerParty.PartyPerson.FamilyName));

                if (doc.AccountingCustomerParty.PartyPerson.IdentityDocumentReference != null)
                {
                    XElement CPartyIdentityDocumentReference = new XElement(fe + "IdentityDocumentReference");
                    foreach (var item in doc.AccountingCustomerParty.PartyPerson.IdentityDocumentReference)
                    {
                        var idElem = new XElement(cbc + "ID", item.ID,
                                     new XAttribute("schemeName", doc.AccountingCustomerParty.PartyPerson.schemeName));

                        if (!string.IsNullOrEmpty(item.Name))
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
                            idElem.Add(CPartyIssuerParty);
                        }

                        CPartyIdentityDocumentReference.Add(idElem);
                    }
                    CPerson.Add(CPartyIdentityDocumentReference);

                    if (doc.AccountingCustomerParty.PartyPerson.ResidenceAddress != null)
                    {
                        XElement CPartyResidenceAddress = new XElement(fe + "ResidenceAddress");

                        if (doc.AccountingCustomerParty.PartyPerson.ResidenceAddress.ID > 0)
                            CPartyResidenceAddress.Add(new XElement(fe + "PartyName", doc.AccountingCustomerParty.PartyPerson.ResidenceAddress.ID),
                                      new XAttribute("schemeName", doc.AccountingCustomerParty.PartyPerson.ResidenceAddress.schemeName)
                                      );

                        if (!string.IsNullOrEmpty(doc.AccountingCustomerParty.PartyPerson.ResidenceAddress.CityName))
                            CPartyResidenceAddress.Add(new XElement(cbc + "CityName", doc.AccountingCustomerParty.PartyPerson.ResidenceAddress.CityName));


                        if (!string.IsNullOrEmpty(doc.AccountingCustomerParty.PartyPerson.ResidenceAddress.Line))
                        {
                            XElement CPartyAddressLine = new XElement(fe + "AddressLine",
                               new XElement(cbc + "Line", doc.AccountingCustomerParty.PartyPerson.ResidenceAddress.Line)
                                  );
                            CPartyResidenceAddress.Add(CPartyAddressLine);
                        }

                        if (!string.IsNullOrEmpty(doc.AccountingCustomerParty.PartyPerson.ResidenceAddress.Country))
                            CPartyResidenceAddress.Add(new XElement(cbc + "Country", doc.AccountingCustomerParty.PartyPerson.ResidenceAddress.Country));

                        CPerson.Add(CPartyResidenceAddress);
                    }

                }

                if (CPerson.HasElements)
                    CParty.Add(CPerson);
            }

            CustomerParty.Add(CParty);

            return CustomerParty;
        }

        private static XElement BuildAddress(Address address)
        {
            if (address == null)
                return null;

            var fe = NamespaceProvider.Fe;
            var cac = NamespaceProvider.Cac;
            var cbc = NamespaceProvider.Cbc;

            XElement PhysicalLocation = new XElement(fe + "PhysicalLocation");
            XElement AddressEl = new XElement(fe + "Address");

            if (!string.IsNullOrEmpty(address.Department))
                AddressEl.Add(new XElement(cbc + "Department", address.Department));

            if (!string.IsNullOrEmpty(address.CitySubdivisionName))
                AddressEl.Add(new XElement(cbc + "CitySubdivisionName", address.CitySubdivisionName));

            if (!string.IsNullOrEmpty(address.CityName))
                AddressEl.Add(new XElement(cbc + "CityName", address.CityName));

            if (!string.IsNullOrEmpty(address.AddressLine))
                AddressEl.Add(new XElement(cac + "AddressLine",
                    new XElement(cbc + "Line", address.AddressLine)));

            if (!string.IsNullOrEmpty(address.Country))
                AddressEl.Add(new XElement(cac + "Country",
                    new XElement(cbc + "IdentificationCode", address.Country)));

            if (AddressEl.HasElements)
                PhysicalLocation.Add(AddressEl);

            if (PhysicalLocation.HasElements)
                return PhysicalLocation;

            return null;
        }
    }
}
