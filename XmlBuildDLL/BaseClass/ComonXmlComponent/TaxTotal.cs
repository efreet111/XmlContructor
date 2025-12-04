using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.ComonXmlComponent
{
    public class TaxTotal
    {
        public decimal TaxAmount { get; set; }

        public String TaxAmount_currencyID { get; set; }

        public String TaxEvidenceIndicator { get; set; }

        public List<TaxSubtotal> TaxSubtotal { get; set; }
    }
}
