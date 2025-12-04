using System.Xml.Linq;
using XmlBuildDLL.BaseClass;
using XmlBuildDLL.Dominio.Namespaces;

namespace XmlBuildDLL.Dominio.Extensions
{
    public interface IInteroperabilidadBuilder
    {
        void AppendTo(XDocument document, OrquestatorXmlClass orquestator, INamespaceProvider ns);
    }

    public class InteroperabilidadBuilder : IInteroperabilidadBuilder
    {
        public void AppendTo(XDocument document, OrquestatorXmlClass orquestator, INamespaceProvider ns)
        {
            // Placeholder: implement Interoperabilidad extensions population here.
        }
    }
}
