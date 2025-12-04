using System.Collections.Generic;
using XmlBuildDLL.BaseClass;

namespace XmlBuildDLL.Dominio.Strategies
{
    
    /// Resolves the strategy based on BodyXml.TypeDocumentCode.
    
    public class DocumentTypeResolver
    {
        private readonly IDictionary<string, IDocumentTypeStrategy> _map;

        public DocumentTypeResolver()
        {
            _map = new Dictionary<string, IDocumentTypeStrategy>
            {
                {"01", new InvoiceDocumentStrategy()},
                {"02", new InvoiceDocumentStrategy()},
                {"03", new InvoiceDocumentStrategy()},
                // Extend with other strategies e.g., CreditNoteStrategy, DebitNoteStrategy
            };
        }

        public IDocumentTypeStrategy Resolve(string typeDocumentCode)
        {
            return (typeDocumentCode != null && _map.TryGetValue(typeDocumentCode, out var strategy))
                ? strategy
                : null;
        }
    }
}
