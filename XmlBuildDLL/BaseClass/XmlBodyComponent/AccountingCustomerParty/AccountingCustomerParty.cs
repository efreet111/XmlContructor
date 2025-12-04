using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.AccountingCustomerParty
{
    public class AccountingCustomerParty
    {
        public int AdditionalAccountID { get; set; }

        public String PartyIdentificationID { get; set; }

        public String PartyIdentificationIDSchemeAgencyID { get; set; }

        public String PartyIdentificationIDSchemeAgencyName { get; set; }

        public String PartyIdentificationIDSchemeID { get; set; }

        public String PartyName { get; set; }

        public Address Address { get; set; }

        public String TaxLevelCode { get; set; }

        public String RegistrationName { get; set; }

        public String Telephone { get; set; }

        public String FirstName { get; set; }

        public String FamilyName { get; set; }

        public String MiddleName { get; set; }

        public String DeliveryContact { get; set; }

        public PartyPerson PartyPerson { get; set; }

        public PartyPersonIdentityDocumentRef PartyPersonIdentityDocumentReference { get; set; }

        public ResidenceAddress ResidenceAddress { get; set; }
    }
}
