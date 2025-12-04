using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.Response
{
    public class BuildXmlResponse
    {
        public int code { get; set; }

        public string message { get; set; }

        public string xml { get; set; }

        public string uuid { get; set; }
    }
}
