using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.ComonXmlComponent
{
    public class LegalMonetaryTotal
    {
        public decimal LineExtensionAmount { get; set; }

        public String LineExtensionAmountCurrencyID { get; set; }

        public decimal TaxExclusiveAmount { get; set; }

        public String TaxExclusiveAmountCurrencyID { get; set; }

        public decimal PayableAmount { get; set; }

        public String PayableAmountCurrencyID { get; set; }
    }
}
