using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.DocumentClass.UBL2._1;
using XmlBuildDLL.Transversal;

namespace XmlBuildDLL.Tests
{
    [TestClass]
    public class UblDocumentBuilderTests
    {
        private BillingDocument21Object GetDefaultBillingDocument(string invoiceTypeCode)
        {
            return new BillingDocument21Object
            {
                InvoiceTypeCode = invoiceTypeCode
                // Agregar más propiedades si es necesario para el test
            };
        }

        private BillingDocument21Object GetFilledBillingDocument(string invoiceTypeCode)
        {
            return new BillingDocument21Object
            {
                InvoiceTypeCode = invoiceTypeCode,
                TypeDocument = "Invoice",
                ID = "SETP990000001",
                IssueDate = System.DateTime.Now,
                IssueTime = System.DateTime.Now,
                UBLVersionID = "UBL 2.1",
                CustomizationID = "05",
                ProfileID = "DIAN 2.1",
                ProfileExecutionID = "2",
                UUIDSchemeName = "CUFE-SHA384",
                UUIDSchemeID = "2",
                UUID = "1234567890abcdef",
                DocumentCurrencyCode = "COP",
                LineCountNumeric = 1,
                DianExtensions = new DianExtensions
                {
                    Prefix = "SETP",
                    ProviderID = "900390126",
                    From = "990000000",
                    To = "995000000",
                    StartDate = System.DateTime.Parse("2019-01-19"),
                    EndDate = System.DateTime.Parse("2030-01-19"),
                    InvoiceAuthorization = "18760000001",
                    InvoiceSourceIdentificationCode = "CO",
                    InvoiceSourceListAgencyID = "6",
                    InvoiceSourceListAgencyName = "United Nations Economic Commission for Europe",
                    InvoiceSourceListSchemeURI = "urn:oasis:names:specification:ubl:codelist:gc:CountryIdentificationCode-2.1",
                    SoftwareID = "82d21092-144e-4b66-b720-6cdf9f661767",
                    SoftwareSecurityCode = "SECURITYCODE",
                    AuthorizationProviderID = "800197268",
                    AuthorizationProviderIDSchemeID = "4",
                    AuthorizationProviderIDSchemeName = "31",
                    ProviderID_SchemeID = "6",
                    ProviderID_SchemeName = "31"
                },
                AcountingSupplierParty = new AcountingSupplierParty
                {
                    AdditionalAccountID = 1,
                    PartyName = "The Factory HKA Colombia",
                    LegalEntity = new PartyLegalEntity
                    {
                        CompanySchemeAgencyID = "195",
                        CompanyID = "900390126",
                        CompanySchemeAgencyName = "DIAN",
                        CompanySchemeID = "6",
                        CompanySchemeName = "31",
                        CorporateRegistrationID = "SETP",
                        CorporateRegistrationName = "The Factory HKA Colombia",
                        CorporateRegistrationTypeCode = "000001",
                        RegistrationName = "The Factory HKA Colombia"
                    }
                },
                AccountingCustomerParty = new AccountingCustomerParty
                {
                    AdditionalAccountID = 1,
                    PartyName = "Servicios Web",
                    LegalEntity = new PartyLegalEntity
                    {
                        CompanySchemeAgencyID = "195",
                        CompanyID = "900390126",
                        CompanySchemeAgencyName = "DIAN",
                        CompanySchemeID = "6",
                        CompanySchemeName = "31",
                        CorporateRegistrationID = "BC",
                        CorporateRegistrationName = "12345",
                        CorporateRegistrationTypeCode = "000001",
                        RegistrationName = "Adquiriente DE EJEMPLO"
                    }
                },
                InvoiceLine = new List<InvoiceLine>
                {
                    new InvoiceLine
                    {
                        ID = 1,
                        BaseQuantity = 1m,
                        BaseQuantity_unitCode = "KGM",
                        PriceAmount = 1000m,
                        PriceAmount_currencyID = "COP",
                        DescripcionItem = "Producto o Servicio 1",
                        LineExtensionAmount = 1000m,
                        LineExtensionAmount_currencyID = "COP",
                        Quantity = 1m,
                        Quantity_unitCode = "KGM"
                    }
                },
                TaxTotal = new List<TaxTotal>
                {
                    new TaxTotal
                    {
                        TaxAmount = 190m,
                        TaxAmount_currencyID = "COP",
                        TaxSubtotal = new List<TaxSubtotal>
                        {
                            new TaxSubtotal
                            {
                                Percent = 19m,
                                TaxableAmount = 1000m,
                                TaxableAmount_currencyID = "COP",
                                TaxAmount = 190m,
                                TaxAmount_currencyID = "COP",
                                TaxScheme_ID = "01",
                                TaxScheme_Name = "IVA"
                            }
                        }
                    }
                },
                LegalMonetaryTotal = new LegalMonetaryTotal
                {
                    LineExtensionAmount = 1000m,
                    LineExtensionAmount_currencyID = "COP",
                    TaxExclusiveAmount = 1000m,
                    TaxExclusiveAmount_currencyID = "COP",
                    TaxInclusiveAmount = 1190m,
                    TaxInclusiveAmount_currencyID = "COP",
                    PayableAmount = 1190m,
                    PayableAmount_currencyID = "COP"
                }
            };
        }

        [TestMethod]
        public void Build_FactType_ReturnsBuildXmlResponse()
        {
            // Arrange
            var builder = new UblDocumentBuilder();
            int decimales = 2;
            var nombres = new List<string>();
            // Usar el método que retorna el objeto lleno
            var data = GetFilledBillingDocument(HelpersConstantes.TipoDocumento.Fact);

            // Act
            var result = builder.Build(data, ref decimales, nombres);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.XmlFile);
        }


        [TestMethod]
        public void Build_FactContingenciaEmisorType_ReturnsBuildXmlResponse()
        {
            var builder = new UblDocumentBuilder();
            int decimales = 2;
            var nombres = new List<string>();
            var data = GetFilledBillingDocument(HelpersConstantes.TipoDocumento.FactContingenciaEmisor);

            var result = builder.Build(data, ref decimales, nombres);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.XmlFile);
        }

      
    }
}
