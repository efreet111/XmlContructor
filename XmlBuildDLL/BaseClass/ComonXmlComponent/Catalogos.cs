using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.ComonXmlComponent
{
    public class Catalogos
    {
        public class Catalog
        {
            public static string UBLVersionID20 = "UBL 2.0";
            public static string UBLVersionID21 = "UBL 2.1";
            public static string CustomizationID = "1";
            public static string ProfileID10 = "DIAN 1.0";
            public static string ProfileID21 = "DIAN 2.1";
            public static string DIAN_AgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)";
            public static string DIAN_ID = "195";
            public static string URI_InvoiceType = "http://www.dian.gov.co/contratos/facturaelectronica/v1/InvoiceType";
        }

        public class CatDianExt
        {
            public static string listAgencyID = "6";
            public static string listAgencyName = "United Nations Economic Commission for Europe";
            public static string listSchemeURI = "urn:oasis:names:specification:ubl:codelist:gc:CountryIdentificationCode-2.0";
        }

        public enum TypeDocument
        {
            None = 0,
            Invoice = 1,
            ExportInvoice = 2,
            ContingencyInvoice = 3,
            CreditNote = 4,
            DebitNote = 5,
            ApplicationReponse = 6,
            AttachedDocument = 7,
            ApplicationResponce = 8
        }

        public enum UBL_Version
        {
            UBL2_0 = 0,
            UBL2_1 = 1
        }

        public static class Paths
        {
                     
            ///documentbuildco\DocumentBuildCO\XSD\UBL2.{0}\{1}\
            
            public static String rootPath = "XSD" + Path.DirectorySeparatorChar + "UBL2.{0}" + Path.DirectorySeparatorChar + "{1}" + Path.DirectorySeparatorChar;
            public static String commonPath = @"UBL2.{0}" + Path.DirectorySeparatorChar + "common" + Path.DirectorySeparatorChar;
            public static String maindocPath = @"UBL2.{0}" + Path.DirectorySeparatorChar + "maindoc" + Path.DirectorySeparatorChar;
        }

        public static class UBL21Names
        {
            public static String xsdInvoice = "UBL-Invoice-2.1.xsd";
            public static String xsdCreditNote = "UBL-CreditNote-2.1.xsd";
            public static String xsdDebitNote = "UBL-DebitNote-2.1.xsd";
            public static String xsdApplicationResponse = "UBL-ApplicationResponse-2.1.xsd";
            public static String xsdAttachedDocument = "UBL-AttachedDocument-2.1.xsd";
            public static String xsdApplicationResponse2 = "UBL-ApplicationResponse-2.1.xsd";
        }

        public static class UBL21urn
        {
            public static String urnInvoice = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2";
            public static String urnCreditNote = "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2";
            public static String urnDebitNote = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2";
            public static String urnApplicationReponse = "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2";
            public static String urnAttachedDocument = "urn:oasis:names:specification:ubl:schema:xsd:AttachedDocument-2";
        }
    }
}
