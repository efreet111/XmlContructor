using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class Attachment
    {
        public byte[]  EmbeddedDocumentBinaryObject { get; set; }

        public String ExternalReference_URI { get; set; }

        public String ExternalReference_DocumentHash { get; set; }

        public String ExternalReference_HashAlgorithmMethod { get; set; }

        public String ExternalReference_ExpiryDate { get; set; }

        public String ExternalReference_ExpiryTime { get; set; }

        public String ExternalReference_MimeCode { get; set; }

        public String ExternalReference_FormatCode { get; set; }

        public String ExternalReference_EncodingCode { get; set; }

        public String ExternalReference_CharacterSetCode { get; set; }

        public String ExternalReference_FileName { get; set; }

        public List<String> ExternalReference_Description { get; set; }
    }
}
