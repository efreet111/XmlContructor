using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.ComonXmlComponent
{
    public class TaxSubtotal
    {
        public decimal TaxableAmount { get; set; } 
        public String TaxableAmount_currencyID { get; set; }
        public decimal TaxAmount { get; set; } 
        public decimal? BaseUnitMeasure { get; set; } 
        public String BaseUnitMeasure_unitCode { get; set; } 
        public decimal? PerUnitAmount { get; set; } 
        public String PerUnitAmount_currencyID { get; set; }
        public String TaxAmount_currencyID { get; set; }
        public decimal? Percent { get; set; } 
        public String TaxScheme_ID { get; set; }
        public String TaxScheme_Name { get; set; }
    }
}
