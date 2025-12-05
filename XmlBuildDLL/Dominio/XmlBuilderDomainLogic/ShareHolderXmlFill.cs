using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class ShareHolderXmlFill
    {
        internal static XElement FillShareHolder(ShareHolderParty objholderParties)
        {
            XElement xElementshareHolder = new XElement(NamespaceProvider.Cac + "ShareholderParty");

            if (!String.IsNullOrWhiteSpace(objholderParties.PartecipationPercent))
            {
                xElementshareHolder.Add(new XElement(NamespaceProvider.Cbc + "PartecipationPercent", objholderParties.PartecipationPercent));
            }

            XElement xElementParty = new XElement(NamespaceProvider.Cac + "Party");
            XElement xElementTaxScheme = new XElement(NamespaceProvider.Cac + "PartyTaxScheme");

            if (!String.IsNullOrWhiteSpace(objholderParties.RegistrationName))
            {
                xElementTaxScheme.Add(new XElement(NamespaceProvider.Cbc + "RegistrationName", objholderParties.RegistrationName));
            }

            if (!String.IsNullOrEmpty(objholderParties.CompanyID))
            {
                XElement AccountID = new XElement(NamespaceProvider.Cbc + "CompanyID", objholderParties.CompanyID);

                if (objholderParties.schemeAgencyID != "")
                {
                    AccountID.Add(new XAttribute("schemeAgencyID", objholderParties.schemeAgencyID));
                }

                if (objholderParties.schemeID != "")
                {
                    AccountID.Add(new XAttribute("schemeID", objholderParties.schemeID));
                }

                if (objholderParties.schemeName != "")
                {
                    AccountID.Add(new XAttribute("schemeName", objholderParties.schemeName));
                }

                xElementTaxScheme.Add(AccountID);
            }

            if (!String.IsNullOrWhiteSpace(objholderParties.TaxLevelCode))
            {
                XElement taxlevelcode = new XElement(NamespaceProvider.Cbc + "TaxLevelCode", objholderParties.TaxLevelCode);
                taxlevelcode.Add(new XAttribute("listName", objholderParties.TaxLevelCodeListName));
                xElementTaxScheme.Add(taxlevelcode);
            }

            if (!String.IsNullOrWhiteSpace(objholderParties.ID_TaxScheme) && !String.IsNullOrWhiteSpace(objholderParties.Name_TaxScheme))
            {
                XElement TaxScheme = new XElement(NamespaceProvider.Cac + "TaxScheme");
                TaxScheme.Add(new XElement(NamespaceProvider.Cbc + "ID", objholderParties.ID_TaxScheme));
                TaxScheme.Add(new XElement(NamespaceProvider.Cbc + "Name", objholderParties.Name_TaxScheme));
                xElementTaxScheme.Add(TaxScheme);
            }

            xElementParty.Add(xElementTaxScheme);
            xElementshareHolder.Add(xElementParty);

            return xElementshareHolder;
        }

    }
}
