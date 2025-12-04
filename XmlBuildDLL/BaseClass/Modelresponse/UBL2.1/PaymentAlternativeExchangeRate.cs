using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class PaymentAlternativeExchangeRate
    {
        
        ///  de:Invoice/cac:PaymentAlternativeExchangeRate/cbc:SourceCurrencyCode 
        
        public String SourceCurrencyCode { get; set; }

        
        ///  de:Invoice/cac:PaymentAlternativeExchangeRate/cbc:SourceCurrencyBaseRate 
        
        public decimal? SourceCurrencyBaseRate { get; set; }

        
        ///  de:Invoice/cac:PaymentAlternativeExchangeRate/cbc:TargetCurrencyCode
        
        public String TargetCurrencyCode { get; set; }

        
        ///  de:Invoice/cac:PaymentAlternativeExchangeRate/cbc:TargetCurrencyBaseRate
        
        public decimal ? TargetCurrencyBaseRate { get; set; }

        
        ///  de:Invoice/cac:PaymentAlternativeExchangeRate/cbc:ExchangeMarketID
        
        public String ExchangeMarketID { get; set; }

        
        ///  de:Invoice/cac:PaymentAlternativeExchangeRate/cbc:CalculationRate 
        
        public decimal ? CalculationRate { get; set; }

        
        ///  de:Invoice/cac:PaymentAlternativeExchangeRate/cbc:MathematicOperatorCode 
        
        public String MathematicOperatorCode { get; set; }

        
        ///  de:Invoice/cac:PaymentAlternativeExchangeRate/cbc:Date 
        
        public DateTime ? Date { get; set; }

        
        ///  de:Invoice/cac:PaymentAlternativeExchangeRate/cac:ForeignExchangeContract
        
        public ForeignExchangeContract ForeignExchange { get; set; }

    }
}
