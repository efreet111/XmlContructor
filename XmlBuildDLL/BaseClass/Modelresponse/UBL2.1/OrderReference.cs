using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class OrderReference
    {
        //
        ////root/cac:OrderReference/cbc:ID
        //
        public string ID { get; set; }

        //
        ////root/cac:OrderReference/cbc:SalesOrderID
        //
        public string SalesOrderID { get; set; }

        //
        ////root/cac:OrderReference/cbc:UUID
        //
        public string UUID { get; set; }

        //
        ////root/cac:OrderReference/cbc:UUID@schemeName
        //
        public string UUID_SchemeName { get; set; }

        //
        ////root/cac:OrderReference/cbc:IssueDate
        //
        public DateTime? IssueDate { get; set; }

        //
        ////root/cac:OrderReference/cbc:IssueTime
        //
        public DateTime? IssueTime { get; set; }

        //
        ////root/cac:OrderReference/cbc:CustomerReference
        //
        public string CustomerReference { get; set; }

        //
        ////root/cac:OrderReference/cbc:OrderTypeCode
        //
        public string OrderTypeCode { get; set; }

        public AdditionalDocumentReference DocumentReference { get; set; }
    }
}
