using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class ShareholderPartyXmlFill
    {
        internal static XElement FillShareholderParty(PartyLegalEntity LegalEntity)
        {
            XElement nodeLegalEntity = new XElement(NamespaceProvider.Cac + "ShareholderParty");
            XElement nodePartyScheme = null;
            if (LegalEntity.SupplierPartyPartecipationPercent != null)
                if (!String.IsNullOrEmpty(LegalEntity.SupplierPartyPartecipationPercent.Trim()))
                    nodeLegalEntity.Add(new XElement(NamespaceProvider.Cbc + "PartecipationPercent", LegalEntity.SupplierPartyPartecipationPercent));

            XElement nodeLegalEntityPartyParty = new XElement(NamespaceProvider.Cac + "Party");

            if (LegalEntity.SupplierPartyCompanyID != null && LegalEntity.SupplierPartyCompanyID != 0)
            {
                nodePartyScheme = ShareholderPartyParty.FillShareholderPartyParty(LegalEntity);

                nodeLegalEntityPartyParty.Add(nodePartyScheme);
            }

            if (nodeLegalEntityPartyParty.HasElements)
                nodeLegalEntity.Add(nodeLegalEntityPartyParty);

            return nodeLegalEntity;
        }

    }
}
