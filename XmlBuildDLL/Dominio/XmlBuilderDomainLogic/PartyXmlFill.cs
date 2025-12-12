using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class PartyXmlFill
    {
        internal static XElement FillParty( Party objparty, String NameNode)
        {
            XElement NodeDespatchParty = new XElement(NamespaceProvider.Cac + NameNode);
            if (!String.IsNullOrEmpty(objparty.MarkCareIndicator.Trim()))
                NodeDespatchParty.Add(new XElement(NamespaceProvider.Cbc + "MarkCareIndicator", objparty.MarkCareIndicator));

            if (!String.IsNullOrEmpty(objparty.MarkAttentionIndicator.Trim()))
                NodeDespatchParty.Add(new XElement(NamespaceProvider.Cbc + "MarkAttentionIndicator", objparty.MarkAttentionIndicator));

            if (!String.IsNullOrEmpty(objparty.WebsiteURI.Trim()))
                NodeDespatchParty.Add(new XElement(NamespaceProvider.Cbc + "WebsiteURI", objparty.WebsiteURI));

            if (!String.IsNullOrEmpty(objparty.LogoReferenceID.Trim()))
                NodeDespatchParty.Add(new XElement(NamespaceProvider.Cbc + "LogoReferenceID", objparty.LogoReferenceID));

            if (!String.IsNullOrEmpty(objparty.EndpointID.Trim()))
                NodeDespatchParty.Add(new XElement(NamespaceProvider.Cbc + "EndpointID", objparty.EndpointID));

            if (!String.IsNullOrEmpty(objparty.IndustryClassificationCode.Trim()))
                NodeDespatchParty.Add(new XElement(NamespaceProvider.Cbc + "IndustryClassificationCode", objparty.IndustryClassificationCode));

            if (!String.IsNullOrEmpty(objparty.PartyIdentification.Trim()))
            {
                NodeDespatchParty.Add(new XElement(NamespaceProvider.Cbc + "PartyIdentification",
                                   new XElement(NamespaceProvider.Cbc + "ID", objparty.PartyIdentification)));
            }

            if (!String.IsNullOrEmpty(objparty.PartyName.Trim()))
            {
                NodeDespatchParty.Add(new XElement(NamespaceProvider.Cbc + "PartyName",
                                   new XElement(NamespaceProvider.Cbc + "Name", objparty.PartyName)));
            }
            if (objparty.Language != null)
            {
                XElement nodeLanguage = new XElement(NamespaceProvider.Cac + "Language");
                if (!String.IsNullOrEmpty(objparty.Language.ID.Trim()))
                    nodeLanguage.Add(new XElement(NamespaceProvider.Cbc + "ID", objparty.Language.ID.Trim()));

                if (!String.IsNullOrEmpty(objparty.Language.Name.Trim()))
                    nodeLanguage.Add(new XElement(NamespaceProvider.Cbc + "Name", objparty.Language.Name.Trim()));

                if (!String.IsNullOrEmpty(objparty.Language.LocaleCode.Trim()))
                    nodeLanguage.Add(new XElement(NamespaceProvider.Cbc + "LocaleCode", objparty.Language.LocaleCode.Trim()));

                if (nodeLanguage.HasElements)
                    NodeDespatchParty.Add(nodeLanguage);

            }
            if (objparty.PostalAddress != null)
            {
                // LLAma ADdress 
                XElement nodeAdd = AddressXmlFill.FillAddress(objparty.PostalAddress, "PostalAddress");
                if (nodeAdd.HasElements)
                    NodeDespatchParty.Add(nodeAdd);
            }
            if (objparty.PhysicalLocation != null)
            {
                XElement location = new XElement(NamespaceProvider.Cac + "PhysicalLocation");
                XElement address = AddressXmlFill.FillAddress(objparty.PhysicalLocation, "Address");
                if (address.HasElements)
                {
                    location.Add(address);
                    NodeDespatchParty.Add(location);
                }

            }
            if (objparty.PartyTaxScheme != null)
            {
                XElement nodeTax = PartyTaxSchemeXmlFill.FillPartyTaxScheme(objparty.PartyTaxScheme);
                if (nodeTax.HasElements)
                    NodeDespatchParty.Add(nodeTax);
            }
            if (objparty.PartyLegalEntity != null)
            {
                XElement nodeLegal = LegalEntityXmlFill.FillLegalEntity(objparty.PartyLegalEntity);
                if (nodeLegal.HasElements)
                    NodeDespatchParty.Add(nodeLegal);
            }
            if (objparty.Contact != null)
            {
                // llamar Contac 
                XElement nodecontact = PartyContactXmlFill.FillPartyContact(objparty.Contact, "Contact");
                if (nodecontact.HasElements)
                    NodeDespatchParty.Add(nodecontact);

            }
            if (objparty.Person != null)
            {
                foreach (Person per in objparty.Person)
                {
                    XElement nodeperson =  PersonXmlFill.FillPerson(per);
                    if (nodeperson.HasElements)
                        NodeDespatchParty.Add(nodeperson);

                }
            }

            if (objparty.AgentParty_R != null)
            {
                XElement agentparty = PartyXmlFill.FillParty(objparty.AgentParty_R, "AgentParty");
                if (agentparty.HasElements)
                    NodeDespatchParty.Add(agentparty);
            }

            if (objparty.ServiceProviderParty != null)
            {
                foreach (ServiceProviderParty provider in objparty.ServiceProviderParty)
                {
                    XElement nodeProvider = new XElement(NamespaceProvider.Cac + "ServiceProviderParty");
                    if (!String.IsNullOrEmpty(provider.ID.Trim()))
                        nodeProvider.Add(new XElement(NamespaceProvider.Cbc + "ID", provider.ID.Trim()));

                    if (!String.IsNullOrEmpty(provider.ServiceTypeCode.Trim()))
                        nodeProvider.Add(new XElement(NamespaceProvider.Cbc + "ServiceTypeCode", provider.ServiceTypeCode.Trim()));

                    if (provider.ServiceType != null)
                    {
                        foreach (string servicetype in provider.ServiceType)
                        {
                            if (!String.IsNullOrEmpty(servicetype.Trim()))
                                nodeProvider.Add(new XElement(NamespaceProvider.Cbc + "ServiceType", servicetype));
                        }
                    }

                    if (provider.Party != null)
                    {
                        XElement party = PartyXmlFill.FillParty( provider.Party, "Party");
                        if (party.HasElements)
                            nodeProvider.Add(party);
                    }
                    if (provider.SellerContact != null)
                    {
                        XElement sellerContact = PartyContactXmlFill.FillPartyContact(provider.SellerContact, "SellerContact");
                        if (sellerContact.HasElements)
                            nodeProvider.Add(sellerContact);
                    }

                }
            }
            if (objparty.PowerOfAttorney != null)
            {
                // Lista
                foreach (PowerOfAttorney power in objparty.PowerOfAttorney)
                {
                    XElement nodePower = new XElement(NamespaceProvider.Cac + "PowerOfAttorney");
                    if (!String.IsNullOrEmpty(power.ID.Trim()))
                        nodePower.Add(new XElement(NamespaceProvider.Cbc + "ID", power.ID.Trim()));

                    if (power.IssueDate.HasValue)
                        nodePower.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", power.IssueDate.Value.ToString("yyyy-MM-dd")));

                    if (power.IssueTime.HasValue)
                        nodePower.Add(new XElement(NamespaceProvider.Cbc + "IssueTime", power.IssueTime.Value.ToString("hh:mm:ss")));

                    foreach (string descripcion in power.Description)
                    {
                        if (!String.IsNullOrEmpty(descripcion.Trim()))
                            nodePower.Add(new XElement(NamespaceProvider.Cbc + "Description", descripcion));
                    }

                    //   TODO: Los Nodos cac:NotaryParty, cac:AgentParty, cac:WitnessParty todos internamente tienen el mismo llenado de Despacth Party
                    if (power.NotaryParty != null)
                    {
                        XElement nodeNotaryParty = FillParty( power.NotaryParty, "NotaryParty");
                        if (nodeNotaryParty.HasElements)
                            nodePower.Add(nodeNotaryParty);
                    }

                    if (power.AgentParty != null)
                    {
                        XElement nodeAgentParty = FillParty( power.AgentParty, "AgentParty");
                        if (nodeAgentParty.HasElements)
                            nodePower.Add(nodeAgentParty);
                    }

                    if (power.WitnessParty != null)
                    {
                        XElement nodeWitnessParty = FillParty( power.WitnessParty, "WitnessParty");
                        if (nodeWitnessParty.HasElements)
                            nodePower.Add(nodeWitnessParty);
                    }

                    if (power.MandateDocumentReference != null)
                    {
                        foreach (DocumentReference mandante in power.MandateDocumentReference)
                        {
                            XElement nodemandate = MandateDocumentReferenceFillXml.FillMandateDocumentReference(mandante, "MandateDocumentReference");
                            if (nodemandate.HasElements)
                                nodePower.Add(nodemandate);
                        }
                    }

                }

            }
            //if (objparty.FinancialAccount != null)
            //{
            //    FillFinancialAccount(objparty.FinancialAccount);
            //}

            return NodeDespatchParty;
        }

    }
}
