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
    internal class LinePriceXmlFill
    {
        internal static XElement FillLinePrice( InvoiceLine line, ref int cantidadDecimales)
        {
            if (line == null)
                return null;

            XElement price = new XElement(NamespaceProvider.Cac + "Price");

            if (line.PriceAmount != 0m && !String.IsNullOrEmpty(line.PriceAmount_currencyID))
                price.Add(new XElement(
                    NamespaceProvider.Cbc + "PriceAmount",
                    Math.Round(line.PriceAmount, cantidadDecimales).ToString("F" + cantidadDecimales, CultureInfo.InvariantCulture),
                    new XAttribute("currencyID", line.PriceAmount_currencyID)
                ));

            if (line.BaseQuantity != 0m && !String.IsNullOrEmpty(line.BaseQuantity_unitCode))
                price.Add(new XElement(
                    NamespaceProvider.Cbc + "BaseQuantity",
                    Math.Round(line.BaseQuantity, cantidadDecimales).ToString("F" + cantidadDecimales, CultureInfo.InvariantCulture),
                    new XAttribute("unitCode", line.BaseQuantity_unitCode)
                ));

            if (price.HasElements)
            {
                return price;
            }
            else
            {
                return null;
            }
        }

    }
}
