using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.XmlBodyComponent
{
    public class PaymentTerms
    {
        public string Id { get; set; }

        public string[] Note { get; set; }

        public decimal SettlementDiscountPercent { get; set; }

        public decimal PenaltySurchargePercent { get; set; }

        public decimal Amount { get; set; }

        //public CurrencyCodeContentType AmountCurrency { get; set; }
    }
}
