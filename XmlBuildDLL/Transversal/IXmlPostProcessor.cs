namespace XmlBuildDLL.Transversal
{
    public interface IXmlPostProcessor
    {
        string Process(string xml);
    }

    public class DefaultXmlPostProcessor : IXmlPostProcessor
    {
        public string Process(string xml)
        {
            // No-op by default. Add textual corrections here when needed.
            return xml;
        }
    }
}
