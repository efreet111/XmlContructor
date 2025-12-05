using System;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.Transversal;
using static XmlBuildDLL.BaseClass.ComonXmlComponent.Catalogos;
using XmlBuildDLL.Dominio.Strategies;
using XmlBuildDLL.Dominio.Namespaces;
using XmlBuildDLL.Dominio.Extensions;

namespace XmlBuildDLL.Dominio
{
    public class BuilderXmlDominio
    {
        private OrquestatorXmlClass OrquestatorObj;
        //private XElement documentXML;
        private XNamespace fe;
        private XNamespace cac;
        private XNamespace cbc;
        private XNamespace ds;
        private XNamespace ext;
        private XNamespace xsi;
        private XNamespace udt;
        private XNamespace qdt;
        private XNamespace sts;
        private XNamespace xades;
        private XNamespace xades141;
        private XNamespace sac;
        private XNamespace sbc;
        private XNamespace ipt;

        private readonly INamespaceProvider _ns;
        private readonly IDianExtensionsBuilder _dianExtensionsBuilder;
        private readonly IInteroperabilidadBuilder _interoperabilidadBuilder;
        private readonly IXmlPostProcessor _postProcessor;

        public BuilderXmlDominio()
            : this(null, null, null, null)
        { }

        public BuilderXmlDominio(INamespaceProvider ns,
                                 IDianExtensionsBuilder dianExtensionsBuilder,
                                 IInteroperabilidadBuilder interoperabilidadBuilder,
                                 IXmlPostProcessor postProcessor)
        {
            _ns = ns;
            _dianExtensionsBuilder = dianExtensionsBuilder;
            _interoperabilidadBuilder = interoperabilidadBuilder;
            _postProcessor = postProcessor;
        }

        public string BuildXML(OrquestatorXmlClass i)
        {
            OrquestatorObj = i;

            // Preferir namespaces del provider si existe, de lo contrario usar el NamespaceProvider actual del proyecto
            if (_ns != null)
            {
                fe = _ns.Ubl;
                cac = _ns.Cac;
                cbc = _ns.Cbc;
                ds = _ns.Ds;
                ext = _ns.Ext;
                xsi = _ns.Xsi;
                udt = _ns.Udt;
                qdt = _ns.Qdt;
                sts = _ns.Sts;
                xades = _ns.Xades;
                xades141 = _ns.Xades141;
                sac = _ns.Sac;
                sbc = _ns.Sbc;
                ipt = _ns.Ipt;
            }
            else
            {
                fe = NamespaceProvider.Fe;
                cac = NamespaceProvider.Cac;
                cbc = NamespaceProvider.Cbc;
                ds = NamespaceProvider.Ds;
                ext = NamespaceProvider.Ext;
                xsi = NamespaceProvider.Xsi;
                udt = NamespaceProvider.Udt;
                qdt = NamespaceProvider.Qdt;
                sts = NamespaceProvider.Sts;
                xades = NamespaceProvider.Xades;
                xades141 = NamespaceProvider.Xades141;
                sac = NamespaceProvider.Sac;
                sbc = NamespaceProvider.Sbc;
                ipt = NamespaceProvider.Ipt;
            }

            var declaration = new XDeclaration("1.0", "utf-8", "no");

            var resolver = new DocumentTypeResolver();
            var strategy = resolver.Resolve(OrquestatorObj.BodyXml.TypeDocumentCode);

            if (strategy == null)
            {
                if (OrquestatorObj.BodyXml.TypeDocumentCode == "04" || OrquestatorObj.BodyXml.TypeDocumentCode == "05" || OrquestatorObj.BodyXml.TypeDocumentCode == "06")
                {
                    documentXML = new XElement(fe + "CreditNote");
                }
                else if (OrquestatorObj.BodyXml.TypeDocumentCode == "07" || OrquestatorObj.BodyXml.TypeDocumentCode == "08" || OrquestatorObj.BodyXml.TypeDocumentCode == "09")
                {
                    documentXML = new XElement(fe + "DebitNote");
                }
                else
                {
                    return string.Empty;
                }
            }
            else
            {
                var rootName = strategy.GetRootElementName(OrquestatorObj.BodyXml.TypeDocumentCode);
                documentXML = new XElement(fe + rootName);
            }

            documentXML.Add(new XAttribute(XNamespace.Xmlns + "fe", fe.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "cac", cac.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "cbc", cbc.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "ds", ds.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "ext", ext.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "xsi", xsi.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "udt", udt.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "qdt", qdt.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "sts", sts.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "xades", xades.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "xades141", xades141.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "sac", sac.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "sbc", sbc.NamespaceName));
            documentXML.Add(new XAttribute(XNamespace.Xmlns + "ipt", ipt.NamespaceName));

            XElement UBLExtensions = new XElement(ext + "UBLExtensions");
            XElement AdditionalInformation = AdditionalInformationXmlFill.FillAdditionalInformation(OrquestatorObj);
            UBLExtensions.Add(new XElement(ext + "UBLExtension",
                    new XElement(ext + "ExtensionContent", AdditionalInformation)));
            documentXML.Add(UBLExtensions);

            documentXML.Add(new XElement(cbc + "UBLVersionID", Catalog.UBLVersionID20));
            documentXML.Add(new XElement(cbc + "ProfileID", Catalog.ProfileID10));
            documentXML.Add(new XElement(cbc + "ID", OrquestatorObj.BodyXml.ID));

            strategy?.ApplyTypeSpecificElements(documentXML, OrquestatorObj);

            documentXML.Add(new XElement(cbc + "IssueDate", OrquestatorObj.BodyXml.IssueDate.ToString("yyyy-MM-dd")));
            documentXML.Add(new XElement(cbc + "IssueTime", string.Format("{0:D2}:{1:D2}:{2:D2}", OrquestatorObj.BodyXml.IssueTime.Hours, OrquestatorObj.BodyXml.IssueTime.Minutes, OrquestatorObj.BodyXml.IssueTime.Seconds)));

            if (!string.IsNullOrEmpty(OrquestatorObj.BodyXml.Note))
                documentXML.Add(new XElement(cbc + "Note", new XCData(OrquestatorObj.BodyXml.Note)));

            if (!string.IsNullOrEmpty(OrquestatorObj.BodyXml.DocumentCurrencyCode))
                documentXML.Add(new XElement(cbc + "DocumentCurrencyCode", OrquestatorObj.BodyXml.DocumentCurrencyCode));

            ReferencesExtensionsBuilder.AddReferencesExtensions(documentXML, OrquestatorObj);

            XElement AccountingSupplierPartyNode = AccountingSupplierPartyXmlFill.AccountingSupplierParty(OrquestatorObj.AccountingSupplierParty);
            documentXML.Add(AccountingSupplierPartyNode);

            XElement AccountingCustomerPartyNode = AccountingCustomerPartyXmlFill.AccountingCustomerParty(OrquestatorObj.AccountingCustomerParty);
            documentXML.Add(AccountingCustomerPartyNode);

            foreach (var rowT in OrquestatorObj.TaxTotal)
            {
                if (rowT != null)
                {
                    var TaxTotalNode = TaxTotalXmlfill.TaxTotal(rowT);
                    documentXML.Add(TaxTotalNode);
                }
            }

            var legalMonetaryTotalXmlFill = new LegalMonetaryTotalXmlFill();
            documentXML.Add(legalMonetaryTotalXmlFill.LegalMonetaryTotal(OrquestatorObj.LegalMonetaryTotal));

            if (OrquestatorObj.Line != null)
            {
                var lineItemsXmlFill = new LineItemsXmlFill();
                foreach (var rowLine in OrquestatorObj.Line)
                {
                    if (rowLine != null)
                    {
                        var LineNode = lineItemsXmlFill.LineItems(rowLine, OrquestatorObj.BodyXml.TypeDocumentCode);
                        documentXML.Add(LineNode);
                    }
                }
            }

            var doc = new XDocument(declaration, documentXML);

            // Builders de extensiones (puntos de extensión); no alteran la salida actual si no están configurados
            _dianExtensionsBuilder?.AppendTo(doc, OrquestatorObj, _ns ?? new DefaultNamespaceProvider());
            _interoperabilidadBuilder?.AppendTo(doc, OrquestatorObj, _ns ?? new DefaultNamespaceProvider());

            var xmlString = doc.ToString();
            if (_postProcessor != null)
            {
                xmlString = _postProcessor.Process(xmlString);
            }

            return xmlString;
        }
    }
}

