using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class PersonXmlFill
    {
        internal static XElement FillPerson(Person per)
        {
            XElement nodeperson = new XElement(NamespaceProvider.Cac + "Person");

            if (!String.IsNullOrEmpty(per.ID.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "ID", per.ID.Trim()));

            if (!String.IsNullOrEmpty(per.FirstName.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "FirstName", per.FirstName.Trim()));

            if (!String.IsNullOrEmpty(per.FamilyName.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "FamilyName", per.FamilyName.Trim()));

            if (!String.IsNullOrEmpty(per.Title.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "Title", per.Title.Trim()));

            if (!String.IsNullOrEmpty(per.MiddleName.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "MiddleName", per.MiddleName.Trim()));

            if (!String.IsNullOrEmpty(per.OtherName.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "OtherName", per.OtherName.Trim()));

            if (!String.IsNullOrEmpty(per.NameSuffix.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "NameSuffix", per.NameSuffix.Trim()));

            if (!String.IsNullOrEmpty(per.JobTitle.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "JobTitle", per.JobTitle.Trim()));

            if (!String.IsNullOrEmpty(per.NationalityID.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "NationalityID", per.NationalityID.Trim()));

            if (!String.IsNullOrEmpty(per.GenderCode.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "GenderCode", per.GenderCode.Trim()));

            if (!String.IsNullOrEmpty(per.BirthDate.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "BirthDate", per.BirthDate.Trim()));

            if (!String.IsNullOrEmpty(per.BirthplaceName.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "BirthplaceName", per.BirthplaceName.Trim()));

            if (!String.IsNullOrEmpty(per.OrganizationDepartment.Trim()))
                nodeperson.Add(new XElement(NamespaceProvider.Cbc + "OrganizationDepartment", per.OrganizationDepartment.Trim()));

            if (per.Contact != null)
            {
                XElement nodecontact = PartyContactXmlFill.FillPartyContact(per.Contact, "Contact");
                if (nodecontact.HasElements)
                    nodeperson.Add(nodecontact);
            }
            if (per.IdentityDocumentReference != null)
            {
                XElement nodeIdDocRef = MandateDocumentReferenceFillXml.FillMandateDocumentReference(per.IdentityDocumentReference, "IdentityDocumentReference");
                if (nodeIdDocRef.HasElements)
                    nodeperson.Add(nodeIdDocRef);
            }

            if (per.ResidenceAddress != null)
            {
                XElement Nodeaddress =AddressXmlFill.FillAddress(per.ResidenceAddress, "ResidenceAddress");
                if (Nodeaddress.HasElements)
                    nodeperson.Add(Nodeaddress);
            }

            if (nodeperson.HasAttributes)
                return nodeperson;
            else
                return null;
        }

    }
}
