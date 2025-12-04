using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.AccountingCustomerParty
{
    public class PartyPerson
    {
        ///root/de:AccountingCustomerParty/de:Party/de:Person/cbc:ID
        public int ID { get; set; }

        ///root/de:AccountingCustomerParty/de:Party/de:Person/cbc:ID@schemeName
        public string schemeName { get; set; }

        ///root/de:AccountingCustomerParty/de:Party/de:Person/cbc:FirstName
        public string FirstName { get; set; }

        ///root/de:AccountingCustomerParty/de:Party/de:Person/cbc:FamilyName
        public string FamilyName { get; set; }

        public List<PartyPersonIdentityDocumentRef> IdentityDocumentReference { get; set; }

        public ResidenceAddress ResidenceAddress { get; set; }
    }
}
