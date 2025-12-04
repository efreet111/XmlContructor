using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class ServiceProviderParty
    {
        public String ID { get; set; }

        public String ServiceTypeCode { get; set; }

        public List<String> ServiceType { get; set; }

        public Party Party { get; set; }

        public Contact SellerContact { get; set; }
    }
}
