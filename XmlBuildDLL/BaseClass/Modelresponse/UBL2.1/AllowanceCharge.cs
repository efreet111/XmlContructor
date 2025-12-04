using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class AllowanceCharge
    {
        
        
        public int ID { get; set; } //TODO: Aparece en UBL 2.1 pero no en el Anexo Técnico de la DIAN. Revisar por qué se agregó en 2.0, en el XML de Producción no aparece. Steph

        //root/de:AllowanceCharge/cbc:ChargeIndicator
        public Boolean ChargeIndicator { get; set; }

        public String AllowanceChargeReasonCode { get; set; } //TODO: Aparece en UBL 2.1 pero no en el Anexo Técnico de la DIAN, pero la CCCE expone un catálogo y exige que Reason provenga de él. Steph

        
        //root/de:AllowanceCharge/cbc:AllowanceChargeReason
        public String AllowanceChargeReason { get; set; }

        
        //root/de:AllowanceCharge/cbc:MultiplierFactorNumeric
        public Decimal? MultiplierFactorNumeric { get; set; }

        
        //root/de:AllowanceCharge/cbc:Amount
        public Decimal Amount { get; set; }

        //root/de:AllowanceCharge/cbc:BaseAmount
        public Decimal BaseAmount { get; set; }

		//root/de:AllowanceCharge/cbc:Amount@CurrencyID		
		public String Amount_CurrencyID { get; set; } //TODO: No aparece en el Anexo Técnico de la DIAN, pero es necesario para especificar la moneda. Steph
		
		//root/de:AllowanceCharge/cbc:BaseAmount@CurrencyID
		public String BaseAmount_CurrencyID { get; set; }
	}
}
