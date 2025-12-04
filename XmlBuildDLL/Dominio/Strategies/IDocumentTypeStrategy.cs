using System.Xml.Linq;
using XmlBuildDLL.BaseClass;

namespace XmlBuildDLL.Dominio.Strategies
{
    
    /// Defines type-specific behaviors for building document XML (e.g., Invoice, CreditNote).
    
    public interface IDocumentTypeStrategy
    {
        string GetRootElementName(string typeDocumentCode);
        void ApplyTypeSpecificElements(XElement documentRoot, OrquestatorXmlClass orquestator);
    }
}
