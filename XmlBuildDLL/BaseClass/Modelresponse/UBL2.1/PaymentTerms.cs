using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{

    public class PaymentTerms
    {
        public int ReferenceEventCode { get; set; }
        public string unitCode { get; set; }
        public int? DurationMeasure { get; set; }

        
        /// root/de:PaymentTerms/cbc:ID
        
        public String PaymentTermsID { get; set; }

        
        /// root/de:PaymentTerms/cbc:PaymentMeansID
        
        public String PaymentTermMeansID { get; set; }

        
        /// root/de:PaymentTerms/cbc:Note
        
        public String PaymentTermNote { get; set; }

        
        /// root/de:PaymentTerms/cbc:PenaltySurchargePercent
        
        public String PaymentTermPenaltySurchargePercent { get; set; }

        
        /// root/de:PaymentTerms/cbc:Amount
        
        public String PaymentTermAmount { get; set; }

        
        /// root/de:PaymentTerms/cbc:PaymentPercert
        
        public String PaymentTermPaymentPercert { get; set; }

        
        /// root/de:PaymentTerms/cbc:PenaltyAmount
        
        public String PaymentTermPenaltyAmount { get; set; }

        
        /// root/de:PaymentTerms/cbc:ReferenceEventCode
        
        public String PaymentTermReferenceEventCode { get; set; }

        
        /// root/de:PaymentTerms/de:SettlementPeriod/cbc:DurationMeasure
        
        public String PaymentTermSetPeriodDurationMeasure { get; set; }

        
        /// root/de:PaymentTerms/de:SettlementPeriod/cbc:DurationMeasure@unitCode
        
        public String PaymentTermSetPeriodunitCode { get; set; }

        
        /// root/de:PaymentTerms/cbc:PaymentDueDate
        
        public DateTime? PaymentTermPaymentDueDate { get; set; }

        
        /// root/de:PaymentTerms/cbc:PrepaidPaymentReferenceID
        
        public String PaymentTermPrepaidPaymentReferenceID { get; set; }

        
        /// root/de:PaymentTerms/de:ValidityPeriod/cbc:StartDate
        
        public DateTime? PaymentTermStartDate { get; set; }


        
        /// root/de:PaymentTerms/de:ValidityPeriod/cbc:EndDate
        
        public DateTime? PaymentTermEndtDate { get; set; }
        
        
        /// root/de:PaymentTerms/cbc:SettlementDiscountPercent
        
        public decimal? PaymentTermSettlementDiscountPercent { get; set; }

    }
}
