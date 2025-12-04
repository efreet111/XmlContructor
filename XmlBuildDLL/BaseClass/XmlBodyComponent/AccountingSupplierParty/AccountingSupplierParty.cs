using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.AccountingSupplierParty
{
    public class AccountingSupplierParty
    {
        public int AdditionalAccountID { get; set; }

        public String PartyIdentificationID { get; set; }

        public String PartyIdentificationID_schemeAgencyID { get; set; }

        public String PartyIdentificationID_schemeAgencyName { get; set; }

        public String PartyIdentificationID_schemeID { get; set; }

        public String PartyName { get; set; }

        public Address Address { get; set; }

        public String TaxLevelCode { get; set; }

        public String RegistrationName { get; set; }

        public String Telephone { get; set; }

        public String FirstName { get; set; }

        public String FamilyName { get; set; }

        public String MiddleName { get; set; }

        public String PartyContactName { get; set; }

        public String PartyContactTelefax { get; set; }

        public String PartyContactNote { get; set; }
    }
}
