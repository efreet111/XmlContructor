using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using static XmlBuildDLL.BaseClass.ComonXmlComponent.Catalogos;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class AccountingCustomerPartyXmlFill
    {

        internal static XElement FillAccountingCustomerParty(AccountingCustomerParty objCustomerParty)
        {
            if (objCustomerParty != null)
            {
                XElement CustomerParty = new XElement(NamespaceProvider.Cac + "AccountingCustomerParty");

                if (!String.IsNullOrEmpty(objCustomerParty.AdditionalAccountID.ToString()))
                {
                    XElement SAdditionalAccountID = new XElement(NamespaceProvider.Cbc + "AdditionalAccountID", objCustomerParty.AdditionalAccountID);

                    if (objCustomerParty.AdditionalAccountID_SchemeAgencyID != "")
                        SAdditionalAccountID.Add(new XAttribute("schemeAgencyID", objCustomerParty.AdditionalAccountID_SchemeAgencyID));

                    if (objCustomerParty.AdditionalAccountID_SchemeID != "")
                        SAdditionalAccountID.Add(new XAttribute("schemeID", objCustomerParty.AdditionalAccountID_SchemeID));

                    if (objCustomerParty.AdditionalAccountID_SchemeName != "")
                        SAdditionalAccountID.Add(new XAttribute("schemeName", objCustomerParty.AdditionalAccountID_SchemeName));

                    CustomerParty.Add(SAdditionalAccountID);
                }

                XElement party = new XElement(NamespaceProvider.Cac + "Party");

                if (!String.IsNullOrEmpty(objCustomerParty.IndustryClassificationCode))
                    party.Add(new XElement(NamespaceProvider.Cbc + "IndustryClassificationCode", objCustomerParty.IndustryClassificationCode));



                if (!String.IsNullOrEmpty(objCustomerParty.PartyIdentificationID))
                {
                    XElement PartyIdentification = new XElement(NamespaceProvider.Cac + "PartyIdentification");

                    XElement PartyIdentificationID = new XElement(NamespaceProvider.Cbc + "ID", objCustomerParty.PartyIdentificationID);

                    if (!String.IsNullOrEmpty(objCustomerParty.PartyIdentificationID_SchemeName))
                    {
                        PartyIdentificationID.Add(new XAttribute("schemeName", objCustomerParty.PartyIdentificationID_SchemeName));
                    }

                    if (!String.IsNullOrEmpty(objCustomerParty.PartyIdentificationID_SchemeID))
                    {
                        PartyIdentificationID.Add(new XAttribute("schemeID", objCustomerParty.PartyIdentificationID_SchemeID));
                    }

                    PartyIdentification.Add(PartyIdentificationID);

                    party.Add(PartyIdentification);
                }

                if (!String.IsNullOrEmpty(objCustomerParty.PartyName))
                {

                    party.Add(new XElement(NamespaceProvider.Cac + "PartyName",
                        new XElement(NamespaceProvider.Cbc + "Name", objCustomerParty.PartyName)));
                }

                if (objCustomerParty.PhysicalLocation != null)
                {
                    XElement physicalLocation = new XElement(NamespaceProvider.Cac + "PhysicalLocation"); // TODO: LLamar a Adress
                    physicalLocation.Add(AddressXmlFill.FillAddress(objCustomerParty.PhysicalLocation, "Address"));
                    if (physicalLocation.HasElements)
                    {
                        party.Add(physicalLocation);
                    }
                }



                if (objCustomerParty.TaxScheme != null)
                {
                    //XElement partytax = FillPartyTaxScheme(de, this.obj.AcountingSupplierParty.TaxScheme);
                    XElement partytax = PartyTaxSchemeXmlFill.FillPartyTaxScheme( objCustomerParty.TaxScheme);
                    if (partytax.HasElements)
                        party.Add(partytax);
                }


                if (objCustomerParty.LegalEntity != null)
                {
                    //XElement legalEntity = FillLegalEntity(de, obj.AccountingCustomerParty.LegalEntity);
                    XElement legalEntity = LegalEntityXmlFill.FillLegalEntity(objCustomerParty.LegalEntity);
                    if (legalEntity.HasElements)
                        party.Add(legalEntity);
                }

                if (objCustomerParty.ACContact != null)
                {
                    XElement Contact = AccoutCustomerContactXmlFill.FillAccoutCustomerContact( objCustomerParty.ACContact);
                    if (Contact.HasElements)
                        party.Add(Contact);
                }


                CustomerParty.Add(party);

                return CustomerParty;
            }
            else
            {
                return null;
            }

        }

    }

}

