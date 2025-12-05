using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class PartyTaxSchemeXmlFill
    {
        internal static XElement FillPartyTaxScheme(XNamespace ns, PartyTaxScheme obj)
        {
            XElement NodoTaxScheme = new XElement(ns + "PartyTaxScheme");
            if (!String.IsNullOrEmpty(obj.RegistrationName.Trim()))
            {
                NodoTaxScheme.Add(new XElement("cbc" + "RegistrationName", obj.RegistrationName));
            }
            if (!String.IsNullOrEmpty(obj.CompanyID.Trim()))
            {
                XElement nodeCompany = new XElement("cbc" + "CompanyID", obj.CompanyID,
                    new XAttribute("schemeID", obj.SchemeID),
                    new XAttribute("schemeName", obj.SchemeName),
                    new XAttribute("schemeAgencyName", obj.SchemeAgencyName),
                    new XAttribute("schemeAgencyID", obj.SchemeAgencyID));
                NodoTaxScheme.Add(nodeCompany);
            }

            if (!String.IsNullOrEmpty(obj.TaxLevelCode.Trim()))
            {
                XElement nodeLevelCode = new XElement("cbc" + "TaxLevelCode", obj.TaxLevelCode, new XAttribute("listName", obj.TaxLevelCodeListName));
                NodoTaxScheme.Add(nodeLevelCode);
            }

            if (obj.RegistrationAddress != null)
            {
                XElement address = AddressXmlFill.FillAddress(obj.RegistrationAddress, "RegistrationAddress");
                if (address.HasElements)
                    NodoTaxScheme.Add(address);
            }

            XElement nodeScheme = new XElement("cac" + "TaxScheme");
            if (!String.IsNullOrEmpty(obj.TaxSchemeID))
            {
                nodeScheme.Add(new XElement("cbc" + "ID", obj.TaxSchemeID));
            }
            if (!String.IsNullOrEmpty(obj.TaxSchemeName))
            {
                nodeScheme.Add(new XElement("cbc" + "Name", obj.TaxSchemeName));
            }
            if (nodeScheme.HasElements)
            {
                NodoTaxScheme.Add(nodeScheme);
            }

            return NodoTaxScheme;
        }

    }
}
