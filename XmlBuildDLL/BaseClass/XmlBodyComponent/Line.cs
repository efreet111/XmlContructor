using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlBuildDLL.BaseClass.ComonXmlComponent;

namespace XmlBuildDLL.BaseClass.XmlBodyComponent
{
    public class Line
    {
        public String ID { get; set; }

        public String UUID { get; set; }

        public String Note { get; set; }

        public decimal Quantity { get; set; }

        public decimal LineExtensionAmount { get; set; }

        public String LineExtensionAmountCurrencyID { get; set; }

        public String AccountingCostCode { get; set; }

        public String AccountingCost { get; set; }

        public bool FreeOfChargeIndicator { get; set; }

        public List<TaxTotal> TaxTotal { get; set; }

        public String Description { get; set; }

        public String SellersItemIdentificationID { get; set; }

        public decimal PriceAmount { get; set; }

        public String PriceAmountCurrencyID { get; set; }

    }
}
