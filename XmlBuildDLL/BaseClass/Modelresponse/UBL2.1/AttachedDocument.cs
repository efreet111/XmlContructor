using System;
using System.Collections.Generic;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
  public class AttachedDocument
  {
    
    //root/de:AttachedDocument/cbc:UBLVersionID
    
    public String UBLVersionID { get; set; }

    
    //root/de:AttachedDocument/cbc:CustomizationID		
    
    public String CustomizationID { get; set; }

    
    //root/de:AttachedDocument/cbc:ProfileID		
    
    public String ProfileID { get; set; }

    
    //root/de:AttachedDocument/cbc:ProfileExecutionID		
    
    public String ProfileExecutionID { get; set; }

    
    //root/de:AttachedDocument/cbc:ProfileExecutionID		
    
    public String ID { get; set; }

    
    //root/de:AttachedDocument/cbc:IssueDate		
    
    public DateTime IssueDate { get; set; }

    
    //root/de:AttachedDocument/cbc:IssueTime		
    
    public DateTime IssueTime { get; set; }

    
    //root/de:AttachedDocument/cbc:DocumentType		
    
    public String DocumentType { get; set; }

    
    //root/de:AttachedDocument/cbc:ParentDocumentID		
    
    public String ParentDocumentID { get; set; }

    
    //root/de:AttachedDocument/cbc:Note		
    
    public String Note { get; set; }


    #region SenderParty
    
    //root/de:AttachedDocument/de:SenderParty/de:PartyTaxScheme/cbc:RegistrationName
    
    public String SenderRegistrationName { get; set; }

    
    //root/de:AttachedDocument/de:SenderParty/de:PartyTaxScheme/cbc:CompanyID
    
    public String SenderCompanyID { get; set; }

    
    //root/de:AttachedDocument/de:SenderParty/de:PartyTaxScheme/cbc:CompanyID@schemeAgencyID
    
    public String SenderschemeAgencyID { get; set; }

    
    //root/de:AttachedDocument/de:SenderParty/de:PartyTaxScheme/cbc:CompanyID@schemeID
    
    public String SenderschemeID { get; set; }

    
    //root/de:AttachedDocument/de:SenderParty/de:PartyTaxScheme/de:TaxScheme/cbc:Name@schemeName
    
    public String SenderTaxSchemeName { get; set; }


    
    //root/de:AttachedDocument/de:SenderParty/de:PartyTaxScheme/cbc:TaxLevelCode
    
    public String SenderTaxLevelCode { get; set; }

    
    //root/de:AttachedDocument/de:SenderParty/de:PartyTaxScheme/cbc:TaxLevelCode@listName
    
    public String SenderlistName { get; set; }

    
    //root/de:AttachedDocument/de:SenderParty/de:PartyTaxScheme/de:TaxScheme/cbc:ID
    
    public String SenderTaxSchemeID { get; set; }


    
    //root/de:AttachedDocument/de:SenderParty/de:PartyTaxScheme/de:TaxScheme/cbc:CompanyID@schemeName   
    
    public String SenderPartyTaxSchemeName { get; set; }

    #endregion


    #region ReceiverParty
    
    //root/de:AttachedDocument/de:ReceiverParty/de:PartyTaxScheme/cbc:RegistrationName
    
    public String ReceiverRegistrationName { get; set; }

    
    //root/de:AttachedDocument/de:ReceiverParty/de:PartyTaxScheme/cbc:CompanyID
    
    public String ReceiverCompanyID { get; set; }

    
    //root/de:AttachedDocument/de:ReceiverParty/de:PartyTaxScheme/cbc:CompanyID@schemeAgencyID
    
    public String ReceiverschemeAgencyID { get; set; }

    
    //root/de:AttachedDocument/de:ReceiverParty/de:PartyTaxScheme/cbc:CompanyID@schemeID
    
    public String ReceiverschemeID { get; set; }

    
    //root/de:AttachedDocument/de:ReceiverParty/de:PartyTaxScheme/cbc:CompanyID@schemeName
    
    public String ReceiverschemeName { get; set; }

    
    //root/de:AttachedDocument/de:ReceiverParty/de:PartyTaxScheme/cbc:TaxLevelCode
    
    public String ReceiverTaxLevelCode { get; set; }

    
    //root/de:AttachedDocument/de:ReceiverParty/de:PartyTaxScheme/cbc:TaxLevelCode@listName
    
    public String ReceiverlistName { get; set; }


    
    //root/de:AttachedDocument/de:ReceiverParty/de:PartyTaxScheme/de:TaxScheme/cbc:ID
    
    public String ReceiverTaxSchemeID { get; set; }

    
    //root/de:AttachedDocument/de:ReceiverParty/de:PartyTaxScheme/de:TaxScheme/cbc:Name
    
    public String ReceiverTaxSchemeName { get; set; }

    #endregion

    #region Attachment

    
    //root/de:AttachedDocument/de:Attachment/de:ExternalReference/cbc:MimeCode
    
    public String MimeCode { get; set; }


    
    //root/de:AttachedDocument/de:Attachment/de:ExternalReference/cbc:EncodingCode
    
    public String EncodingCode { get; set; }

    
    //root/de:AttachedDocument/de:Attachment/de:ExternalReference/cbc:Description
    
    public String Description { get; set; }


    #endregion

    
    //root/de:AttachedDocument/cbc:ParentDocumentLineReference
    
    public List<ParentDocumentLineReference> ParentDocumentLineReference { get; set; }


  }

  public class ParentDocumentLineReference
  {

    #region ParentDocumentLineReference

    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/cbc:LineID
    
    public String LineID { get; set; }

    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/de:DocumentReference/cbc:ID
    
    public String DocumentReferenceID { get; set; }


    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/de:DocumentReference/cbc:UUID
    
    public String DocumentReferenceUUID { get; set; }

    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/de:DocumentReference/cbc:UUID@schemeName
    
    public String DocumentReferenceschemeName { get; set; }

    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/de:DocumentReference/cbc:IssueDate
    
    public DateTime DocumentReferenceIssueDate { get; set; }

    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/de:DocumentReference/cbc:DocumentType
    
    public String DocumentReferenceDocumentType { get; set; }


    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/de:DocumentReference/de:Attachment/de:ExternalReference/cbc:MimeCode
    
    public String DocumentReferenceMimeCode { get; set; }

    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/de:DocumentReference/de:Attachment/de:ExternalReference/cbc:EncodingCode
    
    public String DocumentReferenceEncodingCode { get; set; }


    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/de:DocumentReference/de:Attachment/de:ExternalReference/cbc:Description
    
    public String DocumentReferenceDescription { get; set; }

    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/de:DocumentReference/de:ResultOfVerification/de:ExternalReference/cbc:ValidatorID
    
    public String ValidatorID { get; set; }

    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/de:DocumentReference/de:ResultOfVerification/de:ExternalReference/cbc:ValidationResultCode
    
    public String ValidationResultCode { get; set; }

    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/de:DocumentReference/de:ResultOfVerification/de:ExternalReference/cbc:ValidationDate
    
    public DateTime ValidationDate { get; set; }

    
    //root/de:AttachedDocument/de:ParentDocumentLineReference/de:DocumentReference/de:ResultOfVerification/de:ExternalReference/cbc:ValidationTime
    
    public DateTime ValidationTime { get; set; }
    #endregion
  }
}