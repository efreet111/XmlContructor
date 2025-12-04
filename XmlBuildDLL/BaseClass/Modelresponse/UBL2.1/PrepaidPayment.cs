using System;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    
    //root/de:PrepaidPayment
    
    public class PrepaidPayment
    {
        
        //root/de:PrepaidPayment/cbc:ID
        
        public String ID { get; set; }

        
        //root/de:PrepaidPayment/cbc:PaidAmount
        
        public decimal? PaidAmount { get; set; }

        public String PaidAmount_currencyID { get; set; }

        
        //root/de:PrepaidPayment/cbc:ReceivedDate
        
        public DateTime? ReceivedDate { get; set; }

        
        //root/de:PrepaidPayment/cbc:PaidDate
        
        public DateTime? PaidDate { get; set; }

        
        //root/de:PrepaidPayment/cbc:PaidTime
        
        public DateTime? PaidTime { get; set; }

        
        //root/de:PrepaidPayment/cbc:InstructionID
        
        public String InstructionID { get; set; }
    }
}
