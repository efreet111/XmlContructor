using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Dianheaders
{
    public  class BodyXml
    {
        public String TypeDocument { get; set; }

        public String TypeDocumentCode { get; set; }

        public String InvoiceTypeCode { get; set; }

        public String IssueDateSigned { get; set; }

        public String UBLVersionID { get; set; }

        public String CustomizationID { get; set; }

        public String ProfileID { get; set; }

        public String ProfileExecutionID { get; set; }

        public String ID { get; set; }

        public String UUID { get; set; }

        public DateTime IssueDate { get; set; }

        public TimeSpan IssueTime { get; set; }

        public String Note { get; set; }

        public String DocumentCurrencyCode { get; set; }
        public String PayerPartyName { get; set; }
        public string DespatchDocumentRefID { get; set; }
        public String DeliveryDateTime { get; set; }


    }
}
