using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.DocumentClass.UBL2._1;
using XmlBuildDLL.Transversal;
using static XmlBuildDLL.BaseClass.ComonXmlComponent.Catalogos;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class DianExtensionsXmlFill
    {
        internal static XElement FillDianExtensions(BillingDocument21Object obj)
        {
            XElement dianExtensions = new XElement(NamespaceProvider.Sts + "DianExtensions");
            if (obj.DianExtensions != null)
            {
                if (obj.InvoiceTypeCode == HelpersConstantes.TipoDocumento.Fact || obj.InvoiceTypeCode == HelpersConstantes.TipoDocumento.FactExportacion || obj.InvoiceTypeCode == HelpersConstantes.TipoDocumento.FactContingenciaEmisor || obj.InvoiceTypeCode == HelpersConstantes.TipoDocumento.FactContingenciaDian || obj.InvoiceTypeCode == HelpersConstantes.TipoDocumento.FactDocumentoSoporte)
                {
                    XElement InvoiceControl = new XElement(NamespaceProvider.Sts + "InvoiceControl");
                    if (!String.IsNullOrWhiteSpace(obj.DianExtensions.InvoiceAuthorization))
                    {
                        XElement InvoiceAuthorization = new XElement(NamespaceProvider.Sts + "InvoiceAuthorization", obj.DianExtensions.InvoiceAuthorization);
                        InvoiceControl.Add(InvoiceAuthorization);
                    }
                    if (obj.DianExtensions.StartDate.HasValue && obj.DianExtensions.EndDate.HasValue)
                    {
                        XElement AuthorizationPeriod = new XElement(NamespaceProvider.Sts + "AuthorizationPeriod");
                        AuthorizationPeriod.Add(new XElement(NamespaceProvider.Cbc + "StartDate", obj.DianExtensions.StartDate.Value.ToString("yyyy-MM-dd")));
                        AuthorizationPeriod.Add(new XElement(NamespaceProvider.Cbc + "EndDate", obj.DianExtensions.EndDate.Value.ToString("yyyy-MM-dd")));
                        InvoiceControl.Add(AuthorizationPeriod);
                    }
                    if (!String.IsNullOrWhiteSpace(obj.DianExtensions.From) && !String.IsNullOrWhiteSpace(obj.DianExtensions.To))
                    {
                        XElement AuthorizationInvoices = new XElement(NamespaceProvider.Sts + "AuthorizedInvoices");
                        AuthorizationInvoices.Add(new XElement(NamespaceProvider.Sts + "Prefix", obj.DianExtensions.Prefix));
                        AuthorizationInvoices.Add(new XElement(NamespaceProvider.Sts + "From", obj.DianExtensions.From));
                        AuthorizationInvoices.Add(new XElement(NamespaceProvider.Sts + "To", obj.DianExtensions.To));
                        InvoiceControl.Add(AuthorizationInvoices);
                    }
                    dianExtensions.Add(InvoiceControl);
                }
                if (!String.IsNullOrWhiteSpace(obj.DianExtensions.InvoiceSourceIdentificationCode) && !String.IsNullOrWhiteSpace(obj.DianExtensions.InvoiceSourceListAgencyID) && !String.IsNullOrWhiteSpace(obj.DianExtensions.InvoiceSourceListAgencyName) && !String.IsNullOrWhiteSpace(obj.DianExtensions.InvoiceSourceListSchemeURI))
                {
                    XElement InvoiceSource = new XElement(NamespaceProvider.Sts + "InvoiceSource");
                    InvoiceSource.Add(new XElement(NamespaceProvider.Cbc + "IdentificationCode", obj.DianExtensions.InvoiceSourceIdentificationCode, new XAttribute("listAgencyID", obj.DianExtensions.InvoiceSourceListAgencyID), new XAttribute("listAgencyName", obj.DianExtensions.InvoiceSourceListAgencyName), new XAttribute("listSchemeURI", obj.DianExtensions.InvoiceSourceListSchemeURI)));
                    dianExtensions.Add(InvoiceSource);
                }
                if (!String.IsNullOrWhiteSpace(obj.DianExtensions.ProviderID) && !String.IsNullOrWhiteSpace(obj.DianExtensions.SoftwareID))
                {
                    XElement SoftwareProvider = new XElement(NamespaceProvider.Sts + "SoftwareProvider");
                    SoftwareProvider.Add(new XElement(NamespaceProvider.Sts + "ProviderID", obj.DianExtensions.ProviderID, new XAttribute("schemeName", obj.DianExtensions.ProviderID_SchemeName), new XAttribute("schemeID", obj.DianExtensions.ProviderID_SchemeID), new XAttribute("schemeAgencyID", Catalog.DIAN_ID), new XAttribute("schemeAgencyName", Catalog.DIAN_AgencyName)));
                    SoftwareProvider.Add(new XElement(NamespaceProvider.Sts + "SoftwareID", obj.DianExtensions.SoftwareID, new XAttribute("schemeAgencyID", Catalog.DIAN_ID), new XAttribute("schemeAgencyName", Catalog.DIAN_AgencyName)));
                    dianExtensions.Add(SoftwareProvider);
                }
                if (!String.IsNullOrWhiteSpace(obj.DianExtensions.SoftwareSecurityCode))
                {
                    XElement SoftwareSecurityCode = new XElement(NamespaceProvider.Sts + "SoftwareSecurityCode", obj.DianExtensions.SoftwareSecurityCode, new XAttribute("schemeAgencyID", Catalog.DIAN_ID), new XAttribute("schemeAgencyName", Catalog.DIAN_AgencyName));
                    dianExtensions.Add(SoftwareSecurityCode);
                }
                if (!String.IsNullOrWhiteSpace(obj.DianExtensions.AuthorizationProviderID) && !String.IsNullOrWhiteSpace(obj.DianExtensions.AuthorizationProviderIDSchemeID) && !String.IsNullOrWhiteSpace(obj.DianExtensions.AuthorizationProviderIDSchemeName) && !String.IsNullOrWhiteSpace(obj.DianExtensions.AuthorizationProviderIDSchemeAgencyID) && !String.IsNullOrWhiteSpace(obj.DianExtensions.AuthorizationProviderIDSchemeAgencyName))
                {
                    XElement AuthorizationProvider = new XElement(NamespaceProvider.Sts + "AuthorizationProvider");
                    AuthorizationProvider.Add(new XElement(NamespaceProvider.Sts + "AuthorizationProviderID", obj.DianExtensions.AuthorizationProviderID, new XAttribute("schemeID", obj.DianExtensions.AuthorizationProviderIDSchemeID), new XAttribute("schemeName", obj.DianExtensions.AuthorizationProviderIDSchemeName), new XAttribute("schemeAgencyID", obj.DianExtensions.AuthorizationProviderIDSchemeAgencyID), new XAttribute("schemeAgencyName", obj.DianExtensions.AuthorizationProviderIDSchemeAgencyName)));
                    dianExtensions.Add(AuthorizationProvider);
                }
                if (!String.IsNullOrWhiteSpace(obj.DianExtensions.QRCode))
                {
                    XElement QRCode = new XElement(NamespaceProvider.Sts + "QRCode", obj.DianExtensions.QRCode);
                    dianExtensions.Add(QRCode);
                }
                return dianExtensions;
            }
            else
            {
                return null;
            }
        }

    }
}
