using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class TaxRepresentativePartyXmlFill
    {
        internal static XElement FillTaxRepresentativeParty(TaxRepresentativeParty taxrepParty)
        {
            if (taxrepParty != null)
            {
                XElement NodoTaxRepParty = new XElement(NamespaceProvider.Cac + "TaxRepresentativeParty");

                if (!String.IsNullOrEmpty(taxrepParty.PartyIdentification))
                    NodoTaxRepParty.Add(new XElement(NamespaceProvider.Cac + "PartyIdentification",
                        new XElement(NamespaceProvider.Cbc + "ID",
                            new XAttribute("schemeID", taxrepParty.PartyIdentification_SchemeID),
                            new XAttribute("schemeName", taxrepParty.PartyIdentification_SchemeName),

                         taxrepParty.PartyIdentification))
                        );

                if (!String.IsNullOrEmpty(taxrepParty.PartyName))
                {
                    XElement PartyName = new XElement(NamespaceProvider.Cac + "PartyName");
                    PartyName.Add(new XElement(NamespaceProvider.Cbc + "Name", taxrepParty.PartyName));
                    NodoTaxRepParty.Add(PartyName);
                }

                if (taxrepParty.PhysicalLocation != null)
                {
                    XElement location = new XElement(NamespaceProvider.Cac + "PhysicalLocation");
                    XElement address = AddressXmlFill.FillAddress(taxrepParty.PhysicalLocation, "Address");
                    if (address.HasElements)
                    {
                        location.Add(address);
                        NodoTaxRepParty.Add(location);
                    }
                }

                if (taxrepParty.TaxScheme != null)
                {
                    XElement nodeTaxScheme = PartyTaxSchemeXmlFill.FillPartyTaxScheme(taxrepParty.TaxScheme);
                    if (nodeTaxScheme.HasElements || nodeTaxScheme.HasAttributes)
                        NodoTaxRepParty.Add(nodeTaxScheme);
                }

                #region nuevo
                //XElement taxrepPartyElements = new XElement(cac + "Party");
                XElement taxrepPartyElements = null;

                if (!String.IsNullOrEmpty(taxrepParty.RegistrationName))
                    NodoTaxRepParty.Add(new XElement(NamespaceProvider.Cac + "PartyLegalEntity",
                        new XElement(NamespaceProvider.Cbc + "RegistrationName", taxrepParty.RegistrationName))
                        );

                if (taxrepParty.Contact != null)
                {

                    XElement contact = new XElement(NamespaceProvider.Cac + "Contact");
                    if (!String.IsNullOrEmpty(taxrepParty.Contact.Name))
                        contact.Add(new XElement(NamespaceProvider.Cbc + "Name", taxrepParty.Contact.Name));
                    if (!String.IsNullOrEmpty(taxrepParty.Contact.Telephone))
                        contact.Add(new XElement(NamespaceProvider.Cbc + "Telephone", taxrepParty.Contact.Telephone));
                    if (!String.IsNullOrEmpty(taxrepParty.Contact.Telefax))
                        contact.Add(new XElement(NamespaceProvider.Cbc + "Telefax", taxrepParty.Contact.Telefax));
                    if (!String.IsNullOrEmpty(taxrepParty.Contact.ElectronicMail))
                        contact.Add(new XElement(NamespaceProvider.Cbc + "ElectronicMail", taxrepParty.Contact.ElectronicMail));
                    if (!String.IsNullOrEmpty(taxrepParty.Contact.Note))
                        contact.Add(new XElement(NamespaceProvider.Cbc + "Note", taxrepParty.Contact.Note));
                    NodoTaxRepParty.Add(contact);
                }


                #endregion

                //NodoTaxRepParty.Add(party);

                if (NodoTaxRepParty.HasElements)
                    return NodoTaxRepParty;
                else
                    return null;
            }
            else
            {
                return null;
            }

        }

    }
}
