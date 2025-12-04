using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{

    
    ///  de:Invoice/cac:PaymentExchangeRate
    
    public class PaymentExchangeRate
    {
        
        ///  de:Invoice/cac:PaymentExchangeRate/cbc:SourceCurrencyCode 
        
        public String SourceCurrencyCode { get; set; }

        
        ///  de:Invoice/cac:PaymentExchangeRate/cbc:SourceCurrencyBaseRate 
        
        public decimal ? SourceCurrencyBaseRate { get; set; }

        
        ///  de:Invoice/cac:PaymentExchangeRate/cbc:TargetCurrencyCode
        
        public String TargetCurrencyCode { get; set; }

        
        ///  de:Invoice/cac:PaymentExchangeRate/cbc:TargetCurrencyBaseRate
        
        public decimal ? TargetCurrencyBaseRate { get; set; }

        
        ///  de:Invoice/cac:PaymentExchangeRate/cbc:ExchangeMarketID
        
        public String ExchangeMarketID { get; set; }

        
        ///  de:Invoice/cac:PaymentExchangeRate/cbc:CalculationRate 
        
        public decimal ? CalculationRate { get; set; }

        
        ///  de:Invoice/cac:PaymentExchangeRate/cbc:MathematicOperatorCode 
        
        public String MathematicOperatorCode { get; set; }

        
        ///  de:Invoice/cac:PaymentExchangeRate/cbc:Date 
        
        public DateTime ? Date { get; set; }

        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract
        
        public ForeignExchangeContract ForeignExchange { get; set; }

    }
}
