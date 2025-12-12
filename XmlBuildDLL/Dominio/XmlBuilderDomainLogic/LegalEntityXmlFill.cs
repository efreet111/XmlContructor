using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class LegalEntityXmlFill
    {
        internal static XElement FillLegalEntity( PartyLegalEntity obj)
        {
            XElement NodoLegalEntity = new XElement(NamespaceProvider.Cac + "PartyLegalEntity");

            if (!String.IsNullOrEmpty(obj.RegistrationName))
            {
                NodoLegalEntity.Add(new XElement(NamespaceProvider.Cbc + "RegistrationName", obj.RegistrationName));
            }

            if (!String.IsNullOrEmpty(obj.CompanyID) && !String.IsNullOrEmpty(obj.CompanySchemeName) && !String.IsNullOrEmpty(obj.CompanySchemeAgencyName) && !String.IsNullOrEmpty(obj.CompanySchemeAgencyID))
            {
                NodoLegalEntity.Add(new XElement(NamespaceProvider.Cbc + "CompanyID", obj.CompanyID, new XAttribute("schemeID", obj.CompanySchemeID), new XAttribute("schemeName", obj.CompanySchemeName), new XAttribute("schemeAgencyName", obj.CompanySchemeAgencyName), new XAttribute("schemeAgencyID", obj.CompanySchemeAgencyID)));
            }

            XElement CorporateRegistrationScheme = new XElement(NamespaceProvider.Cac + "CorporateRegistrationScheme");

            if (!String.IsNullOrEmpty(obj.CorporateRegistrationID))
            {
                CorporateRegistrationScheme.Add(new XElement(NamespaceProvider.Cbc + "ID", obj.CorporateRegistrationID));
            }
            if (!String.IsNullOrEmpty(obj.CorporateRegistrationName))
            {
                CorporateRegistrationScheme.Add(new XElement(NamespaceProvider.Cbc + "Name", obj.CorporateRegistrationName));
            }

            if (!String.IsNullOrEmpty(obj.CorporateRegistrationTypeCode))
            {
                CorporateRegistrationScheme.Add(new XElement(NamespaceProvider.Cbc + "CorporateRegistrationTypeCode", obj.CorporateRegistrationTypeCode));
            }

            if (CorporateRegistrationScheme.HasElements)
            {
                NodoLegalEntity.Add(CorporateRegistrationScheme);
            }

            XElement nodoShareholderParty = ShareholderPartyXmlFill.FillShareholderParty(obj);

            if (nodoShareholderParty.HasElements)
            {
                NodoLegalEntity.Add(nodoShareholderParty);
            }

            return NodoLegalEntity;
        }

    }
}
