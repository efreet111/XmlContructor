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
        internal static XElement FillPartyTaxScheme( PartyTaxScheme obj)
        {
            XElement NodoTaxScheme = new XElement(NamespaceProvider.Cac + "PartyTaxScheme");
            // Use null-safe checks before Trim to avoid NullReferenceException
            if (!string.IsNullOrWhiteSpace(obj?.RegistrationName))
            {
                NodoTaxScheme.Add(new XElement("cbc" + "RegistrationName", obj.RegistrationName.Trim()));
            }
            if (!string.IsNullOrWhiteSpace(obj?.CompanyID))
            {
                XElement nodeCompany = new XElement("cbc" + "CompanyID", obj.CompanyID.Trim(),
                    new XAttribute("schemeID", obj.SchemeID ?? string.Empty),
                    new XAttribute("schemeName", obj.SchemeName ?? string.Empty),
                    new XAttribute("schemeAgencyName", obj.SchemeAgencyName ?? string.Empty),
                    new XAttribute("schemeAgencyID", obj.SchemeAgencyID ?? string.Empty));
                NodoTaxScheme.Add(nodeCompany);
            }

            if (!string.IsNullOrWhiteSpace(obj?.TaxLevelCode))
            {
                XElement nodeLevelCode = new XElement("cbc" + "TaxLevelCode", obj.TaxLevelCode.Trim(), new XAttribute("listName", obj.TaxLevelCodeListName ?? string.Empty));
                NodoTaxScheme.Add(nodeLevelCode);
            }

            if (obj?.RegistrationAddress != null)
            {
                XElement address = AddressXmlFill.FillAddress(obj.RegistrationAddress, "RegistrationAddress");
                if (address.HasElements)
                    NodoTaxScheme.Add(address);
            }

            XElement nodeScheme = new XElement("cac" + "TaxScheme");
            if (!string.IsNullOrWhiteSpace(obj?.TaxSchemeID))
            {
                nodeScheme.Add(new XElement("cbc" + "ID", obj.TaxSchemeID.Trim()));
            }
            if (!string.IsNullOrWhiteSpace(obj?.TaxSchemeName))
            {
                nodeScheme.Add(new XElement("cbc" + "Name", obj.TaxSchemeName.Trim()));
            }
            if (nodeScheme.HasElements)
            {
                NodoTaxScheme.Add(nodeScheme);
            }

            return NodoTaxScheme;
        }

    }
}
