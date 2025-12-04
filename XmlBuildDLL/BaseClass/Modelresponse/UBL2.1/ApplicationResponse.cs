using DocumentBuildCO.Common;
using DocumentBuildCO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentBuildCO.Builder.UBL2._1;
using XmlBuildDLL.BaseClass.Modelresponse;
using System.Xml;
using System.Xml.Linq;


namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class ApplicationResponse
    {
        #region UBLExtensions

        #endregion

        
        //root/de:ApplicationResponse/cbc:UBLVersionID
        
        public String UBLVersionID { get; set; }

        
        //root/de:ApplicationResponse/cbc:CustomizationID		
        
        public String CustomizationID { get; set; }

        
        //root/de:ApplicationResponse/cbc:ProfileID		
        
        public String ProfileID { get; set; }

        
        //root/de:ApplicationResponse/cbc:ProfileExecutionID		
        
        public String ProfileExecutionID { get; set; }

        
        //root/de:ApplicationResponse/cbc:ID		
        
        public String ID { get; set; }

        
        //root/de:ApplicationResponse/cbc:UUID		
        
        public String UUID { get; set; }

        
        //root/de:ApplicationResponse/cbc:UUID@schemeID		
        
        public String UUID_schemeID { get; set; }

        
        //root/de:ApplicationResponse/cbc:UUID@schemeName
        
        public String UUID_schemeName { get; set; }

        
        //root/de:ApplicationResponse/cbc:IssueDate		
        
        public DateTime IssueDate { get; set; }

        
        //root/de:ApplicationResponse/cbc:IssueTime		
        
        public DateTime IssueTime { get; set; }


        #region SenderParty

        
        //root/de:ApplicationResponse/de:SenderParty/de:PartyTaxScheme/cbc:PartyTaxScheme
        
        public String SenderPartyTaxScheme { get; set; }

        
        //root/de:ApplicationResponse/de:SenderParty/de:PartyTaxScheme/cbc:RegistrationName
        
        public String SenderRegistrationName { get; set; }

        
        //root/de:ApplicationResponse/de:SenderParty/de:PartyTaxScheme/cbc:CompanyID
        
        public String SenderCompanyID { get; set; }

        
        //root/de:ApplicationResponse/de:SenderParty/de:PartyTaxScheme/cbc:CompanyID@schemeAgencyName
        
        public String SenderCompanyschemeAgencyName { get; set; }

        
        //root/de:ApplicationResponse/de:SenderParty/de:PartyTaxScheme/cbc:CompanyID@schemeID
        
        public String SenderCompanyschemeID { get; set; }


        
        //root/de:ApplicationResponse/de:SenderParty/de:PartyTaxScheme/cbc:CompanyID@schemeName
          
        public String SenderCompanyschemeName { get; set; }


        
        //root/de:ApplicationResponse/de:SenderParty/de:PartyTaxScheme/cbc:CompanyID@schemeAgencyID
        
        public String SenderCompanyschemeAgencyID { get; set; }

        
        //root/de:ApplicationResponse/de:SenderParty/de:PartyTaxScheme/de:TaxScheme/cbc:Name
        
        public String SenderTaxName { get; set; }

        //
        ////root/de:ApplicationResponse/de:SenderParty/de:PartyTaxScheme/de:TaxScheme/cbc:Name@schemeName
        //
        //public String SenderTaxSchemeName { get; set; }

        
        //root/de:ApplicationResponse/de:SenderParty/de:PartyTaxScheme/de:TaxScheme/cbc:ID
        
        public String SenderTaxSchemeID { get; set; }


        
        //root/de:ApplicationResponse/de:SenderParty/cbc:TaxLevelCode
        
        public String SenderTaxLevelCode { get; set; }

        
        //root/de:ApplicationResponse/de:SenderParty/cbc:TaxLevelCode@ListName
        
        public String SenderTaxLevelCodeListName { get; set; }

        #endregion

        #region ReceiverParty
        
        //root/de:ApplicationResponse/de:ReceiverParty/de:PartyTaxScheme/cbc:RegistrationName
        
        public String ReceiverRegistrationName { get; set; }

        
        //root/de:ApplicationResponse/de:ReceiverParty/de:PartyTaxScheme/cbc:CompanyID
        
        public String ReceiverCompanyID { get; set; }

        
        //root/de:ApplicationResponse/de:ReceiverParty/de:PartyTaxScheme/cbc:CompanyID@schemeAgencyID
        
        public String ReceiverschemeAgencyID { get; set; }


        
        //root/de:ApplicationResponse/de:ReceiverParty/de:PartyTaxScheme/cbc:CompanyID@schemeAgencyName
        
        public String ReceiverschemeAgencyName { get; set; }


        
        //root/de:ApplicationResponse/de:ReceiverParty/de:PartyTaxScheme/cbc:CompanyID@schemeID
        
        public String ReceiverschemeID { get; set; }

        
        //root/de:ApplicationResponse/de:ReceiverParty/de:PartyTaxScheme/cbc:CompanyID@schemeName
        
        public String ReceiverschemeName { get; set; }


        
        //root/de:ApplicationResponse/de:ReceiverParty/cbc:Contact
        
        public String ReceiverContact { get; set; }

        
        //root/de:ApplicationResponse/de:ReceiverParty/de:TaxScheme/cbc:ID
        
        public String ReceiverTaxSchemeID { get; set; }


        
        //root/de:ApplicationResponse/de:ReceiverParty/de:TaxScheme/cbc:Name
        
        public String ReceiverTaxSchemeName { get; set; }

        
        //root/de:ApplicationResponse/de:ReceiverParty/de:Contact/cbc:ElectronicMail
        
        public String ReceiverTaxSchemeElectronicMail { get; set; }



        #endregion

        #region DocumentReference
        
        //root/de:ApplicationResponse/de:DocumentResponse/de:DocumentReference/cbc:ID		
        
        public String DocumentReferenceID { get; set; }

        
        //root/de:ApplicationResponse/de:DocumentResponse/de:DocumentReference/de:AdditionalDocumentReference/cbc:UUID		
        
        public String DocumentReferenceUUID { get; set; }


        
        //root/de:ApplicationResponse/de:DocumentReference/de:AdditionalDocumentReference/cbc:UUID@schemeName
        
        public String DocumentReferenceschemeName { get; set; }

        
        //root/de:ApplicationResponse/de:DocumentReference/de:AdditionalDocumentReference/cbc:DocumentTypeCode
        
        public String DocumentReferenceTypeCode { get; set; }

        #endregion

        #region LineResponse/ LineReference
        
        //root/de:ApplicationResponse/de:DocumentResponse/de:LineResponse/de:LineReference/cbc:LineID		
        
        public String LineReferenceID { get; set; }


        
        //root/de:ApplicationResponse/de:DocumentResponse/de:LineResponse/de:LineReference
        
        public List<LineResponse> LineResponse { get; set; }

        #endregion

        #region DocumentResponce
        
        //root/de:ApplicationResponse/de:DocumentResponse/de:Response/cbc:ReferenceID		
        
        public String ResponseReferenceID { get; set; }



        
        //root/de:ApplicationResponse/de:DocumentResponse/de:Response/cbc:ResponseCode		
        
        public String ResponseResponseCode { get; set; }

        
        //root/de:ApplicationResponse/de:DocumentResponse/de:Response/cbc:ResponseCode@listID		
        
        public String ResponseListID { get; set; }

        
        //root/de:ApplicationResponse/de:DocumentResponse/de:Response/cbc:Descripcion
        
        public String ResponseDescription { get; set; }




        #endregion

        #region Attachment

        //
        ////root/de:ApplicationResponse/de:Attachment/de:ExternalReference/cbc:MimeCode
        //
        //public String MimeCode { get; set; }


        //
        ////root/de:ApplicationResponse/de:Attachment/de:ExternalReference/cbc:EncodingCode
        //
        //public String EncodingCode { get; set; }

        //
        ////root/de:ApplicationResponse/de:Attachment/de:ExternalReference/cbc:Description
        //
        //public String Description { get; set; }


        #endregion

        
        //root/de:ApplicationResponse/cbc:ParentDocumentLineReference
        
        public List<LineResponse> LineResponselist { get; set; }


    }

    #region LineResponse
    public class LineResponse
    {
        
        //root/de:ApplicationResponse/de:DocumentResponse/de:LineResponse/de:Response/cbc:ReferenceID
        
        public String LineResponseReferenceID { get; set; }


        
        //root/de:ApplicationResponse/de:DocumentResponse/de:LineResponse/de:Response/cbc:ResponseCode		
        
        public String LineResponseResponseCode { get; set; }


        
        //root/de:ApplicationResponse/de:DocumentResponse/de:LineResponse/de:Response/cbc:Descripcion
        
        public String LineResponseDescription { get; set; }


    }
    #endregion
}
