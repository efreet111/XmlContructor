using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    
    //de:Invoice/de:DeliveryTerms
    
    public class DeliveryTerms
    {
        
        //de:Invoice/de:DeliveryTerms/cbc:ID
        
        public String ID { get; set; }

        
        //de:Invoice/de:DeliveryTerms/cbc:SpecialTerms
        
        public String SpecialTerms { get; set; }

        
        //de:Invoice/de:DeliveryTerms/cbc:LossRiskResponsibilityCode
        
        public String LossRiskResponsibilityCode { get; set; }

        
        //de:Invoice/de:DeliveryTerms/cbc:LossRisk
        
        public String LossRisk { get; set; }

        
        //de:Invoice/de:DeliveryTerms/cac:DeliveryLocation
        
        public Address DeliveryLocation { get; set; }

        
        //de:Invoice/de:DeliveryTerms/cac:AllowanceCharge
        
        public AllowanceCharge AllowanceCharge { get; set; }
    }
}
