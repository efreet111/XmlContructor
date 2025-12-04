using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class Person
    {
        public String ID { get; set; }

        public String FirstName { get; set; }

        public String FamilyName { get; set; }

        public String Title { get; set; }

        public String MiddleName { get; set; }

        public String OtherName { get; set; }

        public String NameSuffix { get; set; }

        public String JobTitle { get; set; }

        public String NationalityID { get; set; }

        public String GenderCode { get; set; }

        public String BirthDate { get; set; }

        public String BirthplaceName { get; set; }

        public String OrganizationDepartment { get; set; }

        public Contact Contact { get; set; }

        public FinancialAccount FinancialAccount { get; set; }

        public DocumentReference IdentityDocumentReference { get; set; }

        public Address ResidenceAddress { get; set; }
    }
}
