using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class DocumentReferenceFillXml
    {
        internal static XElement FillDocumentReference(AdditionalDocumentReference DocumentReference)
        {
            if (DocumentReference != null)
            {
                XElement DocumentReferenceNode = new XElement(NamespaceProvider.Cac + "DocumentReference");

                if (!String.IsNullOrWhiteSpace(DocumentReference.ID))
                {
                    DocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "ID", DocumentReference.ID));
                }
                if (!String.IsNullOrWhiteSpace(DocumentReference.UUID))
                {
                    DocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "UUID", DocumentReference.UUID, new XAttribute("schemeName", DocumentReference.UUID_SchemeName)));
                }

                if (DocumentReference.IssueDate.HasValue)
                {
                    DocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", DocumentReference.IssueDate.Value.ToString("yyyy-MM-dd")));
                }

                if (DocumentReference.IssueDate.HasValue)
                {
                    DocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "IssueTime", DocumentReference.IssueDate.Value.ToString("hh:mm:ss")));
                }

                if (!String.IsNullOrWhiteSpace(DocumentReference.DocumentTypeCode))
                {
                    DocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "DocumentTypeCode", DocumentReference.DocumentTypeCode));
                }

                if (!String.IsNullOrWhiteSpace(DocumentReference.DocumentType))
                {
                    DocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "DocumentType", DocumentReference.DocumentType));
                }

                if (!String.IsNullOrWhiteSpace(DocumentReference.DocumentStatusCode))
                {
                    DocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "DocumentStatusCode", DocumentReference.DocumentStatusCode));
                }

                if (DocumentReference.DocumentDescription != null)
                {
                    foreach (String DocumentDescription in DocumentReference.DocumentDescription)
                    {
                        if (!String.IsNullOrWhiteSpace(DocumentDescription))
                        {
                            DocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "DocumentDescription", DocumentDescription));
                        }
                    }
                }

                if (DocumentReference.StartDate.HasValue && DocumentReference.EndDate.HasValue)
                {
                    DocumentReferenceNode.Add
                    (
                      new XElement(NamespaceProvider.Cbc + "ValidityPeriod",
                      new XElement(NamespaceProvider.Cbc + "StartDate", DocumentReference.StartDate.Value.ToString("yyyy-MM-dd")),
                      new XElement(NamespaceProvider.Cbc + "EndDate", DocumentReference.EndDate.Value.ToString("yyyy-MM-dd")))
                    );
                }

                return DocumentReferenceNode;
            }
            else
            {
                return null;
            }
        }

    }
}
