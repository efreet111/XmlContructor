using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.XmlBodyComponent
{
    public class DiscrepancyResponse
    {
        public String ReferenceID { get; set; }

        public String ResponseCode { get; set; }

        public String ResponseCodeListName { get; set; }

        public String ResponseCodeListURI { get; set; }

        public String ResponseCodeName { get; set; }
    }
}
