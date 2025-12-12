using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse.UBL2._1
{
    public  class TaxSubtotal
    { ///de:Invoice/de:InvoiceLine/cac:TaxTotal/de:TaxSubtotal/cbc:TaxableAmount

        public decimal TaxableAmount { get; set; } // Anexo DIAN


        ///de:Invoice/de:InvoiceLine/cac:TaxTotal/de:TaxSubtotal/cbc:TaxableAmount/@currencyID

        public String TaxableAmount_currencyID { get; set; }


        ///de:Invoice/de:InvoiceLine/cac:TaxTotal/cbc:TaxAmount

        public decimal TaxAmount { get; set; } // Anexo DIAN

        public decimal? BaseUnitMeasure { get; set; } // Anexo DIAN

        public String BaseUnitMeasure_unitCode { get; set; } // Anexo DIAN

        public decimal? PerUnitAmount { get; set; } // Anexo DIAN

        public String PerUnitAmount_currencyID { get; set; } // Anexo DIAN


        ///de:Invoice/de:InvoiceLine/cac:TaxTotal/cbc:TaxAmount/@currencyID

        public String TaxAmount_currencyID { get; set; }


        ///de:Invoice/de:InvoiceLine/cac:TaxTotal/de:TaxSubtotal/cbc:Percent

        public decimal? Percent { get; set; } // Anexo DIAN


        ///de:Invoice/de:InvoiceLine/cac:TaxTotal/de:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:ID

        public String TaxScheme_ID { get; set; }


        ///de:Invoice/de:InvoiceLine/cac:TaxTotal/de:TaxSubtotal/cac:TaxCategory/cac:TaxScheme/cbc:Name

        public String TaxScheme_Name { get; set; }
    }
}
