using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
  
  //root/AdditionalDocumentReference
  
  public class AdditionalDocumentReference
  {
    
    //root/AdditionalDocumentReference/cbc:ID
    
    public String ID { get; set; }

    
    //root/AdditionalDocumentReference/cbc:ID/@schemeID
    
    public String ID_schemeID { get; set; }

    
    //root/AdditionalDocumentReference/cbc:ID/@schemeName
    
    public String ID_schemeName { get; set; }

    
    //root/AdditionalDocumentReference/cbc:ID/@schemeVersionID
    
    public String ID_schemeVersionID { get; set; } 

    
    //root/AdditionalDocumentReference/cbc:ID/@schemeAgency
    
    public String ID_schemeAgencyID { get; set; }

    
    //root/AdditionalDocumentReference/cbc:UUID
    
    public String UUID { get; set; }

    
    //root/AdditionalDocumentReference/cbc:UUID/@schemeName
    
    public String UUID_SchemeName { get; set; }

    //Hay más nodos en el estándar UBL 2.1 sin embargo no están definidos en Anexo de la DIAN para UBL 2.1. Steph
    //De aquí en adelante No están especificados en Anexo de la DIAN para UBL 2.1. Steph

    //
    ///// 
    //
    //public String CopyIndicator { get; set; } //TODO: Revisar por qué se agregó en 2.0, en el XML de Producción no aparece. Steph

    //
    ////root/cac:AdditionalDocumentReference/cbc:IssueDate
    //
    public DateTime? IssueDate { get; set; } //TODO: Revisar por qué se agregó en 2.0, en el XML de Producción no aparece. Steph

    //
    ////root/cac:AdditionalDocumentReference/cbc:DocumentTypeCode
    //
    public String DocumentTypeCode { get; set; } //TODO: Revisar por qué se agregó en 2.0, en el XML de Producción no aparece. Steph


    //
    ////root/cac:AdditionalDocumentReference/cbc:DocumentTypeCode/@listURI
    //
    public String DocumentTypeCode_listURI { get; set; } 


    //
    ////root/cac:AdditionalDocumentReference/cbc:DocumentType
    //
    public String DocumentType { get; set; }


    public String DocumentStatusCode { get; set; }

    public List<String> DocumentDescription { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }



    //
    ///// 
    //
    //public String DocumentTypeCode { get; set; } //TODO: Revisar por qué se agregó en 2.0, en el XML de Producción no aparece. Steph

    //public String Xpath { get; set; }

    //public String Attachment { get; set; }
  }
}
