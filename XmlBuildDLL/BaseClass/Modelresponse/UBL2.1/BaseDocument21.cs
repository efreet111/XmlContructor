using System;
using System.Collections.Generic;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.DocumentClass.UBL2._1
{
    public class BillingDocument21Object
    {
        
        /// Nodo para identificar si es Invoice, DebitNote o CreditNote
        
        public String TypeDocument { get; set; }
        public string JsonData { get; set; }

        public DianExtensions DianExtensions { get; set; }

        public String UBLVersionID { get; set; }

        public String CustomizationID { get; set; }

        public String ProfileID { get; set; }

        public String AttachedDocumentProfileID { get; set; }
        public String AttachedDocumentUBLVersionID { get; set; }

        public String ProfileExecutionID { get; set; }

        public String ID { get; set; }

        public String UUID { get; set; }

        public String UUIDSchemeName { get; set; }

        public String UUIDSchemeID { get; set; }

        public String UUIDRaw { get; set; } //No se usa en el XML

        public DateTime IssueDate { get; set; }

        public DateTime IssueTime { get; set; }

        public String InvoiceTypeCode { get; set; }

        public List<String> Note { get; set; }

        public List<ExtensiblesNote> Extensible { get; set; }

        public string tipoSector { get; set; }

        public List<ExtensiblesNote> extras { get; set; }

        public DateTime? TaxPointDate { get; set; } //Ya no está en el Anexo Técnico, pero sí en los ejemplos

        public DateTime? DueDate { get; set; }

        public String DocumentCurrencyCode { get; set; }

        public int LineCountNumeric { get; set; }

        public InvoicePeriod InvoicePeriod { get; set; }

        public List<AdditionalDocumentReference> AdditionalDocumentReference { get; set; }

        public AcountingSupplierParty AcountingSupplierParty { get; set; }

        public AccountingCustomerParty AccountingCustomerParty { get; set; }

        public TaxRepresentativeParty TaxRepresentativeParty { get; set; }

        public Delivery Delivery { get; set; }

        public DeliveryTerms DeliveryTerms { get; set; }

        public List<PaymentMeans> PaymentMeans { get; set; }

        public PaymentTerms PaymentTerms { get; set; }

        public List<PrepaidPayment> PrepaidPayment { get; set; }

        public List<AllowanceCharge> AllowanceCharge { get; set; }

        public PaymentExchangeRate PaymentExchangeRate { get; set; }

        public PaymentAlternativeExchangeRate PaymentAlternativeExchangeRate { get; set; }

        public List<TaxTotal> TaxTotal { get; set; }

        public List<WithholdingTaxTotal> WithholdingTaxTotal { get; set; }

        public LegalMonetaryTotal LegalMonetaryTotal { get; set; }

        public List<InvoiceLine> InvoiceLine { get; set; }

        public List<DiscrepancyResponse> DiscrepancyResponse { get; set; }

        public List<OrderReference> OrderReference { get; set; }

        public List<BillingReference> BillingReference { get; set; }

        public List<ReceiptDocumentReference> ReceiptDocumentReference { get; set; }

        public List<DespatchDocumentReference> DespatchDocumentReference { get; set; }

        public InteroperabilidadPT InteroperabilidadPT { get; set; }

        public BuyersCustomerParty BuyersCustomerParty { get; set; }

        public string ValorPorDefectoRedondeoAplicado { get; set; }
    }
}