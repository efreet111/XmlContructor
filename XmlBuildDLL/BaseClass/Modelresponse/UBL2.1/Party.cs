using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class Party
    {
        public String MarkCareIndicator { get; set; }

        public String MarkAttentionIndicator { get; set; }

        public String WebsiteURI { get; set; }

        public String LogoReferenceID { get; set; }

        public String EndpointID { get; set; }

        public String IndustryClassificationCode { get; set; }

        public String PartyIdentification { get; set; }

        public String PartyName { get; set; }

        public Language Language { get; set; }

        public Address PostalAddress { get; set; } //grupo  [0..1]   

        public Address PhysicalLocation { get; set; } //grupo  [0..1] 

        public PartyTaxScheme PartyTaxScheme { get; set; } //grupo [0..*] *** 

        public PartyLegalEntity PartyLegalEntity { get; set; } //grupo [0..*] *** 

        public Contact Contact { get; set; } //grupo [0..1]

        public List<Person> Person { get; set; } //grupo [0..*] ***

        public Party AgentParty_R { get; set; } //grupo [0..1]

        public List<ServiceProviderParty> ServiceProviderParty { get; set; } //grupo [0..*] ***

        public List<PowerOfAttorney> PowerOfAttorney { get; set; } //grupo [0..*] ***

    }

    //{
    //    public String MarkCareIndicator { get; set; }

    //    public String MarkAttentionIndicator { get; set; }

    //    public String WebsiteURI { get; set; }

    //    public String LogoReferenceID { get; set; }

    //    public String EndpointID { get; set; }

    //    public String IndustryClassificationCode { get; set; }

    //    public String PartyIdentification_ID { get; set; }

    //    public String PartyName { get; set; }

    //    public Language Language { get; set; }
    //}
}
