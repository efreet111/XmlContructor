using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class DiscrepancyResponse
    {
        
        /// root/cac:/DiscrepancyResponse/cbc:ReferenceID
        
        public String ReferenceID { get; set; }

        
        /// root/cac:/DiscrepancyResponse/cbc:ResponseCode
        
        public String ResponseCode { get; set; }

        
        /// root/cac:/DiscrepancyResponse/cbc:Description
        
        public List<String> Description { get; set; }

        
        //root/cac:DiscrepancyResponse/cbc:UUID
        
        public String UUID { get; set; }

        
        //root/cac:DiscrepancyResponse/cbc:UUID@schemeName
        
        public String UUIDSchemeName { get; set; }

        //
        ////root/cac:AdditionalDocumentReference/cbc:IssueDate
        //////root/cac:DespatchDocumentReference/cbc:IssueDate
        //////root/cac:ReceiptDocumentReference/cbc:IssueDate
        //////Invoice/cac:BillingReference/cac:CreditNoteDocumentReference/cbc:IssueDate
        //////CreditNote/cac:BillingReference/cac:InvoiceDocumentReference/cbc:IssueDate
        //////DebitNote/cac:BillingReference/cac:InvoiceDocumentReference/cbc:IssueDate
        //
        //public String IssueDate { get; set; }

        //
        ////root/cac:AdditionalDocumentReference/cbc:IssueDate
        //////root/cac:AdditionalDocumentReference/cbc:DocumentTypeCode
        //////root/root/cac:DespatchDocumentReference/cbc:DocumentTypeCode
        ///////root/cac:ReceiptDocumentReference/cbc:DocumentTypeCode
        //
        //public String DocumentTypeCode { get; set; }

        //Hay más nodos en el estándar UBL 2.1 sin embargo no están definidos en Anexo de la DIAN para UBL 2.1. Steph:
        //EffectiveDate [0..1]
        //EffectiveTime [0..1]
        //Status [0..*] 

        //TODO: Revisar de aquí en adelante por qué se agregaron estos campos en 2.0, no aparecen en UBL 2.0. Steph
        //No están especificados en Anexo de la DIAN para UBL 2.1 ni en el UBL 2.1. Steph

        public String ResponseCode_listName { get; set; }

        public String ResponseCode_listURI { get; set; }

        public String ResponseCode_name { get; set; }
    }
}
