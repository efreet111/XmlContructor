using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class PartyContactXmlFill
    {
        internal static XElement FillPartyContact(Contact contact, string pnameNodo)
        {
            XElement nodecontact = new XElement(NamespaceProvider.Cac + pnameNodo);
            if (!String.IsNullOrEmpty(contact.ID.Trim()))
                nodecontact.Add(new XElement(NamespaceProvider.Cbc + "ID", contact.ID.Trim()));

            if (!String.IsNullOrEmpty(contact.Name.Trim()))
                nodecontact.Add(new XElement(NamespaceProvider.Cbc + "Name", contact.Name.Trim()));

            if (!String.IsNullOrEmpty(contact.Telephone.Trim()))
                nodecontact.Add(new XElement(NamespaceProvider.Cbc + "Telephone", contact.Telephone.Trim()));

            if (!String.IsNullOrEmpty(contact.Telefax.Trim()))
                nodecontact.Add(new XElement(NamespaceProvider.Cbc + "Telefax", contact.Telefax.Trim()));

            if (!String.IsNullOrEmpty(contact.ElectronicMail.Trim()))
                nodecontact.Add(new XElement(NamespaceProvider.Cbc + "ElectronicMail", contact.ElectronicMail.Trim()));

            if (contact.Note != null)
            {
                if (contact.Note.Count > 0)
                {
                    foreach (string note in contact.Note)
                    {
                        if (!String.IsNullOrEmpty(note.Trim()))
                        {
                            nodecontact.Add(new XElement(NamespaceProvider.Cbc + "Note", note.Trim()));
                        }
                    }
                }
            }

            if (contact.OtherCommunication != null && contact.OtherCommunication.Count > 1)
            {

                foreach (OtherCommunication com in contact.OtherCommunication)
                {
                    XElement nodeOtherCom = new XElement(NamespaceProvider.Cac + "OtherCommunication");
                    if (!String.IsNullOrEmpty(com.ChannelCode.Trim()))
                        nodeOtherCom.Add(new XElement(NamespaceProvider.Cbc + "ChannelCode", com.ChannelCode.Trim()));
                    if (!String.IsNullOrEmpty(com.Channel.Trim()))
                        nodeOtherCom.Add(new XElement(NamespaceProvider.Cbc + "Channel", com.Channel.Trim()));
                    if (!String.IsNullOrEmpty(com.Value.Trim()))
                        nodeOtherCom.Add(new XElement(NamespaceProvider.Cbc + "Value", com.Value.Trim()));

                    if (nodeOtherCom.HasElements)
                        nodecontact.Add(nodeOtherCom);
                }

            }

            return nodecontact;
        }

    }
}
