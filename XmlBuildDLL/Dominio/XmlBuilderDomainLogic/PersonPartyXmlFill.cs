using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class PersonPartyXmlFill
    {
        //private XElement FillParty(XNamespace ns, Party objparty, String NameNode)
        //{
        //    XElement NodeDespatchParty = new XElement(ns + NameNode);
        //    if (!String.IsNullOrEmpty(objparty.MarkCareIndicator.Trim()))
        //        NodeDespatchParty.Add(new XElement(cbc + "MarkCareIndicator", objparty.MarkCareIndicator));

        //    if (!String.IsNullOrEmpty(objparty.MarkAttentionIndicator.Trim()))
        //        NodeDespatchParty.Add(new XElement(cbc + "MarkAttentionIndicator", objparty.MarkAttentionIndicator));

        //    if (!String.IsNullOrEmpty(objparty.WebsiteURI.Trim()))
        //        NodeDespatchParty.Add(new XElement(cbc + "WebsiteURI", objparty.WebsiteURI));

        //    if (!String.IsNullOrEmpty(objparty.LogoReferenceID.Trim()))
        //        NodeDespatchParty.Add(new XElement(cbc + "LogoReferenceID", objparty.LogoReferenceID));

        //    if (!String.IsNullOrEmpty(objparty.EndpointID.Trim()))
        //        NodeDespatchParty.Add(new XElement(cbc + "EndpointID", objparty.EndpointID));

        //    if (!String.IsNullOrEmpty(objparty.IndustryClassificationCode.Trim()))
        //        NodeDespatchParty.Add(new XElement(cbc + "IndustryClassificationCode", objparty.IndustryClassificationCode));

        //    if (!String.IsNullOrEmpty(objparty.PartyIdentification.Trim()))
        //    {
        //        NodeDespatchParty.Add(new XElement(cbc + "PartyIdentification",
        //                           new XElement(cbc + "ID", objparty.PartyIdentification)));
        //    }

        //    if (!String.IsNullOrEmpty(objparty.PartyName.Trim()))
        //    {
        //        NodeDespatchParty.Add(new XElement(cbc + "PartyName",
        //                           new XElement(cbc + "Name", objparty.PartyName)));
        //    }
        //    if (objparty.Language != null)
        //    {
        //        XElement nodeLanguage = new XElement(cac + "Language");
        //        if (!String.IsNullOrEmpty(objparty.Language.ID.Trim()))
        //            nodeLanguage.Add(new XElement(cbc + "ID", objparty.Language.ID.Trim()));

        //        if (!String.IsNullOrEmpty(objparty.Language.Name.Trim()))
        //            nodeLanguage.Add(new XElement(cbc + "Name", objparty.Language.Name.Trim()));

        //        if (!String.IsNullOrEmpty(objparty.Language.LocaleCode.Trim()))
        //            nodeLanguage.Add(new XElement(cbc + "LocaleCode", objparty.Language.LocaleCode.Trim()));

        //        if (nodeLanguage.HasElements)
        //            NodeDespatchParty.Add(nodeLanguage);

        //    }
        //    if (objparty.PostalAddress != null)
        //    {
        //        // LLAma ADdress 
        //        XElement nodeAdd = FillAddress(objparty.PostalAddress, "PostalAddress");
        //        if (nodeAdd.HasElements)
        //            NodeDespatchParty.Add(nodeAdd);
        //    }
        //    if (objparty.PhysicalLocation != null)
        //    {
        //        XElement location = new XElement(cac + "PhysicalLocation");
        //        XElement address = FillAddress(objparty.PhysicalLocation, "Address");
        //        if (address.HasElements)
        //        {
        //            location.Add(address);
        //            NodeDespatchParty.Add(location);
        //        }

        //    }
        //    if (objparty.PartyTaxScheme != null)
        //    {
        //        XElement nodeTax = FillPartyTaxScheme(cac, objparty.PartyTaxScheme);
        //        if (nodeTax.HasElements)
        //            NodeDespatchParty.Add(nodeTax);
        //    }
        //    if (objparty.PartyLegalEntity != null)
        //    {
        //        XElement nodeLegal = FillLegalEntity(cac, objparty.PartyLegalEntity);
        //        if (nodeLegal.HasElements)
        //            NodeDespatchParty.Add(nodeLegal);
        //    }
        //    if (objparty.Contact != null)
        //    {
        //        // llamar Contac 
        //        XElement nodecontact = FillContact(objparty.Contact, "Contact");
        //        if (nodecontact.HasElements)
        //            NodeDespatchParty.Add(nodecontact);

        //    }
        //    if (objparty.Person != null)
        //    {
        //        foreach (Person per in objparty.Person)
        //        {
        //            XElement nodeperson = FillPerson(per);
        //            if (nodeperson.HasElements)
        //                NodeDespatchParty.Add(nodeperson);

        //        }
        //    }

        //    if (objparty.AgentParty_R != null)
        //    {
        //        XElement agentparty = FillParty(cac, objparty.AgentParty_R, "AgentParty");
        //        if (agentparty.HasElements)
        //            NodeDespatchParty.Add(agentparty);
        //    }

        //    if (objparty.ServiceProviderParty != null)
        //    {
        //        foreach (ServiceProviderParty provider in objparty.ServiceProviderParty)
        //        {
        //            XElement nodeProvider = new XElement(cac + "ServiceProviderParty");
        //            if (!String.IsNullOrEmpty(provider.ID.Trim()))
        //                nodeProvider.Add(new XElement(cbc + "ID", provider.ID.Trim()));

        //            if (!String.IsNullOrEmpty(provider.ServiceTypeCode.Trim()))
        //                nodeProvider.Add(new XElement(cbc + "ServiceTypeCode", provider.ServiceTypeCode.Trim()));

        //            if (provider.ServiceType != null)
        //            {
        //                foreach (string servicetype in provider.ServiceType)
        //                {
        //                    if (!String.IsNullOrEmpty(servicetype.Trim()))
        //                        nodeProvider.Add(new XElement(cbc + "ServiceType", servicetype));
        //                }
        //            }

        //            if (provider.Party != null)
        //            {
        //                XElement party = FillParty(cac, provider.Party, "Party");
        //                if (party.HasElements)
        //                    nodeProvider.Add(party);
        //            }
        //            if (provider.SellerContact != null)
        //            {
        //                XElement sellerContact = FillContact(provider.SellerContact, "SellerContact");
        //                if (sellerContact.HasElements)
        //                    nodeProvider.Add(sellerContact);
        //            }

        //        }
        //    }
        //    if (objparty.PowerOfAttorney != null)
        //    {
        //        // Lista
        //        foreach (PowerOfAttorney power in objparty.PowerOfAttorney)
        //        {
        //            XElement nodePower = new XElement(cac + "PowerOfAttorney");
        //            if (!String.IsNullOrEmpty(power.ID.Trim()))
        //                nodePower.Add(new XElement(cbc + "ID", power.ID.Trim()));

        //            if (power.IssueDate.HasValue)
        //                nodePower.Add(new XElement(cbc + "IssueDate", power.IssueDate.Value.ToString("yyyy-MM-dd")));

        //            if (power.IssueTime.HasValue)
        //                nodePower.Add(new XElement(cbc + "IssueTime", power.IssueTime.Value.ToString("hh:mm:ss")));

        //            foreach (string descripcion in power.Description)
        //            {
        //                if (!String.IsNullOrEmpty(descripcion.Trim()))
        //                    nodePower.Add(new XElement(cbc + "Description", descripcion));
        //            }

        //            //   TODO: Los Nodos cac:NotaryParty, cac:AgentParty, cac:WitnessParty todos internamente tienen el mismo llenado de Despacth Party
        //            if (power.NotaryParty != null)
        //            {
        //                XElement nodeNotaryParty = FillParty(cac, power.NotaryParty, "NotaryParty");
        //                if (nodeNotaryParty.HasElements)
        //                    nodePower.Add(nodeNotaryParty);
        //            }

        //            if (power.AgentParty != null)
        //            {
        //                XElement nodeAgentParty = FillParty(cac, power.AgentParty, "AgentParty");
        //                if (nodeAgentParty.HasElements)
        //                    nodePower.Add(nodeAgentParty);
        //            }

        //            if (power.WitnessParty != null)
        //            {
        //                XElement nodeWitnessParty = FillParty(cac, power.WitnessParty, "WitnessParty");
        //                if (nodeWitnessParty.HasElements)
        //                    nodePower.Add(nodeWitnessParty);
        //            }

        //            if (power.MandateDocumentReference != null)
        //            {
        //                foreach (DocumentReference mandante in power.MandateDocumentReference)
        //                {
        //                    XElement nodemandate = FillDocumentReference(mandante, "MandateDocumentReference");
        //                    if (nodemandate.HasElements)
        //                        nodePower.Add(nodemandate);
        //                }
        //            }

        //        }

        //    }
        //    if (objparty.FinancialAccount != null)
        //    {
        //        FillFinancialAccount(objparty.FinancialAccount);
        //    }

        //    return NodeDespatchParty;
        //}

    }
}
