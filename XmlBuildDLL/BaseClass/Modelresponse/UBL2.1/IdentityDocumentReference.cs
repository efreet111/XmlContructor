using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class IdentityDocumentReference
    {
        public String ID { get; set; }

        public String CopyIndicator { get; set; }

        public String UUID { get; set; }

        public DateTime ? IssueDate { get; set; }

        public DateTime ? IssueTime { get; set; }

        public String DocumentTypeCode { get; set; }

        public String DocumentType { get; set; }

        public List<String> XPath { get; set; }

        public String LanguageID { get; set; }

        public String LocaleCode { get; set; }

        public String VersionID { get; set; }

        public String DocumentStatusCode { get; set; }

        public List<String> DocumentDescription { get; set; }

        //public Attachment Attachment { get; set; }

        public byte[] Attachment_EmbeddedDocumentBinaryObject { get; set; }

        public String Attachment_ExternalReference_URI { get; set; }

        public String Attachment_ExternalReference_DocumentHash { get; set; }

        public String Attachment_ExternalReference_HashAlgorithmMethod { get; set; }

        public String Attachment_ExternalReference_ExpiryDate { get; set; }

        public String Attachment_ExternalReference_ExpiryTime { get; set; }

        public String Attachment_ExternalReference_MimeCode { get; set; }

        public String Attachment_ExternalReference_FormatCode { get; set; }

        public String Attachment_ExternalReference_EncodingCode { get; set; }

        public String Attachment_ExternalReference_CharacterSetCode { get; set; }

        public String Attachment_ExternalReference_FileName { get; set; }

        public List<String> Attachment_ExternalReference_Description { get; set; }

        public DateTime ? ValidityPeriod_StartDate { get; set; }

        public DateTime ? ValidityPeriod_StartTime { get; set; }

        public DateTime ? ValidityPeriod_EndDate { get; set; }

        public DateTime ? ValidityPeriod_EndTime { get; set; }

        public String ValidityPeriod_DurationMeasure { get; set; }

        public List<String> ValidityPeriod_DescriptionCode { get; set; }

        public List<String> ValidityPeriod_Description { get; set; }

        public Party IssuerParty { get; set; } //grupo

        public ResultOfVerification ResultOfVerification { get; set; } // grupo 
    }
}
