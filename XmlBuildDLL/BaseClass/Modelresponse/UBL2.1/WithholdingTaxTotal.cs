using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
	
	///root/cac:WithholdingTaxTotal
	///root/cac:InvoiceLine/cac:WithholdingTaxTotal
	
	public class WithholdingTaxTotal
	{
		
		///../cac:WithholdingTaxTotal/cbc:TaxAmount
		
		public decimal TaxAmount { get; set; }

		
		///../cac:WithholdingTaxTotal/cbc:TaxAmount@currencyID
		
		public String TaxAmount_currencyID { get; set; }

		
		///../cac:WithholdingTaxTotal/cac:TaxTotal/de:TaxSubtotal
		
		public List<TaxSubtotal> TaxSubtotal { get; set; }
	}
}
