using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class PersonDocumentReferenceXmlFill
    {
        internal static XElement FillDocumentReference(DocumentReference mandante, string nameNode)
        {
            XElement nodeMandate = new XElement(NamespaceProvider.Cac + nameNode);
            if (!String.IsNullOrEmpty(mandante.ID.Trim()))
                nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "ID", mandante.ID.Trim()));

            if (!String.IsNullOrEmpty(mandante.CopyIndicator.Trim()))
                nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "CopyIndicator", mandante.CopyIndicator.Trim()));

            if (!String.IsNullOrEmpty(mandante.UUID.Trim()))
                nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "UUID", mandante.UUID.Trim()));

            if (mandante.IssueDate.HasValue)
                nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", mandante.IssueDate.Value.ToString("yyyy-MM-dd")));

            if (mandante.IssueTime.HasValue)
                nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "IssueTime", mandante.IssueTime.Value.ToString("HH:mm:ss-05:00")));

            if (!String.IsNullOrEmpty(mandante.DocumentTypeCode.Trim()))
                nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "DocumentTypeCode", mandante.DocumentTypeCode.Trim()));

            if (!String.IsNullOrEmpty(mandante.DocumentType.Trim()))
                nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "DocumentType", mandante.DocumentType.Trim()));

            foreach (string xpath in mandante.XPath)
            {
                if (!String.IsNullOrEmpty(xpath.Trim()))
                    nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "XPath", xpath.Trim()));
            }

            if (!String.IsNullOrEmpty(mandante.LanguageID.Trim()))
                nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "LanguageID", mandante.LanguageID.Trim()));

            if (!String.IsNullOrEmpty(mandante.LocaleCode.Trim()))
                nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "LocaleCode", mandante.LocaleCode.Trim()));

            if (!String.IsNullOrEmpty(mandante.VersionID.Trim()))
                nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "VersionID", mandante.VersionID.Trim()));

            if (!String.IsNullOrEmpty(mandante.DocumentStatusCode.Trim()))
                nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "DocumentStatusCode", mandante.DocumentStatusCode.Trim()));

            foreach (string descripcion in mandante.DocumentDescription)
            {
                if (!String.IsNullOrEmpty(descripcion.Trim()))
                    nodeMandate.Add(new XElement(NamespaceProvider.Cbc + "DocumentDescription", descripcion.Trim()));
            }

            XElement nodeAttachment = AttachmentXmlFill.FillAttachment(mandante);
            if (nodeAttachment != null && nodeAttachment.HasElements)
                nodeMandate.Add(nodeAttachment);

            XElement Period = ValidityPeriodXmlFill.FillValidityPeriod(mandante);
            if (nodeAttachment != null && nodeAttachment.HasElements)
                nodeMandate.Add(Period);

            if (mandante.IssuerParty != null)
            {
                XElement nodeIssuer = PartyXmlFill.FillParty(mandante.IssuerParty, "IssuerParty");
                if (nodeIssuer != null && nodeIssuer.HasElements)
                    nodeMandate.Add(nodeIssuer);
            }

            //XElement resultOfVerification = FillResultOfVerification(mandante.ResultOfVerification);
            //if (resultOfVerification != null && resultOfVerification.HasElements)
            //    nodeMandate.Add(resultOfVerification);

            if (nodeMandate.HasElements)
                return nodeMandate;
            else
                return null;

        }

    }
}
