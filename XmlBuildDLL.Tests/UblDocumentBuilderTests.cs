using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.BaseClass.Modelresponse.UBL2._1; // for TaxSubtotal
using XmlBuildDLL.DocumentClass.UBL2._1;
using XmlBuildDLL.Transversal;
using System.Xml.Linq;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic; // NamespaceProvider
using System.Linq;
using System.Text; // for Base64 decoding

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
                    PartyName = "ON Plus",
                    LegalEntity = new PartyLegalEntity
                    {
                        CompanySchemeAgencyID = "195",
                        CompanyID = "900390126",
                        CompanySchemeAgencyName = "DIAN",
                        CompanySchemeID = "6",
                        CompanySchemeName = "31",
                        CorporateRegistrationID = "SETP",
                        CorporateRegistrationName = "ON Plus",
                        CorporateRegistrationTypeCode = "000001",
                        RegistrationName = "ON Plus"
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
                        LineExtensionAmountCurrencyID = "COP",
                        Quantity = 1m,
                        Quantity_unitCode = "KGM",
                        FreeOfChargeIndicator = false,
                        AlternativeConditionPrice = new List<AlternativeConditionPrice>
                        {
                            new AlternativeConditionPrice
                            {
                                PriceAmount = 950m,
                                PriceAmount_currencyID = "COP",
                                PriceTypeCode = "01"
                            }
                        },
                        AllowanceCharge = new List<AllowanceCharge>
                        {
                            new AllowanceCharge
                            {
                                ID = 1,
                                ChargeIndicator = false,
                                Amount = 50m,
                                Amount_CurrencyID = "COP"
                            }
                        },
                        WithholdingTaxTotal = new List<WithholdingTaxTotal>
                        {
                            new WithholdingTaxTotal
                            {
                                TaxAmount = 10m,
                                TaxAmount_currencyID = "COP",
                                TaxSubtotal = new List<TaxSubtotal>
                                {
                                    new TaxSubtotal
                                    {
                                        TaxableAmount = 100m,
                                        TaxableAmount_currencyID = "COP",
                                        TaxAmount = 10m,
                                        TaxAmount_currencyID = "COP",
                                        Percent = 10m,
                                        TaxScheme_ID = "06",
                                        TaxScheme_Name = "ReteFuente"
                                    }
                                }
                            }
                        },
                        InvoicePeriod = new List<InvoicePeriod>
                        {
                            new InvoicePeriod
                            {
                                StartDate = System.DateTime.Parse("2024-01-01"),
                                EndDate = System.DateTime.Parse("2024-01-31")
                            }
                        }
                    },
                    new InvoiceLine
                    {
                        ID = 2,
                        Quantity = 2m,
                        Quantity_unitCode = "EA",
                        PriceAmount = 500m,
                        PriceAmount_currencyID = "COP",
                        LineExtensionAmount = 1000m,
                        LineExtensionAmountCurrencyID = "COP",
                        FreeOfChargeIndicator = true
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
                    LineExtensionAmount = 2000m,
                    LineExtensionAmount_currencyID = "COP",
                    TaxExclusiveAmount = 2000m,
                    TaxExclusiveAmount_currencyID = "COP",
                    TaxInclusiveAmount = 2190m,
                    TaxInclusiveAmount_currencyID = "COP",
                    PayableAmount = 2180m,
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
        public void Build_FullInvoice_ContainsExpectedLineNodes()
        {
            var builder = new UblDocumentBuilder();
            int dec = 2;
            var nombres = new List<string>();
            var data = GetFilledBillingDocument(HelpersConstantes.TipoDocumento.FactExportacion);

            var result = builder.Build(data, ref dec, nombres);
            Assert.IsNotNull(result.XmlFile);

            // decode base64 to XML string
            var xmlString = Encoding.UTF8.GetString(System.Convert.FromBase64String(result.XmlFile));

            // parse XML
            var xdoc = XDocument.Parse(xmlString);
            var nsCac = NamespaceProvider.Cac;
            var nsCbc = NamespaceProvider.Cbc;

            var lines = xdoc.Root?.Elements(nsCac + "InvoiceLine").ToList();
            Assert.IsNotNull(lines);

            // Check first line FreeOfChargeIndicator false and PricingReference present
            var first = lines.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.AreEqual("false", first.Element(nsCbc + "FreeOfChargeIndicator")?.Value);
            var pricingRef = first.Element(nsCac + "PricingReference");
            Assert.IsNotNull(pricingRef);
            Assert.IsTrue(pricingRef.HasElements);

            // Check WithholdingTaxTotal exists
            var wht = first.Element(nsCac + "WithholdingTaxTotal");
            Assert.IsNotNull(wht);
            Assert.IsNotNull(wht.Element(nsCbc + "TaxAmount"));

            // Second line free of charge true
            var secondLine = lines.Skip(1).FirstOrDefault();
            Assert.IsNotNull(secondLine);
            Assert.AreEqual("true", secondLine.Element(nsCbc + "FreeOfChargeIndicator")?.Value);
        }

        [TestMethod]
        public void Build_FinalXml_ContainsLegalMonetaryTotal()
        {
            var builder = new UblDocumentBuilder();
            int dec = 2;
            var nombres = new List<string>();
            var data = GetFilledBillingDocument(HelpersConstantes.TipoDocumento.Fact);

            var result = builder.Build(data, ref dec, nombres);
            Assert.IsNotNull(result.XmlFile);

            // decode base64 to XML string
            var xmlString = Encoding.UTF8.GetString(System.Convert.FromBase64String(result.XmlFile));

            var xdoc = XDocument.Parse(xmlString);
            var nsCac = NamespaceProvider.Cac;
            var nsCbc = NamespaceProvider.Cbc;

            var legal = xdoc.Root?.Element(nsCac + "LegalMonetaryTotal");
            Assert.IsNotNull(legal);
            Assert.AreEqual(2000m.ToString("F2"), legal.Element(nsCbc + "LineExtensionAmount")?.Value);
            Assert.AreEqual("COP", legal.Element(nsCbc + "LineExtensionAmount")?.Attribute("currencyID")?.Value);
            Assert.AreEqual(2000m.ToString("F2"), legal.Element(nsCbc + "TaxExclusiveAmount")?.Value);
            Assert.AreEqual("COP", legal.Element(nsCbc + "TaxExclusiveAmount")?.Attribute("currencyID")?.Value);
            Assert.AreEqual(2190m.ToString("F2"), legal.Element(nsCbc + "TaxInclusiveAmount")?.Value);
            Assert.AreEqual("COP", legal.Element(nsCbc + "TaxInclusiveAmount")?.Attribute("currencyID")?.Value);
            Assert.AreEqual(2180m.ToString("F2"), legal.Element(nsCbc + "PayableAmount")?.Value);
            Assert.AreEqual("COP", legal.Element(nsCbc + "PayableAmount")?.Attribute("currencyID")?.Value);
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
