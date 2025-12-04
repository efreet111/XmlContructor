using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class DespatchDocumentReference
    {
        
        //root/cac:DespatchDocumentReference/cbc:ID
        
        public String ID { get; set; }

        
        //root/cac:DespatchDocumentReference/cbc:UUID
        
        public String UUID { get; set; }

        
        //root/cac:DespatchDocumentReference/cbc:UUID/@schemeName
        
        public String UUID_SchemeName { get; set; }

        //
        ////root/cac:DespatchDocumentReference/cbc:IssueDate
        //
        public DateTime? IssueDate { get; set; }

        //
        ////root/cac:DespatchDocumentReference/cbc:DocumentTypeCode
        //
        public String DocumentTypeCode { get; set; }
        
        //
        ////root/cac:DespatchDocumentReference/cbc:DocumentDescription
        //
        public List<String> DocumentDescription { get; set; }


        //
        ////root/cac:DespatchDocumentReference/cbc:DocumentType
        //
        public String DocumentType { get; set; }


        public String DocumentStatusCode { get; set; }

        //public List<String> DocumentDescription { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
