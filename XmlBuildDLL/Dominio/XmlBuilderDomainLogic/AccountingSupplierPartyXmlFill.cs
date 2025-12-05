using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass;
using XmlBuildDLL.BaseClass.AccountingSupplierParty;
using XmlBuildDLL.BaseClass.Dianheaders;
using static XmlBuildDLL.BaseClass.ComonXmlComponent.Catalogos;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class AccountingSupplierPartyXmlFill
    {
        internal static XElement AccountingSupplierParty(AccountingSupplierParty docObj)
        {
            var fe = NamespaceProvider.Fe;
            var cac = NamespaceProvider.Cac;
            var cbc = NamespaceProvider.Cbc;

            XElement SupplierParty = new XElement(fe + "AccountingSupplierParty");

            XElement SAdditionalAccountID = new XElement(cbc + "AdditionalAccountID", docObj.AdditionalAccountID);
            SupplierParty.Add(SAdditionalAccountID);

            XElement SParty = new XElement(fe + "Party");

            if (docObj.PartyIdentificationID != "" && docObj.PartyIdentificationID != null)
            {
                XElement SPartyIdentification = new XElement(cac + "PartyIdentification",
                        new XElement(cbc + "ID", docObj.PartyIdentificationID,
                            new XAttribute("schemeAgencyID", Catalog.DIAN_ID),
                            new XAttribute("schemeAgencyName", Catalog.DIAN_AgencyName),
                            new XAttribute("schemeID", docObj.PartyIdentificationID_schemeID)
                    )
                );
                SParty.Add(SPartyIdentification);
            }

            SupplierParty.Add(SParty);

            return SupplierParty;
        }
    }
}
