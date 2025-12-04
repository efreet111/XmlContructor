using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class TaxRepresentativeParty
    {
        
        /// root/de:AccountingSupplierParty/cbc:AdditionalAccountID
        
        public String PartyIdentification { get; set; }

        public String PartyIdentification_SchemeID { get; set; }

        public String PartyIdentification_SchemeName { get; set; }

        
        /// root/de:AccountingSupplierParty/de:Party/cac:PartyName/cbc:Name
        
        public String PartyName { get; set; }

        public String RegistrationName { get; set; }


        
        ///root/de:TaxRepresentativeParty/de:Party/de:PartyName/cbc:Name
        
        public String TaxRepresentativePartyPartyName { get; set; }


        
        ///root/de:TaxRepresentativeParty/de:PartyLegalEntity/cbc:RegistrationName
        
        public String TaxRepresentativePartyRegisName { get; set; }


        
        ///root/de:TaxRepresentativeParty/de:PartyIdentification/cbc:ID
        
        public String TaxRepresentativePartyIdentificationID { get; set; }

        
        ///root/de:TaxRepresentativeParty/de:PartyIdentification/cbc:ID@schemeID
        
        public String TaxRepresentativePartyIdentificationschemeID { get; set; }

        
        ///root/de:TaxRepresentativeParty/de:PartyIdentification/cbc:ID@schemeName
        
        public String TaxRepresentativePartyIdentificationschemeName { get; set; }

        
        ///root/de:TaxRepresentativeParty/de:PartyIdentification/cac:Address
        
        public String TaxRepresentativePartyLocationAddress { get; set; }


        
        ///root/de:TaxRepresentativeParty/de:Contact/cac:Name
        
        public String TaxRepresentativePartyContactName { get; set; }

        
        ///root/de:TaxRepresentativeParty/de:Contact/cac:Telefax
        
        public String TaxRepresentativePartyContactTelefax { get; set; }

        
        ///root/de:TaxRepresentativeParty/de:Contact/cac:Telephone
        
        public String TaxRepresentativePartyContactTelephone { get; set; }

        
        ///root/de:TaxRepresentativeParty/de:Contact/cac:ElectronicMail
        
        public String TaxRepresentativePartyContactElectronicMail { get; set; }

        
        ///root/de:TaxRepresentativeParty/de:Contact/cac:Note
        
        public String TaxRepresentativePartyContactNote { get; set; }


                 
        ///root/de:AccountingSupplierParty/de:PhysicalLocation/de:Address
        
        public Address PhysicalLocation { get; set; }
        
        ///root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme
        
        public PartyTaxScheme TaxScheme { get; set; }



        public AcountingSupplierPartyContact Contact { get; set; }
    }
}
