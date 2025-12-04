using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.AccountingCustomerParty
{
    public class ResidenceAddress
    {
        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:ResidenceAddress/cbc:ID
        public int ID { get; set; }

        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:ResidenceAddress/cbc:ID@schemeName
        public string schemeName { get; set; }

        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:ResidenceAddress/cbc:CityName
        public string CityName { get; set; }

        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:ResidenceAddress/de:AddressLine/cbc:Line
        public string Line { get; set; }

        ///root/de:AccountingCustomerParty/de:Party/de:Person/de:ResidenceAddress/cbc:Country
        public string Country { get; set; }
    }
}
