using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class BuyerCustomerPartyXmlFill
    {
        internal static XElement FillBuyerCustomerParty(BuyersCustomerParty objBuyersCustomerParty)
        {
            XElement BuyersCustomerParty = new XElement(NamespaceProvider.Cac + "BuyerCustomerParty");
            if (objBuyersCustomerParty != null)
            {
                if (!String.IsNullOrWhiteSpace(objBuyersCustomerParty.AdditionalAccountID))
                {
                    XElement InvoiceAuthorization = new XElement(NamespaceProvider.Cbc + "AdditionalAccountID", objBuyersCustomerParty.AdditionalAccountID);
                    BuyersCustomerParty.Add(InvoiceAuthorization);
                }
            }
            return BuyersCustomerParty;
        }

    }
}
