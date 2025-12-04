using System.Xml.Linq;

namespace XmlBuildDLL.Dominio.Namespaces
{
    public interface INamespaceProvider
    {
        XNamespace Ubl { get; }
        XNamespace Cac { get; }
        XNamespace Cbc { get; }
        XNamespace Ds { get; }
        XNamespace Ext { get; }
        XNamespace Xsi { get; }
        XNamespace Udt { get; }
        XNamespace Qdt { get; }
        XNamespace Sts { get; }
        XNamespace Xades { get; }
        XNamespace Xades141 { get; }
        XNamespace Sac { get; }
        XNamespace Sbc { get; }
        XNamespace Ipt { get; }
    }

    public class DefaultNamespaceProvider : INamespaceProvider
    {
        public XNamespace Ubl { get; } = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");
        public XNamespace Cac { get; } = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
        public XNamespace Cbc { get; } = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
        public XNamespace Ds { get; } = XNamespace.Get("http://www.w3.org/2000/09/xmldsig#");
        public XNamespace Ext { get; } = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
        public XNamespace Xsi { get; } = XNamespace.Get("http://www.w3.org/2001/XMLSchema-instance");
        public XNamespace Udt { get; } = XNamespace.Get("urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
        public XNamespace Qdt { get; } = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
        public XNamespace Sts { get; } = XNamespace.Get("dian:gov:co:facturaelectronica:Structures-2-1");
        public XNamespace Xades { get; } = XNamespace.Get("http://uri.etsi.org/01903/v1.3.2#");
        public XNamespace Xades141 { get; } = XNamespace.Get("http://uri.etsi.org/01903/v1.4.1#");
        public XNamespace Sac { get; } = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2");
        public XNamespace Sbc { get; } = XNamespace.Get("urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2");
        public XNamespace Ipt { get; } = XNamespace.Get("pt:co:facturaelectronica:InteroperabilidadPT-2-1");
    }
}
