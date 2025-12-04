using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    
    //root/de:Delivery
    
    public class Delivery
    {
        
        //root/de:Delivery/cbc:ActualDeliveryDate
        
        public DateTime ? ActualDeliveryDate { get; set; }

        
        //root/de:Delivery/cbc:ActualDeliveryTime
        
        /// 
        public DateTime ? ActualDeliveryTime { get; set; }

        
        //root/de:Delivery/de:DeliveryAddress
        
        /// 
        public Address DeliveryAddress { get; set; }

        
        //root/de:Delivery/de:DeliveryParty
        
        /// 
        public DeliveryParty DeliveryParty { get; set; }


        
        //root/de:Delivery/de:DeliveryLocation/de:Address/cbc:PhysicalLocation
        
        /// 
        public Address PhysicalLocation { get; set; }

        
        //root/de:Delivery/de:Despatch
        
        /// 
        public Despatch Despatch { get; set; }

    }
    
    public class DeliveryParty
    {
        
        //root/de:Delivery/de:DeliveryParty/cbc:MarkCareIndicator
        
        /// 
        public bool MarkCareIndicator { get; set; }

        
        //root/de:Delivery/de:DeliveryParty/cbc:MarkAttentionIndicator
        
        /// 
        public bool MarkAttentionIndicator { get; set; }

        
        //root/cac:Delivery/cac:DeliveryParty/cac:PartyName
        
        /// 
        public String PartyName { get; set; }

        
        //root/cac:Delivery/cac:DeliveryParty/cac:PartyTaxScheme
        
        /// 
        public PartyTaxScheme PartyTaxScheme { get; set; }

        
        //root/cac:Delivery/cac:DeliveryParty/cac:PhysicalLocation/cac:Address
        
        /// 
        public Address PhysicalLocation { get; set; }

        
        //root/cac:Delivery/cac:DeliveryParty/cac:contact
        
        /// 
        public Contact contact { get; set; }

    }

    public class Despatch
    {
        
        //root/de:Delivery/de:Despatch/cbc:ID
        
        /// 
        public String ID { get; set; }

        
        //root/de:Delivery/de:Despatch/cbc:ID/@schemeAgencyID
        
        /// 
        public String SchemeName { get; set; }

        
        //root/de:Delivery/de:Despatch/cbc:RequestedDespatchDate
        
        /// 
        public DateTime ? RequestedDespatchDate { get; set; }

        
        //root/de:Delivery/de:Despatch/cbc:RequestedDespatchTime
        
        /// 
        public DateTime ? RequestedDespatchTime { get; set; }

        
        //root/de:Delivery/de:Despatch/cbc:EstimatedDespatchDate
        
        /// 
        public DateTime ? EstimatedDespatchDate { get; set; }

        
        //root/de:Delivery/de:Despatch/cbc:EstimatedDespatchTime
        
        /// 
        public DateTime ? EstimatedDespatchTime { get; set; }

        
        //root/de:Delivery/de:Despatch/cbc:ActualDespatchDate
        
        /// 
        public DateTime ? ActualDespatchDate { get; set; }

        
        //root/de:Delivery/de:Despatch/cbc:ActualDespatchTime
        
        /// 
        public DateTime ? ActualDespatchTime { get; set; }

        
        //root/de:Delivery/de:Despatch/de:DespatchAddress
        
        /// 
        public Address DespatchAddress { get; set; }

        
        //root/de:Delivery/de:Despatch/de:DespatchParty
        
        /// 
        public Party DespatchParty { get; set; }
    }

    public class DespatchParty
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

        public Party AgentParty { get; set; } //grupo [0..1]

        public List<ServiceProviderParty> ServiceProviderParty { get; set; } //grupo [0..*] ***

        public List<PowerOfAttorney> PowerOfAttorney { get; set; } //grupo [0..*] ***

        public FinancialAccount FinancialAccount { get; set; } //grupo [0..1]
    }
}
