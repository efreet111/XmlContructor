using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class Contact
    {
        public String ID { get; set; }

        public String Name { get; set; }

        public String Telephone { get; set; }

        public String Telefax { get; set; }

        public String ElectronicMail { get; set; }

        public List<String> Note { get; set; }

        public List<OtherCommunication> OtherCommunication { get; set; }
    }
}
