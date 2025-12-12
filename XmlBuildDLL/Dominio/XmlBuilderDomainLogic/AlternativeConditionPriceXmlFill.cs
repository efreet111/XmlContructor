using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using System.Globalization;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class AlternativeConditionPriceXmlFill
    {
        internal static XElement FillAlternativeConditionPrice( AlternativeConditionPrice objAlternativeConditionPrice, ref int cantidadDecimales)
        {
            XElement xElementAlternativeConditionPrice = new XElement(NamespaceProvider.Cac + "AlternativeConditionPrice");

            AlternativeConditionPrice row = objAlternativeConditionPrice;

            if (row.PriceAmount.HasValue && !String.IsNullOrEmpty(row.PriceAmount_currencyID))
                xElementAlternativeConditionPrice.Add(new XElement(NamespaceProvider.Cbc + "PriceAmount", row.PriceAmount.Value.ToString($"F{cantidadDecimales}", CultureInfo.InvariantCulture),
                    new XAttribute("currencyID", row.PriceAmount_currencyID)
                ));

            if (!String.IsNullOrEmpty(row.PriceTypeCode))
                xElementAlternativeConditionPrice.Add(new XElement(NamespaceProvider.Cbc + "PriceTypeCode", row.PriceTypeCode));

            return xElementAlternativeConditionPrice;
        }

    }
}
