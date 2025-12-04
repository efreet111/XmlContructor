using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    class BuyersItemIdentification
    {
        
        //root/de:BuyersItemIdentification/cbc:ID	
        
        public String BuyersItemIdentificationId { get; set; }


        
        //root/de:BuyersItemIdentification/cbc:ID@schemeAgencyID
        
        public String BuyersItemIdentificationschemeAgencyID { get; set; }
    
        
        //root/de:BuyersItemIdentification/cbc:ID@schemeName
        
        public String BuyersItemIdentificationschemeName { get; set; }

    }
}
