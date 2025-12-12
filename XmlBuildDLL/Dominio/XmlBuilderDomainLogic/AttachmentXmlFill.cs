using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class AttachmentXmlFill
    {
        internal static XElement FillAttachment(DocumentReference mandante)
        {
            XElement nodeAttachment = new XElement(NamespaceProvider.Cac + "Attachment");
            if (mandante.Attachment_EmbeddedDocumentBinaryObject != null && mandante.Attachment_EmbeddedDocumentBinaryObject.Count() > 1) // convertirlo en base64
                nodeAttachment.Add(new XElement(NamespaceProvider.Cbc + "EmbeddedDocumentBinaryObject", Convert.ToBase64String(mandante.Attachment_EmbeddedDocumentBinaryObject)));

            XElement nodeExternalRef = new XElement(NamespaceProvider.Cac + "ExternalReference");
            if (!String.IsNullOrEmpty(mandante.Attachment_ExternalReference_URI.Trim()))
                nodeExternalRef.Add(new XElement(NamespaceProvider.Cbc + "URI", mandante.Attachment_ExternalReference_URI));

            if (!String.IsNullOrEmpty(mandante.Attachment_ExternalReference_DocumentHash.Trim())) // convertirlo en base64
                nodeExternalRef.Add(new XElement(NamespaceProvider.Cbc + "DocumentHash", mandante.Attachment_ExternalReference_DocumentHash));

            if (!String.IsNullOrEmpty(mandante.Attachment_ExternalReference_HashAlgorithmMethod.Trim()))
                nodeExternalRef.Add(new XElement(NamespaceProvider.Cbc + "HashAlgorithmMethod", mandante.Attachment_ExternalReference_HashAlgorithmMethod));

            if (mandante.Attachment_ExternalReference_ExpiryDate.HasValue)
                nodeExternalRef.Add(new XElement(NamespaceProvider.Cbc + "ExpiryDate", mandante.Attachment_ExternalReference_ExpiryDate.Value.ToString("yyyy-MM-dd")));

            if (mandante.Attachment_ExternalReference_ExpiryTime.HasValue)
                nodeExternalRef.Add(new XElement(NamespaceProvider.Cbc + "ExpiryTime", mandante.Attachment_ExternalReference_ExpiryTime.Value.ToString("hh:mm:ss")));

            if (!String.IsNullOrEmpty(mandante.Attachment_ExternalReference_MimeCode.Trim()))
                nodeExternalRef.Add(new XElement(NamespaceProvider.Cbc + "MimeCode", mandante.Attachment_ExternalReference_MimeCode));

            if (!String.IsNullOrEmpty(mandante.Attachment_ExternalReference_FormatCode.Trim()))
                nodeExternalRef.Add(new XElement(NamespaceProvider.Cbc + "FormatCode", mandante.Attachment_ExternalReference_FormatCode));

            if (!String.IsNullOrEmpty(mandante.Attachment_ExternalReference_EncodingCode.Trim()))
                nodeExternalRef.Add(new XElement(NamespaceProvider.Cbc + "EncodingCode", mandante.Attachment_ExternalReference_EncodingCode));

            if (!String.IsNullOrEmpty(mandante.Attachment_ExternalReference_CharacterSetCode.Trim()))
                nodeExternalRef.Add(new XElement(NamespaceProvider.Cbc + "CharacterSetCode", mandante.Attachment_ExternalReference_CharacterSetCode));

            if (!String.IsNullOrEmpty(mandante.Attachment_ExternalReference_FileName.Trim()))
                nodeExternalRef.Add(new XElement(NamespaceProvider.Cbc + "FileName", mandante.Attachment_ExternalReference_FileName));

            foreach (string descripcion in mandante.Attachment_ExternalReference_Description)
            {
                if (!String.IsNullOrEmpty(descripcion.Trim()))
                    nodeExternalRef.Add(new XElement(NamespaceProvider.Cbc + "Description", descripcion.Trim()));
            }

            if (nodeExternalRef.HasElements)
                nodeAttachment.Add(nodeExternalRef);

            if (nodeAttachment.HasElements)
                return nodeAttachment;
            else
                return null;
        }

    }
}
