using System.Xml.Linq;
using XmlBuildDLL.BaseClass;
using static XmlBuildDLL.BaseClass.ComonXmlComponent.Catalogos;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;

namespace XmlBuildDLL.Dominio.Strategies
{
    
    /// Strategy for Invoice-related document codes (01,02,03).
    
    public class InvoiceDocumentStrategy : IDocumentTypeStrategy
    {
        public string GetRootElementName(string typeDocumentCode)
        {
            return "Invoice";
        }

        public void ApplyTypeSpecificElements(XElement documentRoot, OrquestatorXmlClass orquestator)
        {
            var cbc = NamespaceProvider.Cbc;
            if (!string.IsNullOrEmpty(orquestator.BodyXml.UUID))
            {
                documentRoot.Add(new XElement(cbc + "UUID", orquestator.BodyXml.UUID,
                    new XAttribute("schemeAgencyID", Catalog.DIAN_ID),
                    new XAttribute("schemeAgencyName", Catalog.DIAN_AgencyName),
                    new XAttribute("schemeName", "CUFE")));
            }
            if (!string.IsNullOrEmpty(orquestator.BodyXml.InvoiceTypeCode))
            {
                documentRoot.Add(new XElement(cbc + "InvoiceTypeCode", orquestator.BodyXml.InvoiceTypeCode,
                    new XAttribute("listAgencyID", Catalog.DIAN_ID),
                    new XAttribute("listAgencyName", Catalog.DIAN_AgencyName),
                    new XAttribute("listSchemeURI", Catalog.URI_InvoiceType),
                    new XAttribute("name", "Factura electrónica de venta")));
            }
        }
    }
}
