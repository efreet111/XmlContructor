using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.DocumentClass.UBL2._1;
using static System.Net.Mime.MediaTypeNames;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class HeaderExtensionsXmlFill
    {
        internal static void HeaderExtensions(ref XElement documentXML, BillingDocument21Object baseObj)
        {
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "cac", NamespaceProvider.Cac));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "cbc", NamespaceProvider.Cbc));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "ds", NamespaceProvider.Ds));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "ext", NamespaceProvider.Ext));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "xsi", NamespaceProvider.Xsi));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "udt", NamespaceProvider.Udt));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "qdt", NamespaceProvider.Qdt));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "sts", NamespaceProvider.Sts));

            documentXML.Add(new XAttribute(XNamespace.Xmlns + "xades", NamespaceProvider.Xades));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "xades141", NamespaceProvider.Xades141));

            documentXML.Add(new XAttribute(XNamespace.Xmlns + "sac", NamespaceProvider.Sac));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "sbc", NamespaceProvider.Sbc));

            XElement ublExtensions = new XElement(NamespaceProvider.Ext + "UBLExtensions");
            XElement ublExtensionDian = new XElement(NamespaceProvider.Ext + "UBLExtension");
            XElement extensionContentDian = new XElement(NamespaceProvider.Ext + "ExtensionContent");
            XElement dianExtensions = DianExtensionsXmlFill.FillDianExtensions(baseObj);

            if (dianExtensions != null && dianExtensions.HasElements)
            {
                extensionContentDian.Add(dianExtensions);
                ublExtensionDian.Add(extensionContentDian);
                ublExtensions.Add(ublExtensionDian);
            }

            // Verificamos si hay elementos en baseObj.Extensible y si alguno de los nombres es "FEXP1", "FEXP2" o "FEXP3"
            var fexpIds = new[] { "FEXP1", "FEXP2", "FEXP3" };
            var restrictedInvoiceTypes = new[] { "03", "04", "05", "91", "92", "95" };

            if (baseObj.Extensible != null)
                if (baseObj.Extensible.Any(extensiblesNote =>
                  fexpIds.Contains(extensiblesNote.ID) &&
                  !restrictedInvoiceTypes.Contains(baseObj.InvoiceTypeCode)))
                {
                    // Contar cuántos FEXP están presentes
                    var presentFexpIds = baseObj.Extensible
                        .Where(e => fexpIds.Contains(e.ID))
                        .Select(e => e.ID)
                        .Distinct()
                        .Count();

                    if (presentFexpIds == 3)
                    {
                        //InteroperabilidadPTHeaderExtensionsVentayExportación(ref documentXML, ref ublExtensions, baseObj);
                    }
                    else if (presentFexpIds > 0 && presentFexpIds < 3)
                    {
                        //InteroperabilidadPTHeaderExtensionsVentaNoFEXT2(ref documentXML, ref ublExtensions, baseObj);
                    }

                    if (baseObj.Extensible.Any(extensiblesNote => extensiblesNote.Name == "INTE1" || extensiblesNote.Name == "INTE2"))
                    {
                        //InteroperabilidadHeaderExtensions(ref documentXML, ref ublExtensions, baseObj);
                    }
                }
                else if (baseObj.Extensible.Any(extensiblesNote => extensiblesNote.Name == "INTE1" || extensiblesNote.Name == "INTE2"))
                {
                    //InteroperabilidadHeaderExtensions(ref documentXML, ref ublExtensions, baseObj);
                }

            if (!restrictedInvoiceTypes.Contains(baseObj.InvoiceTypeCode))
            {
                //InteroperabilidadHeaderExtensionsVentayExportaciónAditional(ref documentXML, ref ublExtensions, baseObj);
            }




            documentXML.Add(ublExtensions);
        }

    }
}
