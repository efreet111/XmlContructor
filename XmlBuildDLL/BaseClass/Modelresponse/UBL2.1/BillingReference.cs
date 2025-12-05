using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class BillingReference
    {
        
        ///de:root/de:BillingReference/section/cbc:ID
        
        public String CreditNoteID { get; set; }

        
        ///de:root/de:BillingReference/section/cbc:ID@schemeID  
        
        public String CreditNoteID_schemeID { get; set; }

        
        ///de:root/de:BillingReference/section/cbc:ID@schemeName  
        
        public String CreditNoteID_schemeName { get; set; }

        
        ///de:root/de:BillingReference/section/cbc:ID@schemeAgencyID  
        
        public String CreditNoteID_schemeAgencyID { get; set; }

        
        ///de:root/de:BillingReference/section/cbc:ID@schemeVersionID  
        
        public String CreditNoteID_schemeVersionID { get; set; }

        
        ///de:root/de:BillingReference/section/cbc:UUID
        
        public String CreditNoteUUID { get; set; }

        
        ///de:root/de:BillingReference/section/cbc:UUID@schemeName
        
        public String CreditNoteschemeName { get; set; }


        ///de:root/de:BillingReference/section/cbc:UUID@schemeName
        
        public String CreditNoteUUIDschemeName { get; set; }


        ///de:root/de:BillingReference/section/cbc:IssueDate
        
        public DateTime? CreditNoteIssueDate { get; set; }

 
        ///de:root/de:BillingReference/section/cbc:DocumentTypeCode
        
        public String CreditNotesDocumentTypeCode { get; set; }


        ///de:root/de:BillingReference/section/cbc:DocumentTypeCode@listURI
        
        public String CreditNotesDocumentTypeCode_listURI { get; set; }


        ///de:root/de:BillingReference/section/cbc:DocumentType 
        
        public String CreditNotesDocumentType { get; set; }


        
        ///de:root/de:BillingReference/de:DebitNoteDocumentReference/cbc:ID
        
        public String DebitNoteID { get; set; }

        
        ///de:root/de:BillingReference/de:DebitNoteDocumentReference/cbc:UUID
        
        public String DebitNoteUUID { get; set; }


        ///de:root/de:BillingReference/de:DebitNoteDocumentReference/cbc:UUID@schemeName
        
        public String DebitNoteschemeName { get; set; }


        ///de:root/de:BillingReference/de:DebitNoteDocumentReference/cbc:IssueDate
        
        public DateTime? DebitNoteIssueDate { get; set; }

        
        ///de:root/de:BillingReference/de:DebitNoteDocumentReference/cbc:ID
        
        public String InvoiceID { get; set; }

        
        ///de:root/de:BillingReference/de:DebitNoteDocumentReference/cbc:UUID
        
        public String InvoiceUUID { get; set; }


        ///de:root/de:BillingReference/de:DebitNoteDocumentReference/cbc:UUID@schemeName
        
        public String InvoiceschemeName { get; set; }


        ///de:root/de:BillingReference/de:DebitNoteDocumentReference/cbc:IssueDate
        
        public DateTime? InvoiceIssueDate { get; set; }

        
        ///de:root/de:BillingReference/de:BillingReferenceLine/cbc:ID@schemeID  
        
        public String BillingReferenceLineID { get; set; }

        
        ///de:root/de:BillingReference/de:BillingReferenceLine/cbc:ID@schemeID  
        
        public String BillingReferenceLineID_schemeID { get; set; }

        
        ///de:root/de:BillingReference/de:BillingReferenceLine/section/cbc:ID@schemeName  
        
        public String BillingReferenceLineID_schemeName { get; set; }

        
        ///de:root/de:BillingReference/de:BillingReferenceLine/cbc:ID@schemeAgencyID  
        
        public String BillingReferenceLineID_schemeAgencyID { get; set; }

        
        ///de:root/de:BillingReference/de:BillingReferenceLine/cbc:ID@schemeAgencyName  
        
        public String BillingReferenceLineID_schemeAgencyName { get; set; }

        
        ///de:root/de:BillingReference/de:BillingReferenceLine/cbc:ID@schemeVersionID  
        
        public String BillingReferenceLineID_schemeVersionID { get; set; }

        
        ///de:root/de:BillingReference/de:BillingReferenceLine/cbc:Amount
        
        public string BillingReferenceLine_Amount { get; set; }

        
        ///de:root/de:BillingReference/de:BillingReferenceLine/cbc:Amount@currencyID
        
        public string BillingReferenceLine_currencyID { get; set; }

        
        ///de:root/de:BillingReference/de:BillingReferenceLine/cbc:Amount@currencyCodeListVersionID
        
        public string BillingReferenceLine_currencyCodeListVersionID { get; set; }

        
        ///de:root/de:BillingReference/de:BillingReferenceLine/cbc:Amount@currencyCodeListVersionID
        

        public string Tipo_Documento_Referenciado { get; set; }

    }


}
