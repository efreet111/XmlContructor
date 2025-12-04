using System.Xml.Linq;
using XmlBuildDLL.BaseClass;
using XmlBuildDLL.BaseClass.XmlBodyComponent;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class ReferencesExtensionsBuilder
    {
        public static void AddReferencesExtensions(XElement ePadre, OrquestatorXmlClass docObj)
        {
            if (docObj == null || ePadre == null) return;

            var cac = NamespaceProvider.Cac;
            var cbc = NamespaceProvider.Cbc;

            if (docObj.Order_Reference != null)
            {
                ePadre.Add(new XElement(cbc + "OrderReference",
                             new XElement(cbc + "ID", docObj.Order_Reference.ID)));
            }

            if (!string.IsNullOrWhiteSpace(docObj.BodyXml?.DespatchDocumentRefID) && !string.IsNullOrWhiteSpace(docObj.BodyXml.DespatchDocumentRefID))
            {
                ePadre.Add(new XElement(cbc + "DespatchDocumentRefenrece",
                            new XElement(cbc + "ID", docObj.BodyXml.DespatchDocumentRefID)));
            }

            if (docObj.ReceiptDocumentReferences != null && docObj.ReceiptDocumentReferences.Count > 0)
            {
                foreach (ReceiptDocumentRef receip in docObj.ReceiptDocumentReferences)
                {
                    XElement receipReference = new XElement(cac + "ReceiptDocumentReference");
                    if (!string.IsNullOrWhiteSpace(receip.ID))
                        receipReference.Add(new XElement(cbc + "ID", receip.ID));
                    if (!string.IsNullOrWhiteSpace(receip.IssueDate))
                        receipReference.Add(new XElement(cbc + "IssueDate", receip.IssueDate));
                    if (!string.IsNullOrWhiteSpace(receip.UUID))
                        receipReference.Add(new XElement(cbc + "UUID", receip.UUID));

                    if (receipReference.HasElements)
                        ePadre.Add(receipReference);
                }
            }
        }
    }
}
