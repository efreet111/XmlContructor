using System.Xml.Linq;
using XmlBuildDLL.BaseClass;
using XmlBuildDLL.Dominio.Namespaces;

namespace XmlBuildDLL.Dominio.Extensions
{
    public interface IDianExtensionsBuilder
    {
        void AppendTo(XDocument document, OrquestatorXmlClass orquestator, INamespaceProvider ns);
    }

    public class DianExtensionsBuilder : IDianExtensionsBuilder
    {
        public void AppendTo(XDocument document, OrquestatorXmlClass orquestator, INamespaceProvider ns)
        {
            // Placeholder: implement DIAN UBLExtensions population here.
        }
    }
}
