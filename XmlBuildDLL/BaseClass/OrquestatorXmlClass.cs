using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlBuildDLL.BaseClass.ComonXmlComponent;
using XmlBuildDLL.BaseClass.Dianheaders;
using XmlBuildDLL.BaseClass.XmlBodyComponent;

namespace XmlBuildDLL.BaseClass
{
    public class OrquestatorXmlClass
    {
        public DianExtensionsHeader DianExtensions { get; set; }
        public Software Software { get; set; }
        public List<ExtensionsFree> ExtensionFields { get; set; }
        public OrderReference Order_Reference { get; set; }
        public BodyXml BodyXml { get; set; }

        public AccountingSupplierParty.AccountingSupplierParty AccountingSupplierParty { get; set; }
        public AccountingCustomerParty.AccountingCustomerParty AccountingCustomerParty { get; set; }
        public DiscrepancyResponse DiscrepancyResponse { get; set; }
        public BillingReference BillingReference { get; set; }
        public List<ReceiptDocumentRef> ReceiptDocumentReferences { get; set; }
        public AdditionalDocumentRef AdditionalDocumentReference { get; set; }// ext
        public PaymentTerms PaymentTerms { get; set; }
        public List<TaxTotal> TaxTotal { get; set; }

        public ComonXmlComponent.LegalMonetaryTotal LegalMonetaryTotal { get; set; }

        public List<Line> Line { get; set; }

        //public List<DocumentBuildCO.ClassXSD.ApplicationResponseType> ApplicationsResponse { get; set; }
    }
}
