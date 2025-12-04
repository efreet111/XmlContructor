using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class LegalMonetaryTotal
    {
        
        /// root/de:LegalMonetaryTotal/cbc:LineExtensionAmount
        
        public decimal LineExtensionAmount { get; set; }

        
        /// root/de:LegalMonetaryTotal/cbc:LineExtensionAmount/@currencyID
        
        public String LineExtensionAmount_currencyID { get; set; }

        
        //root/de:LegalMonetaryTotal/cbc:TaxExclusiveAmount
        
        public decimal TaxExclusiveAmount { get; set; }

        
        /// root/de:LegalMonetaryTotal/cbc:TaxExclusiveAmount/@currencyID
        
        public String TaxExclusiveAmount_currencyID { get; set; }

        
        /// root/de:LegalMonetaryTotal/cbc:TaxInclusiveAmount
        
        public decimal TaxInclusiveAmount { get; set; }

        
        /// root/de:LegalMonetaryTotal/cbc:TaxInclusiveAmount/@currencyID
        
        public String TaxInclusiveAmount_currencyID { get; set; }
          
        
        /// root/de:LegalMonetaryTotal/cbc:AllowanceTotalAmount
        
        public decimal ? AllowanceTotalAmount { get; set; }

        
        /// root/de:LegalMonetaryTotal/cbc:AllowanceTotalAmount/@currencyID
        
        public String AllowanceTotalAmount_currencyID { get; set; }

        
        /// root/de:LegalMonetaryTotal/cbc:ChargeTotalAmount
        
        public decimal ? ChargeTotalAmount { get; set; }

        
        /// root/de:LegalMonetaryTotal/cbc:ChargeTotalAmount/@currencyID
        
        public String ChargeTotalAmount_currencyID { get; set; }

        
        ///root/de:LegalMonetaryTotal/cbc:PrepaidAmount
        
        public decimal ? PrepaidAmount { get; set; }

        
        ///root/de:LegalMonetaryTotal/cbc:PrepaidAmount/@currencyID
        
        public String PrepaidAmount_currencyID { get; set; }
        
        
        ///   root/de:LegalMonetaryTotal/cbc:PayableRoundingAmount
        
        public decimal? PayableRoundingAmount { get; set; }

        
        ///   root/de:LegalMonetaryTotal/cbc:PayableRoundingAmount/@currencyID
        
        public String PayableRoundingAmount_currencyID { get; set; }
        
        
        /// root/de:LegalMonetaryTotal/cbc:PayableAmount
        
        public decimal PayableAmount { get; set; }
 
        
        /// root/de:LegalMonetaryTotal/cbc:PayableAmount/@currencyID
        
        public String PayableAmount_currencyID { get; set; }
    }
}
