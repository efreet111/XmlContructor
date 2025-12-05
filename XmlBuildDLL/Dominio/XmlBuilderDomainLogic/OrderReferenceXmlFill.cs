using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class OrderReferenceXmlFill
    {
        internal static XElement FillOrderReference(XNamespace ns, OrderReference objOrderReference)
        {
            XElement xElementOrderReference = new XElement(NamespaceProvider.Cac + "OrderReference");

            OrderReference row = objOrderReference;

            if (row != null)
                if (!String.IsNullOrEmpty(row.ID))
                    xElementOrderReference.Add(new XElement(NamespaceProvider.Cbc + "ID", row.ID));
            if (!String.IsNullOrEmpty(row.SalesOrderID))
                xElementOrderReference.Add(new XElement(NamespaceProvider.Cbc + "SalesOrderID", row.SalesOrderID));
            if (!String.IsNullOrEmpty(row.UUID))
                xElementOrderReference.Add(new XElement(NamespaceProvider.Cbc + "UUID", row.UUID,
                    new XAttribute("schemeName", row.UUIDSchemeName)));
            if (row.IssueDate.HasValue)
                xElementOrderReference.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", row.IssueDate.Value.ToString("yyyy-MM-dd")));
            if (row.IssueTime.HasValue)
                xElementOrderReference.Add(new XElement(NamespaceProvider.Cbc + "IssueTime", row.IssueTime.Value.ToString("hh:mm:ss")));
            if (!String.IsNullOrEmpty(row.CustomerReference))
                xElementOrderReference.Add(new XElement(NamespaceProvider.Cbc + "CustomerReference", row.CustomerReference));
            if (!String.IsNullOrEmpty(row.OrderTypeCode))
                xElementOrderReference.Add(new XElement(NamespaceProvider.Cbc + "OrderTypeCode", row.OrderTypeCode));
            if (row.DocumentReference != null)
            {
                XElement nodeAdicionalDocRef = DocumentReferenceFillXml.FillDocumentReference(row.DocumentReference);
                if (nodeAdicionalDocRef != null && nodeAdicionalDocRef.HasElements)
                {
                    xElementOrderReference.Add(nodeAdicionalDocRef);
                }
            }

            return xElementOrderReference;
        }


    }
}
