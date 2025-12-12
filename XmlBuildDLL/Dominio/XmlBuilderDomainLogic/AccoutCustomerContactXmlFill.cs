using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class AccoutCustomerContactXmlFill
    {
        internal static XElement FillAccoutCustomerContact(AccountingCustomerPartyContact objContact)
        {
            XElement xElementContact = new XElement(NamespaceProvider.Cac + "Contact");

            AccountingCustomerPartyContact row = objContact;

            if (!String.IsNullOrWhiteSpace(row.ContactName))
            {
                xElementContact.Add(new XElement(NamespaceProvider.Cbc + "Name", row.ContactName));
            }

            if (!String.IsNullOrWhiteSpace(row.ContactTelephone))
            {
                xElementContact.Add(new XElement(NamespaceProvider.Cbc + "Telephone", row.ContactTelephone));
            }

            if (!String.IsNullOrWhiteSpace(row.ContactTelefax))
            {
                xElementContact.Add(new XElement(NamespaceProvider.Cbc + "Telefax", row.ContactTelefax));
            }

            if (!String.IsNullOrEmpty(row.ContactElectronicMail))
            {
                xElementContact.Add(new XElement(NamespaceProvider.Cbc + "ElectronicMail", row.ContactElectronicMail));
            }

            if (!String.IsNullOrWhiteSpace(row.ContactNote))
            {
                xElementContact.Add(new XElement(NamespaceProvider.Cbc + "Note", row.ContactNote));
            }

            return xElementContact;
        }
    }
}
