using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class DianExtensions
    {
        
        //root/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/sts:DianExtensions/sts:InvoiceControl/sts:InvoiceAuthorization
        
        public String InvoiceAuthorization { get; set; }

        
        //root/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/sts:DianExtensions/sts:InvoiceControl/sts:AuthorizationPeriod/cbc:StartDate
        
        public DateTime ? StartDate { get; set; }

        
        //root/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/sts:DianExtensions/sts:InvoiceControl/sts:AuthorizationPeriod/cbc:EndDate
        
        public DateTime ? EndDate { get; set; }

        
        //root/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/sts:DianExtensions/sts:InvoiceControl/sts:AuthorizedInvoices/sts:Prefix
        
        public String Prefix { get; set; }

        
        //root/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/sts:DianExtensions/sts:InvoiceControl/sts:AuthorizedInvoices/sts:From
        
        public String From { get; set; }

        
        //root/ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent/sts:DianExtensions/sts:InvoiceControl/sts:AuthorizedInvoices/sts:To
        
        public String To { get; set; }

        
        //root/sts:DianExtensions/sts:InvoiceSource/sts:IdentificationCode
        
        public String InvoiceSourceIdentificationCode { get; set; }

        
        //root/sts:DianExtensions/sts:InvoiceSource/sts:IdentificationCode/@ListAgencyID
        
        public String InvoiceSourceListAgencyID { get; set; }

        
        //root/sts:DianExtensions/sts:InvoiceSource/sts:IdentificationCode/@ListAgencyName
        
        public String InvoiceSourceListAgencyName { get; set; }

        
        //root/sts:DianExtensions/sts:InvoiceSource/sts:IdentificationCode/@ListSchemeURI
        
        public String InvoiceSourceListSchemeURI { get; set; }

        
        //root/sts:DianExtensions/sts:SoftwareProvider/sts:ProviderID
        
        public String ProviderID { get; set; }

        
        //root/sts:DianExtensions/sts:SoftwareProvider/sts:ProviderID/@schemeID
        
        public String ProviderID_SchemeID { get; set; }

        
        //root/sts:DianExtensions/sts:SoftwareProvider/sts:ProviderID/@schemeName
        
        public String ProviderID_SchemeName { get; set; }

        
        //root/sts:DianExtensions/sts:SoftwareProvider/sts:SoftwareID
        
        public String SoftwareID { get; set; }

        
        //root/sts:DianExtensions/sts:SoftwareSecurityCode
        
        public String SoftwareSecurityCode {get; set;}

        
        //root/sts:DianExtensions/sts:AuthorizationProviderID
        
        public String AuthorizationProviderID { get; set; }

        
        //root/sts:DianExtensions/sts:AuthorizationProviderID@SchemeID
        
        public String AuthorizationProviderIDSchemeID { get; set; }

        
        //root/sts:DianExtensions/sts:AuthorizationProviderID@SchemeName
        
        public String AuthorizationProviderIDSchemeName { get; set; }

        
        //root/sts:DianExtensions/sts:AuthorizationProviderID@SchemeAgencyID
        
        public String AuthorizationProviderIDSchemeAgencyID { get; set; }

        
        //root/sts:DianExtensions/sts:AuthorizationProviderID@SchemeAgencyName
        
        public String AuthorizationProviderIDSchemeAgencyName { get; set; }

        
        //root/sts:DianExtensions/sts:QRCode
        
        public String QRCode { get; set; }
    
    //root/sts:DianExtensions//sts:QRCode/sts:Software-PIN
    
    public String SoftwarePin{ get; set; }

    
    /// Atributo para Clave Tecnical no va en XML
    
    public String KeyTechnical { get; set; }
	}
}
