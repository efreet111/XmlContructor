using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.AccountingCustomerParty
{
    public class PartyPersonIdentityDocumentRef
    {
        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:IdentityDocumentReference/cbc:ID
        public int ID { get; set; }

        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:IdentityDocumentReference/cbc:ID@schemeName
        public string schemeName { get; set; }

        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:IdentityDocumentReference/de:IssuerParty/de:PartyName/cbc:Name
        public string Name { get; set; }

        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:IdentityDocumentReference/de:IssuerParty/de:PostalAddress/cbc:Country
        public string Country { get; set; }
    }
}
