# XmlBuildDLL Project Rules

Audience: developers and AI agents contributing to XmlBuildDLL.

Target: .NET Framework 4.8, C# 7.3

Core principles:
- Follow SOLID.
- Keep domain pure: no I/O, no static mutable state.
- Prefer composition and strategies over conditionals.

Architecture overview:
- `BaseClass`: DTOs and value objects that represent UBL/DIAN data.
- `Dominio.XmlBuilderDomainLogic`: XML section builders and helpers using `System.Xml.Linq`.
- `Dominio.Strategies`: document-type strategies and resolver mapping codes to behaviors.
- `Dominio.BuilderXmlDominio`: orchestrator that assembles the final `XDocument` using strategies and section builders.
- `Transversal`: cross-cutting helpers (formatting, encoding).
- `Tests`: MSTest unit tests.

Design rules:
1. Orchestrator
   - `BuilderXmlDominio` coordinates building and must not embed document-type conditionals. Use `IDocumentTypeStrategy` via `DocumentTypeResolver`.
   - Order of sections is defined by strategies and section builders; keep orchestrator slim.
2. Strategies
   - Implement `IDocumentTypeStrategy` for each document group (Invoice, CreditNote, DebitNote...).
   - `GetRootElementName` returns the UBL root element.
   - `ApplyTypeSpecificElements` adds elements/attributes unique to the type (e.g., `UUID`, `InvoiceTypeCode`).
   - Register codes in `DocumentTypeResolver`. New types must be added only to resolver and new strategy class.
3. Section builders
   - Provide builders for `AccountingSupplierParty`, `AccountingCustomerParty`, `TaxTotal`, `LegalMonetaryTotal`, `Line`, etc.
   - Avoid static state; pure functions are allowed. If configurability is needed, define interfaces and inject.
4. Formatting
   - Centralize formatting rules (date/time, currency) in a dedicated helper/service. Do not format ad hoc in multiple places.
5. Catalog/Namespaces
   - Constants in `Catalogos` and `NamespaceProvider` are read-only. If environment-specific values are required, provide an `ICatalogProvider` and avoid hard-coded literals in builders.
6. Validation
   - Validate input DTOs before building. Introduce validators per section/type that return rich results.
7. Testing
   - Unit tests must cover: root name selection, presence and order of mandatory nodes, namespace correctness, and type-specific elements.
   - Keep snapshot tests for XML strings stable.
8. Extensibility
   - Do not add new conditionals for types in orchestrator; create strategies.
   - Prefer interfaces and DI-friendly constructors for new builders.
9. Performance
   - Use `XElement`/`XDocument`. For very large documents or high throughput, consider streaming writers but only with evidence.

Coding conventions:
- Use PascalCase for public members, camelCase for locals.
- Avoid comments unless clarifying complex logic; prefer self-explanatory code and named functions.
- No magic strings in orchestrator; use constants/providers.

AI guidance:
- Read `PROJECT_RULES.md` first.
- Propose small, incremental PRs.
- Preserve public API contracts unless a migration plan is provided.
- Add tests when adding strategies or changing builders.
