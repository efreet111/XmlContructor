using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class PowerOfAttorney
    {
        public String ID { get; set; }

        public DateTime ? IssueDate { get; set; }

        public DateTime ? IssueTime { get; set; }

        public List<String> Description { get; set; }

        public Party NotaryParty { get; set; } //[0..1] 

        public Party AgentParty { get; set; } //[1..1] 

        public Party WitnessParty { get; set; } //[0..*] 

        public List<DocumentReference> MandateDocumentReference { get; set; } //[0..*] 
    }
}
