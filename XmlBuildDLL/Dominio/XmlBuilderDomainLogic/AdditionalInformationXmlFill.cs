using System.Linq;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass;
using XmlBuildDLL.BaseClass.Dianheaders;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class AdditionalInformationXmlFill
    {
        internal static XElement FillAdditionalInformation(OrquestatorXmlClass docObj)
        {
            var cac = NamespaceProvider.Cac;
            var cbc = NamespaceProvider.Cbc;

            XElement AdditionalInformation = new XElement(cac + "AdditionalInformation");

            if (docObj == null || docObj.ExtensionFields == null || docObj.ExtensionFields.Count == 0)
                return AdditionalInformation;

            //foreach (ExtensionsFree extensible in docObj.ExtensionFields)
            //{
            //    XElement AdditionalProperty = new XElement(cac + "AdditionalProperty");

            //    if (!string.IsNullOrWhiteSpace(extensible.AdditionalProperty_ID))
            //    {
            //        AdditionalProperty.Add(new XElement(cbc + "ID", extensible.AdditionalProperty_ID));
            //    }

            //    if (!string.IsNullOrWhiteSpace(extensible.AdditionalProperty_value))
            //    {
            //        AdditionalProperty.Add(new XElement(cbc + "Value", extensible.AdditionalProperty_value));
            //    }

            //    // Only add the AdditionalProperty if it has content
            //    if (AdditionalProperty.HasElements)
            //    {
            //        AdditionalInformation.Add(AdditionalProperty);
            //    }
            //}

            return AdditionalInformation;
        }
    }
}


