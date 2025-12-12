using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.DocumentClass.UBL2._1;
using XmlBuildDLL.BaseClass.ComonXmlComponent;

namespace XmlBuildDLL.Tests
{
    [TestClass]
    public class BuilderXmlInvoiceDominioTests
    {
        private AcountingSupplierParty GetAccountingSupplierParty_Case1()
        {
            // Basado en el XML proporcionado
            var address = new Address
            {
                ID = "11001",
                CityName = "BOGOTÁ, D.C.",
                PostalZone = "110931",
                CountrySubentity = "Bogotá",
                CountrySubentityCode = "11",
                AddressLine = "Calle 100",
                CountryIdentificationCode = "CO"
            };

            return new AcountingSupplierParty
            {
                AdditionalAccountID = 1,
                AdditionalAccountID_SchemeAgencyID = "195",
                AdditionalAccountID_SchemeID = "6",
                AdditionalAccountID_SchemeName = "31",
                IndustryClassificationCode = "0111",
                PhysicalLocation = address,
                TaxScheme = new PartyTaxScheme
                {
                    RegistrationName = "Wilson Diaz",
                    CompanyID = "900390126",
                    SchemeAgencyID = "195",
                    SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                    SchemeID = "6",
                    SchemeName = "31",
                    TaxLevelCode = "O-15",
                    TaxLevelCodeListName = "No aplica",
                    RegistrationAddress = address,
                    TaxSchemeID = "ZZ",
                    TaxSchemeName = "No aplica"
                },
                LegalEntity = new PartyLegalEntity
                {
                    RegistrationName = "Wilson Diaz",
                    CompanyID = "900390126",
                    CompanySchemeAgencyID = "195",
                    CompanySchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                    CompanySchemeID = "6",
                    CompanySchemeName = "31",
                    CorporateRegistrationID = "FEVP"
                }
            };
        }

        private AccountingCustomerParty GetAccountingCustomerParty_Case1()
        {
            return new AccountingCustomerParty
            {
                AdditionalAccountID_SchemeAgencyID = "195",
                AdditionalAccountID_SchemeID = "SchemeID",
                AdditionalAccountID_SchemeName = "Name_SchemeName",
                IndustryClassificationCode = "Litio prueba",
                AdditionalAccountID = 2,
                PartyIdentificationID = "222222222222",
                PartyIdentificationID_SchemeName = "13",
                PartyIdentificationID_SchemeID = "PartyIdentificationID_SchemeID",
                PartyName = "consumidor final",
                TaxScheme = new PartyTaxScheme
                {
                    RegistrationName = "consumidor final",
                    CompanyID = "222222222222",
                    SchemeAgencyID = "195",
                    SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                    SchemeID = string.Empty,
                    SchemeName = "13",
                    TaxLevelCode = "R-99-PN",
                    TaxLevelCodeListName = "No aplica",
                    TaxSchemeID = "ZZ",
                    TaxSchemeName = "No aplica"
                }
                
            };
        }

        [TestMethod]
        public void BuildXML_WithAccountingSupplierAndCustomerParty_Case1_ReturnsBase64String()
        {
            // Arrange
            var billingObj = new BillingDocument21Object
            {
                TypeDocument = "Invoice",
                UBLVersionID = "2.1",
                CustomizationID = "05",
                ProfileID = "DIAN 2.1",
                ProfileExecutionID = "2",
                ID = "INV-0001",
                UUID = "1234567890abcdef",
                UUIDSchemeName = "CUFE-SHA384",
                UUIDSchemeID = "2",
                IssueDate = DateTime.Now,
                IssueTime = DateTime.Now,
                InvoiceTypeCode = "01",
                DocumentCurrencyCode = "COP",
                LineCountNumeric = 1,
                AcountingSupplierParty = GetAccountingSupplierParty_Case1(),
                AccountingCustomerParty = GetAccountingCustomerParty_Case1(),
                BuyersCustomerParty = null,
                TaxRepresentativeParty = null,
                Delivery = null,
                Extensible = new List<ExtensiblesNote> { new ExtensiblesNote { Type = "Text", Value = "Nota de prueba" } },
                OrderReference = new List<OrderReference> { new OrderReference { ID = "ORD-001" } },
                BillingReference = new List<BillingReference> { new BillingReference { BillingReferenceLineID = "BILL-001" } },
                DespatchDocumentReference = new List<DespatchDocumentReference> { new DespatchDocumentReference { ID = "DESP-001" } },
                ReceiptDocumentReference = new List<ReceiptDocumentReference> { new ReceiptDocumentReference { ID = "REC-001" } },
                AdditionalDocumentReference = new List<AdditionalDocumentReference> { new AdditionalDocumentReference { ID = "ADD-001" } },
                InvoicePeriod = null
            };
            int cantidadDecimales = 2;
            var nombres = new List<string> { "Nombre1" };
            var builder = new BuilderXmlInvoiceDominio();

            // Act
            var result = builder.BuildXML(billingObj, ref cantidadDecimales, nombres);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(IsBase64String(result));
        }

        private bool IsBase64String(string base64)
        {
            if (string.IsNullOrEmpty(base64)) return false;
            base64 = base64.Trim();
            return (base64.Length % 4 == 0) && Regex.IsMatch(base64, @"^[A-Za-z0-9+/]*={0,3}$", RegexOptions.None);
        }
    }
}
