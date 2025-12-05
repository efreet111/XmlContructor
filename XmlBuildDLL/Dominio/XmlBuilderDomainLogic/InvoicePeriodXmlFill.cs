using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.DocumentClass.UBL2._1;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class InvoicePeriodXmlFill
    {
        internal static XElement FillInvoicePeriod(InvoicePeriod obj)
        {
            if (obj != null)
            {
                XElement invoicePeriod = new XElement(NamespaceProvider.Cac + "InvoicePeriod");

                if (obj.StartDate.HasValue)
                {
                    invoicePeriod.Add(new XElement(NamespaceProvider.Cbc + "StartDate", obj.StartDate.Value.ToString("yyyy-MM-dd")));
                }

                if (obj.StartTime.HasValue)
                {
                    invoicePeriod.Add(new XElement(NamespaceProvider.Cbc + "StartTime", obj.StartTime.Value.ToString("hh:mm:ss")));
                }

                if (obj.EndDate.HasValue)
                {
                    invoicePeriod.Add(new XElement(NamespaceProvider.Cbc + "EndDate", obj.EndDate.Value.ToString("yyyy-MM-dd")));
                }

                if (obj.EndTime.HasValue)
                {
                    invoicePeriod.Add(new XElement(NamespaceProvider.Cbc + "EndTime", obj.EndTime.Value.ToString("hh:mm:ss")));
                }

                return invoicePeriod;
            }
            else
            {
                return null;
            }
        }

    }
}
