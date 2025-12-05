using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.DocumentClass.UBL2._1;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class AcountingSupplierPartyXmlFill
    {   
        internal static XElement FillAcountingSupplierParty(AcountingSupplierParty obj)
        {
            if (obj != null)
            {
                XElement SupplierParty = new XElement(NamespaceProvider.Cac  + "AccountingSupplierParty");
                if (!String.IsNullOrEmpty(obj.AdditionalAccountID.ToString()))
                {
                    XElement SAdditionalAccountID = new XElement(NamespaceProvider.Cbc + "AdditionalAccountID", obj.AdditionalAccountID);

                    if (obj.AdditionalAccountID_SchemeAgencyID != "")
                        SAdditionalAccountID.Add(new XAttribute("schemeAgencyID", obj.AdditionalAccountID_SchemeAgencyID));

                    if (obj.AdditionalAccountID_SchemeID != "")
                        SAdditionalAccountID.Add(new XAttribute("schemeID", obj.AdditionalAccountID_SchemeID));

                    if (obj.AdditionalAccountID_SchemeName != "")
                        SAdditionalAccountID.Add(new XAttribute("schemeName", obj.AdditionalAccountID_SchemeName));

                    SupplierParty.Add(SAdditionalAccountID);
                }

                XElement party = new XElement(NamespaceProvider.Cac + "Party");
                if (obj.IndustryClassificationCode != null)
                    party.Add(new XElement(NamespaceProvider.Cbc + "IndustryClassificationCode", obj.IndustryClassificationCode));

                if (!String.IsNullOrEmpty(obj.PartyName))
                {
                    party.Add(new XElement(NamespaceProvider.Cac + "PartyName", new XElement(NamespaceProvider.Cbc + "Name", obj.PartyName)));
                }

                if (obj.PhysicalLocation != null)
                {
                    XElement physicalLocation = new XElement(NamespaceProvider.Cac + "PhysicalLocation"); // TODO: LLamar a Adress
                    physicalLocation.Add(AddressXmlFill.FillAddress(obj.PhysicalLocation, "Address"));
                    if (physicalLocation.HasElements)
                    {
                        party.Add(physicalLocation);
                    }
                }

                if (obj.TaxScheme != null)
                {

                    party.Add(PartyTaxSchemeXmlFill.FillPartyTaxScheme("cac", obj.TaxScheme));


                }


                if (obj.LegalEntity != null)
                {

                    XElement legalEntity = LegalEntityXmlFill.FillLegalEntity("cac", obj.LegalEntity);
                    if (legalEntity.HasElements)
                    {
                        if (obj.shareHolder != null)
                        {
                            foreach (ShareHolderParty shareHolder in obj.shareHolder)
                            {
                                XElement holder = ShareHolderXmlFill.FillShareHolder(shareHolder);
                                if (holder.HasElements)
                                    legalEntity.Add(holder);
                            }
                        }
                        party.Add(legalEntity);
                    }

                }

                if (obj.ASContact != null)
                {
                    XElement Contact = ContactXmlFill.FillContact(obj.ASContact);
                    if (Contact.HasElements)
                        party.Add(Contact);
                }

                SupplierParty.Add(party);


                return SupplierParty;
            }
            else
            {
                return null;
            }

        }

    }
}
