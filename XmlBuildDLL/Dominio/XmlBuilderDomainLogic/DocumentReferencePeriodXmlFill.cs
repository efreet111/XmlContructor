using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class DocumentReferencePeriodXmlFill
    {
        internal static XElement FillDocRefPeriod(DocumentReference mandante)
        {
            XElement nodePeriod = new XElement(NamespaceProvider.Cac + "ValidityPeriod");
            if (mandante.ValidityPeriod_StartDate.HasValue)
                nodePeriod.Add(new XElement(NamespaceProvider.Cbc + "StartDate", mandante.ValidityPeriod_StartDate.Value.ToString("yyyy-MM-dd")));

            if (mandante.ValidityPeriod_StartTime.HasValue)
                nodePeriod.Add(new XElement(NamespaceProvider.Cbc + "StartTime", mandante.ValidityPeriod_StartTime.Value.ToString("hh:mm:ss")));

            if (mandante.ValidityPeriod_EndDate.HasValue)
                nodePeriod.Add(new XElement(NamespaceProvider.Cbc + "EndDate", mandante.ValidityPeriod_EndDate.Value.ToString("yyyy-MM-dd")));

            if (mandante.ValidityPeriod_EndTime.HasValue)
                nodePeriod.Add(new XElement(NamespaceProvider.Cbc + "EndTime", mandante.ValidityPeriod_EndTime.Value.ToString("hh:mm:ss")));

            if (!String.IsNullOrEmpty(mandante.ValidityPeriod_DurationMeasure.Trim()))
                nodePeriod.Add(new XElement(NamespaceProvider.Cbc + "DurationMeasure", mandante.ValidityPeriod_DurationMeasure.Trim()));

            foreach (string descripcionCode in mandante.ValidityPeriod_DescriptionCode)
            {
                if (!String.IsNullOrEmpty(descripcionCode.Trim()))
                    nodePeriod.Add(new XElement(NamespaceProvider.Cbc + "DescriptionCode", descripcionCode.Trim()));
            }

            foreach (string descripcion in mandante.ValidityPeriod_Description)
            {
                if (!String.IsNullOrEmpty(descripcion.Trim()))
                    nodePeriod.Add(new XElement(NamespaceProvider.Cbc + "Description", descripcion.Trim()));
            }

            if (nodePeriod.HasAttributes)
                return nodePeriod;
            else
                return null;
        }
    }
}
