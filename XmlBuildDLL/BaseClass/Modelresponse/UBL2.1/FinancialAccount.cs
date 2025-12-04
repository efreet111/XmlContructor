using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class FinancialAccount
    {
        public String ID { get; set; }

        public String Name { get; set; }

        public String AliasName { get; set; }

        public String AccountTypeCode { get; set; }

        public String AccountFormatCode { get; set; }

        public String CurrencyCode { get; set; }

        public List<String> PaymentNote { get; set; }

        public String FinancialInstitutionBranch_ID { get; set; }

        public String FinancialInstitutionBranch_Name { get; set; }

        public Address FinancialInstitutionBranch_Address { get; set; }

        public String FinancialInstitution_ID { get; set; }

        public String FinancialInstitution_Name { get; set; }

        public Address FinancialInstitution_Address {get; set;}

        
        /// ../de:Address/cac:Country/cbc:IdentificationCode
        
        /// 
        public String Country_IdentificationCode { get; set; }

        
        /// ../de:Address/cac:Country/cbc:Name
        
        /// 
        public String Country_Name { get; set; }

        
        /// ../de:Address/cac:Country/cbc:Name/@languageID
        
        /// 
        public String Country_LanguageID { get; set; } //@languageID
    }
}
