using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class ShareholderPartyParty
    {
        internal static XElement FillShareholderPartyParty(PartyLegalEntity LegalEntity)
        {
            XElement nodeLegalEntity1 = new XElement(NamespaceProvider.Cac + "PartyTaxScheme");
            XElement node1 = null;

            if (!String.IsNullOrEmpty(LegalEntity.SupplierPartyRegistrationName))
                nodeLegalEntity1.Add(new XElement(NamespaceProvider.Cbc + "RegistrationName", LegalEntity.SupplierPartyRegistrationName));


            //if (!(LegalEntity.SupplierPartyCompanyID == null && LegalEntity.SupplierPartyCompanyID > 0))
            //    node1 = FillShareholderPartyCompany(LegalEntity);
            //nodeLegalEntity1.Add(node1);


            if (!String.IsNullOrEmpty(LegalEntity.CompanyID.Trim()))
            {
                XElement nodeCompany = new XElement(NamespaceProvider.Cbc + "CompanyID", LegalEntity.SupplierPartyCompanyID,
                    new XAttribute("schemeID", LegalEntity.SupplierPartyCompanyschemeID),
                    new XAttribute("schemeName", LegalEntity.SupplierPartyCompanyschemeName),
                    new XAttribute("schemeAgencyName", LegalEntity.SupplierPartyCompanyschemeName),
                    new XAttribute("schemeAgencyID", LegalEntity.SupplierPartyCompanyschemeAgencyID));
                nodeLegalEntity1.Add(nodeCompany);
            }

            if (!String.IsNullOrEmpty(LegalEntity.SupplierPartyTaxLevelCode.Trim()))
            {
                XElement nodeLevelCode = new XElement(NamespaceProvider.Cbc + "TaxLevelCode", LegalEntity.SupplierPartyTaxLevelCode, new XAttribute("listName", LegalEntity.SupplierPartyTaxLevelCode));
                nodeLegalEntity1.Add(nodeLevelCode);
            }

            XElement nodeScheme = new XElement(NamespaceProvider.Cac + "TaxScheme");
            if (!String.IsNullOrEmpty(LegalEntity.SupplierPartyTaxSchemeID))
            {
                nodeScheme.Add(new XElement(NamespaceProvider.Cbc + "ID", LegalEntity.SupplierPartyTaxSchemeID));
            }
            if (!String.IsNullOrEmpty(LegalEntity.SupplierPartyTaxSchemeName))
            {
                nodeScheme.Add(new XElement(NamespaceProvider.Cbc + "Name", LegalEntity.SupplierPartyTaxSchemeName));
            }
            if (nodeScheme.HasElements)
            {
                nodeLegalEntity1.Add(nodeScheme);
            }

            return nodeLegalEntity1;
        }

    }
}
