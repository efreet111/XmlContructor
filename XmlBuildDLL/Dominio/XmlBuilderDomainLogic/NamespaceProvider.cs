using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class NamespaceProvider
    {
        // UBL root namespace (Invoice-2)
        public static readonly XNamespace Fe = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");

        // Common UBL namespaces
        public static readonly XNamespace Cac = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
        public static readonly XNamespace Cbc = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
        public static readonly XNamespace Ext = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
        public static readonly XNamespace Qdt = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");

        // Signature and XML schema
        public static readonly XNamespace Ds = XNamespace.Get("http://www.w3.org/2000/09/xmldsig#");
        public static readonly XNamespace Xsi = XNamespace.Get("http://www.w3.org/2001/XMLSchema-instance");

        // UN/CEFACT datatypes
        public static readonly XNamespace Udt = XNamespace.Get("urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");

        // DIAN structures
        public static readonly XNamespace Sts = XNamespace.Get("dian:gov:co:facturaelectronica:Structures-2-1");

        // ETSI XAdES namespaces
        public static readonly XNamespace Xades = XNamespace.Get("http://uri.etsi.org/01903/v1.3.2#");
        public static readonly XNamespace Xades141 = XNamespace.Get("http://uri.etsi.org/01903/v1.4.1#");

        // UBL Signature components
        public static readonly XNamespace Sac = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2");
        public static readonly XNamespace Sbc = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2");

        // Interoperabilidad
        public static readonly XNamespace Ipt = XNamespace.Get("pt:co:facturaelectronica:InteroperabilidadPT-2-1");
    }
}
