using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class DespatchDocumentReferenceXmlFill
    {
        internal static XElement FillDespatchDocumentReference(DespatchDocumentReference objDespatchDocumentReference)
        {
            XElement xElement = new XElement(NamespaceProvider.Cac + "DespatchDocumentReference");

            if (objDespatchDocumentReference != null)
            {
                DespatchDocumentReference row = objDespatchDocumentReference;

                if (!String.IsNullOrWhiteSpace(row.ID))
                {
                    xElement.Add(new XElement(NamespaceProvider.Cbc + "ID", row.ID));
                }

                if (row.IssueDate.HasValue)
                {
                    xElement.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", row.IssueDate.Value.ToString("yyyy-MM-dd")));
                }

                if (!String.IsNullOrWhiteSpace(row.DocumentTypeCode))
                {
                    xElement.Add(new XElement(NamespaceProvider.Cbc + "DocumentTypeCode", row.DocumentTypeCode));
                }

                if (!String.IsNullOrWhiteSpace(row.DocumentType))
                {
                    xElement.Add(new XElement(NamespaceProvider.Cbc + "DocumentType", row.DocumentType));
                }

                if (!String.IsNullOrWhiteSpace(row.DocumentStatusCode))
                {
                    xElement.Add(new XElement(NamespaceProvider.Cbc + "DocumentStatusCode", row.DocumentStatusCode));
                }

                if (row.DocumentDescription != null)
                {
                    foreach (String DocumentDescription in row.DocumentDescription)
                    {
                        if (DocumentDescription != null)
                        {
                            if (!String.IsNullOrWhiteSpace(DocumentDescription))
                            {
                                xElement.Add(new XElement(NamespaceProvider.Cbc + "DocumentDescription", DocumentDescription));
                            }
                        }
                    }
                }

                if (row.StartDate.HasValue && row.EndDate.HasValue)
                {
                    xElement.Add(new XElement(NamespaceProvider.Cac + "ValidityPeriod",
                       new XElement(NamespaceProvider.Cbc + "StartDate", row.StartDate.Value.ToString("yyyy-MM-dd")),
                        new XElement(NamespaceProvider.Cbc + "EndDate", row.EndDate.Value.ToString("yyyy-MM-dd")))
                       );
                }
            }

            return xElement;
        }

    }
}
