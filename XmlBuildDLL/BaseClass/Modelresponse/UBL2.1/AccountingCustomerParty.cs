using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class AccountingCustomerParty
    {
        
        /// root/de:AccountingCustomerParty/cbc:AdditionalAccountID
        
        public int AdditionalAccountID { get; set; }

        
        /// root/de:AccountingCustomerParty/cbc:AdditionalAccountID/@schemeAgencyID 
        
        public String AdditionalAccountID_SchemeAgencyID { get; set; }

        
        /// root/de:AccountingCustomerParty/cbc:AdditionalAccountID/@schemeName
        
        public String AdditionalAccountID_SchemeName { get; set; }

        
        /// root/de:AccountingCustomerParty/cbc:AdditionalAccountID/@schemeID
        
        public String AdditionalAccountID_SchemeID { get; set; }
        
		/// root/:cac:AccountingCustomerParty/:cac:PartyIdentification/cbc:ID
		
        public String PartyIdentificationID { get; set; }
        
		/// root/:cac:AccountingCustomerParty/:cac:PartyIdentification/cbc:ID@schemeName 
		
        public String PartyIdentificationID_SchemeName { get; set; }
        
		/// root/:cac:AccountingCustomerParty/:cac:PartyIdentification/cbc:ID@schemeID
		
        public String PartyIdentificationID_SchemeID { get; set; }
        
        /// root/de:AccountingCustomerParty/de:Party/cac:PartyName/cbc:Name
        
        public String PartyName { get; set; }
                 
        ///root/de:AccountingCustomerParty/de:PhysicalLocation/de:Address
        
        public Address PhysicalLocation { get; set; }
        
        ///root/de:AccountingCustomerParty/de:Party/de:PartyTaxScheme
        
        public PartyTaxScheme TaxScheme { get; set; }
        
        ///root/de:AccountingCustomerParty/de:Party/de:IndustryClassificationCode
        
        public String IndustryClassificationCode { get; set; }

        
        ///root/de:AccountingCustomerParty/de:Party/de:PartyLegalEntity
        
        public PartyLegalEntity LegalEntity { get; set; }

        public AccountingCustomerPartyContact ACContact { get; set; }

        public PartyPerson PartyPerson { get; set; }

        public PartyPersonIdentityDocumentReference PartyPersonIdentityDocumentReference { get; set; }

        public ResidenceAddress ResidenceAddress { get; set; }
    }

    public class PartyPersonIdentityDocumentReference
    {
        
        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:IdentityDocumentReference/cbc:ID
        
        public string ID { get; set; }

        
        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:IdentityDocumentReference/cbc:ID@schemeName
        
        public string schemeName { get; set; }

        
        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:IdentityDocumentReference/cbc:ID@schemeID
        
        public string schemeID { get; set; }


        
        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:IdentityDocumentReference/de:IssuerParty/de:PartyName/cbc:IdentificationCode
        
        public string IdentificationCode { get; set; }
        
        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:IdentityDocumentReference/de:IssuerParty/de:PartyName/cbc:Name
        
        public string Name { get; set; }

        
        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:IdentityDocumentReference/de:IssuerParty/de:PostalAddress/cbc:Country
        
        public string Country { get; set; }

    }

    public class AccountingCustomerPartyContact
    {
        
        ///root/de:AccountingCustomerParty/de:Party/de:Contact/cbc:Name
        
        public string ContactName { get; set; }


        
        ///root/de:AccountingCustomerParty/de:Party/de:Contact/cbc:Telephone
        
        public string ContactTelephone { get; set; }

        
        ///root/de:AccountingCustomerParty/de:Party/de:Contact/cbc:-Telefax
        
        public string ContactTelefax { get; set; }

        
        ///root/de:AccountingCustomerParty/de:Party/de:Contact/cbc:ElectronicMail
        
        //public ElectronicMailType ElectronicMail { get; set; }
        public string ContactElectronicMail { get; set; }

        
        ///root/de:AccountingCustomerParty/de:Party/de:Contact/cbc:Note
        
        public string ContactNote { get; set; }

    }
}
