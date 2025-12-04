using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.AccountingSupplierParty;
using XmlBuildDLL.BaseClass.ComonXmlComponent;


namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class LegalMonetaryTotalXmlFill
    {
        public XElement LegalMonetaryTotal(LegalMonetaryTotal docObj)
        {
            var fe = NamespaceProvider.Fe;
            var cbc = NamespaceProvider.Cbc;
            XElement Monetary = new XElement(fe + "LegalMonetaryTotal");

            if (docObj.LineExtensionAmountCurrencyID != null )
                Monetary.Add(new XElement(cbc + "LineExtensionAmount", docObj.LineExtensionAmount.ToString("0.0000"),
                    new XAttribute("currencyID", docObj.LineExtensionAmountCurrencyID)
                ));

            if (docObj.TaxExclusiveAmountCurrencyID != null)
                Monetary.Add(new XElement(cbc + "TaxExclusiveAmount", docObj.TaxExclusiveAmount.ToString("0.0000"),
                    new XAttribute("currencyID", docObj.TaxExclusiveAmountCurrencyID)
                ));

            if (docObj.PayableAmountCurrencyID != null)
                Monetary.Add(new XElement(cbc + "PayableAmount", docObj.PayableAmount.ToString("0.0000"),
                    new XAttribute("currencyID", docObj.PayableAmountCurrencyID)
                ));
            
            return Monetary;
        }
    }
}
