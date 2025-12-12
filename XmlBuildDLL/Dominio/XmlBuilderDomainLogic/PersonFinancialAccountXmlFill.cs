using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class PersonFinancialAccountXmlFill
    {
        internal static XElement FillPersonFinancialAccount(FinancialAccount financial)
        {
            XElement nodeFinanctial = new XElement(NamespaceProvider.Cac + "FinancialAccount");

            if (!String.IsNullOrEmpty(financial.ID.Trim()))
                nodeFinanctial.Add(new XElement(NamespaceProvider.Cbc + "ID", financial.ID.Trim()));

            if (!String.IsNullOrEmpty(financial.Name.Trim()))
                nodeFinanctial.Add(new XElement(NamespaceProvider.Cbc + "Name", financial.Name.Trim()));

            if (!String.IsNullOrEmpty(financial.AliasName.Trim()))
                nodeFinanctial.Add(new XElement(NamespaceProvider.Cbc + "AliasName", financial.AliasName.Trim()));

            if (!String.IsNullOrEmpty(financial.AccountTypeCode.Trim()))
                nodeFinanctial.Add(new XElement(NamespaceProvider.Cbc + "AccountTypeCode", financial.AccountTypeCode.Trim()));

            if (!String.IsNullOrEmpty(financial.AccountFormatCode.Trim()))
                nodeFinanctial.Add(new XElement(NamespaceProvider.Cbc + "AccountFormatCode", financial.AccountFormatCode.Trim()));

            if (!String.IsNullOrEmpty(financial.CurrencyCode.Trim()))
                nodeFinanctial.Add(new XElement(NamespaceProvider.Cbc + "CurrencyCode", financial.CurrencyCode.Trim()));

            foreach (string note in financial.PaymentNote)
            {
                if (!String.IsNullOrEmpty(note.Trim()))
                    nodeFinanctial.Add(new XElement(NamespaceProvider.Cbc + "PaymentNote", note.Trim()));
            }

            XElement intitutionbranch = new XElement(NamespaceProvider.Cac + "FinancialInstitutionBranch");
            if (!String.IsNullOrEmpty(financial.FinancialInstitutionBranch_ID.Trim()))
                intitutionbranch.Add(new XElement(NamespaceProvider.Cbc + "ID", financial.FinancialInstitutionBranch_ID.Trim()));

            if (!String.IsNullOrEmpty(financial.FinancialInstitutionBranch_Name.Trim()))
                intitutionbranch.Add(new XElement(NamespaceProvider.Cbc + "Name", financial.FinancialInstitutionBranch_Name.Trim()));

            if (financial.FinancialInstitutionBranch_Address != null)
            {     // llamar Adrress
                XElement address = AddressXmlFill.FillAddress(financial.FinancialInstitutionBranch_Address, "Address");
                if (address.HasElements)
                    intitutionbranch.Add(address);
            }

            XElement intitution = new XElement(NamespaceProvider.Cac + "FinancialInstitution");

            if (!String.IsNullOrEmpty(financial.FinancialInstitution_ID.Trim()))
                intitution.Add(new XElement(NamespaceProvider.Cbc + "ID", financial.FinancialInstitution_ID.Trim()));

            if (!String.IsNullOrEmpty(financial.FinancialInstitution_Name.Trim()))
                intitution.Add(new XElement(NamespaceProvider.Cbc + "Name", financial.FinancialInstitution_Name.Trim()));

            if (financial.FinancialInstitution_Address != null)
            {
                XElement addressb = AddressXmlFill.FillAddress(financial.FinancialInstitution_Address, "Address");
                if (addressb.HasElements)
                    intitution.Add(addressb);
            }

            XElement country = new XElement(NamespaceProvider.Cac + "Country");
            if (!String.IsNullOrEmpty(financial.Country_IdentificationCode.Trim()))
                country.Add(new XElement(NamespaceProvider.Cbc + "IdentificationCode", financial.Country_IdentificationCode.Trim()));

            if (!String.IsNullOrEmpty(financial.Country_Name.Trim()))
                country.Add(new XElement(NamespaceProvider.Cbc + "Name", financial.Country_Name.Trim()));

            if (country.HasElements)
                nodeFinanctial.Add(country);

            return nodeFinanctial;

        }

    }
}
