using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class ContactXmlFill
    {
        internal static XElement FillContact(XmlBuildDLL.BaseClass.Modelresponse.AcountingSupplierPartyContact objContact)
        {
            XElement xElementContact = new XElement(NamespaceProvider.Cac + "Contact");

            AcountingSupplierPartyContact row = objContact;

            if (!String.IsNullOrWhiteSpace(row.Name))
            {
                xElementContact.Add(new XElement(NamespaceProvider.Cbc + "Name", row.Name));
            }

            if (!String.IsNullOrWhiteSpace(row.Telephone))
            {
                xElementContact.Add(new XElement(NamespaceProvider.Cbc + "Telephone", row.Telephone));
            }

            if (!String.IsNullOrWhiteSpace(row.Telefax))
            {
                xElementContact.Add(new XElement(NamespaceProvider.Cbc + "Telefax", row.Telefax));
            }

            if (!String.IsNullOrEmpty(row.ElectronicMail))
            {
                xElementContact.Add(new XElement(NamespaceProvider.Cbc + "ElectronicMail", row.ElectronicMail));
            }

            if (!String.IsNullOrWhiteSpace(row.Note))
            {
                xElementContact.Add(new XElement(NamespaceProvider.Cbc + "Note", row.Note));
            }

            return xElementContact;
        }

    }
}
