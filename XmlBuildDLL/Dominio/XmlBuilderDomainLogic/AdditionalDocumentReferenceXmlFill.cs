using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class AdditionalDocumentReferenceXmlFill
    {
        internal static XElement FillAdditionalDocumentReference(AdditionalDocumentReference additionalDocumentReference)
        {
            if (additionalDocumentReference != null)
            {
                XElement additionalDocumentReferenceNode = new XElement(NamespaceProvider.Cac + "AdditionalDocumentReference");

                if (!String.IsNullOrWhiteSpace(additionalDocumentReference.ID))
                {
                    additionalDocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "ID", additionalDocumentReference.ID));
                }


                if (!String.IsNullOrWhiteSpace(additionalDocumentReference.UUID))
                {
                    additionalDocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "UUID", additionalDocumentReference.UUID, new XAttribute("schemeName", additionalDocumentReference.UUID_SchemeName)));
                }

                if (additionalDocumentReference.IssueDate.HasValue)
                    additionalDocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", additionalDocumentReference.IssueDate.Value.ToString("yyyy-MM-dd")));


                if (!String.IsNullOrWhiteSpace(additionalDocumentReference.DocumentTypeCode))
                {
                    additionalDocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "DocumentTypeCode", additionalDocumentReference.DocumentTypeCode));
                }


                if (!String.IsNullOrWhiteSpace(additionalDocumentReference.DocumentType))
                {
                    additionalDocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "DocumentType", additionalDocumentReference.DocumentType));
                }

                if (!String.IsNullOrWhiteSpace(additionalDocumentReference.DocumentStatusCode))
                {
                    additionalDocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "DocumentStatusCode", additionalDocumentReference.DocumentStatusCode));
                }

                if (additionalDocumentReference.DocumentDescription != null)
                {
                    foreach (String DocumentDescription in additionalDocumentReference.DocumentDescription)
                    {
                        if (!String.IsNullOrWhiteSpace(DocumentDescription))
                        {
                            additionalDocumentReferenceNode.Add(new XElement(NamespaceProvider.Cbc + "DocumentDescription", DocumentDescription));
                        }
                    }
                }

                if (additionalDocumentReference.StartDate.HasValue && additionalDocumentReference.EndDate.HasValue)
                {
                    additionalDocumentReferenceNode.Add(new XElement(NamespaceProvider.Cac + "ValidityPeriod",
                       new XElement(NamespaceProvider.Cbc + "StartDate", additionalDocumentReference.StartDate.Value.ToString("yyyy-MM-dd")),
                        new XElement(NamespaceProvider.Cbc + "EndDate", additionalDocumentReference.EndDate.Value.ToString("yyyy-MM-dd")))
                       );
                }

                return additionalDocumentReferenceNode;
            }
            else
            {
                return null;
            }
        }

    }
}
