using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    
    ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract
    
    public class ForeignExchangeContract
    {
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cbc:ID
        
        public String ID { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cbc:IssueDate
        
        public DateTime ? IssueDate { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cbc:IssueTime 
        
        public DateTime ? IssueTime { get; set; }

        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cbc:NominationDate
        
        public DateTime ? NominationDate { get; set; }

        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cbc:NominationTime
        
        public DateTime ? NominationTime { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cbc:ContractTypeCode
        
        public String ContractTypeCode { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cbc:ContractType
        
        public String ContractType { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cbc:Note 
        
        public List<String>  Note { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cbc:VersionID 
        
        public String VersionID { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cbc:Description  
        
        public List<String>   Description { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ValidityPeriod 
        
        public Period ValidityPeriod { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference
        
        public ContractDocumentReference ContractDocumentReference { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:NominationPeriod 
        
        public Period NominationPeriod { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractualDelivery 
        
        public Delivery  ContractualDelivery { get; set; }

    }

    public class Period
    {
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ValidityPeriod/cbc:StartDate
        
        public DateTime ? StartDate { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ValidityPeriod/cbc:StartTime
        
        public DateTime ? StartTime { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ValidityPeriod/cbc:EndDate
        
        public DateTime ? EndDate { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ValidityPeriod/cbc:EndTime
        
        public DateTime ? EndTime { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ValidityPeriod/cbc:DurationMesasure
        
        public String DurationMesasure { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ValidityPeriod/cbc:DescriptionCode
        
        public List<String> DescriptionCode { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ValidityPeriod/cbc:Description
        
        public List<String> Description { get; set; }
    }



    public class ContractDocumentReference
    {
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:ID
        
        public String ID { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:CopyIndicator
        
        public String CopyIndicator { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:UUID
        
        public String UUID { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:IssueDate
        
        public DateTime ? IssueDate { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:IssueTime
        
        public DateTime ? IssueTime { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:DocumentTypeCode
        
        public String DocumentTypeCode { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:DocumentType
        
        public String DocumentType { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:XPath
        
        public List<String> XPath { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:LanguageID
        
        public String LanguageID { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:LocaleCode
        
        public String LocaleCode { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:VersionID
        
        public String VersionID { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:DocumentStatusCode
        
        public String DocumentStatusCode { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cbc:DocumentDescription
        
        public String DocumentDescription { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cac:Attachment
        
        public String Attachment { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cac:ValidityPeriod
        
        public Period ValidityPeriod { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cac:IssuerPartyName
        
        public String IssuerPartyName { get; set; }
        
        ///  de:Invoice/cac:PaymentExchangeRate/cac:ForeignExchangeContract/cac:ContractDocumentReference/cac:ResultOfVerification
        
        public ResultOfVerification ResultOfVerification { get; set; }
       
    }

    public class ResultOfVerification
    {
        
        ///  ../cac:ResultOfVerification/cbc:ValidatorID
        
        public String ValidatorID { get; set; }
        
        ///  ../cac:ResultOfVerification/cbc:ValidationResultCode
        
        public String ValidationResultCode { get; set; }
        
        ///  ../cac:ResultOfVerification/cbc:ValidationDate
        
        public DateTime ? ValidationDate { get; set; }
        
        ///  ../cac:ResultOfVerification/cbc:ValidationTime
        
        public DateTime ? ValidationTime { get; set; }
        
        ///  ../cac:ResultOfVerification/cbc:ValidationProcess
        
        public String ValidationProcess { get; set; }
        
        ///  ../cac:ResultOfVerification/cbc:ValidationTool
        
        public String ValidationTool { get; set; }
        
        ///  ../cac:ResultOfVerification/cbc:ValidationToolVersion
        
        public String ValidationToolVersion { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty
        
        public String SignatoryParty { get; set; }
    }

    public class SignatoryParty
    {
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cbc:MarkCareIndicator
        
        public bool MarkCareIndicator { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cbc:MarkAttentionIndicator
        
        public bool MarkAttentionIndicator { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cbc:WebsiteURI
        
        public String WebsiteURI { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cbc:LogoReferenceID
        
        public String LogoReferenceID { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cbc:EndpointID
        
        public String EndpointID { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cbc:IndustryClassificationCode
        
        public String IndustryClassificationCode { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cac:PartyIdentification
        
        public List<String> PartyIdentification { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cac:PartyName
        
        public List<String> PartyName { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cac:Language
        
        public String Language { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cac:PostalAddress
        
        public String PostalAddress { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cac:PhysicalLocation
        
        public Address PhysicalLocation { get; set; } //OJO
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cac:TaxScheme
        
        public PartyTaxScheme TaxScheme { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cac:LegalEntity
        
        public PartyLegalEntity LegalEntity { get; set; }
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cac:Contact
        
        public Contact Contact { get; set; } //OJO
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cac:Person
        
        public List<Person> Person { get; set; } //OJO
        
        ///  ../cac:ResultOfVerification/cac:SignatoryParty/cac:ProviderParty
        
        public List<ServiceProviderParty> ProviderParty { get; set; }
//        cac:PowerOfAttorney[0..*] A power of attorney associated with this party.
//        cac:FinancialAccount[0..1]
    }
}
