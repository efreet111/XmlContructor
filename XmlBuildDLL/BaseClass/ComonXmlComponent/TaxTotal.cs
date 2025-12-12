using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.ComonXmlComponent
{
    public class TaxTotal
    {

        ///de:Invoice/de:InvoiceLine/cac:TaxTotal/cbc:TaxAmount
        public decimal TaxAmount { get; set; }


        ///de:Invoice/de:InvoiceLine/cac:TaxTotal/cbc:RoundingAmount
        public String RoundingAmount { get; set; }

        ///de:Invoice/de:InvoiceLine/cac:TaxTotal/de:TaxSubtotal/cac:TaxCategory/cac:TaxScheme
        public String TaxAmount_currencyID { get; set; }

        ///de:Invoice/de:InvoiceLine/cac:TaxTotal/cbc:TaxEvidenceIndicator
        public String TaxEvidenceIndicator { get; set; }

        ///de:Invoice/de:InvoiceLine/cac:TaxTotal/de:TaxSubtotal
        public List<TaxSubtotal> TaxSubtotal { get; set; }
    }
}
