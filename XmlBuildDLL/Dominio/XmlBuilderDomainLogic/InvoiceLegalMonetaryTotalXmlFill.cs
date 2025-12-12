using System;
using System.Xml.Linq;
using XmlBuildDLL.DocumentClass.UBL2._1;
using System.Globalization;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class InvoiceLegalMonetaryTotalXmlFill
    {
        internal static XElement FillInvoiceLegalMonetaryTotal(String NodeName, ref int cantidadDecimales, BillingDocument21Object obj)
        {
            if (obj.LegalMonetaryTotal != null)
            {
                XElement LegalMonetaryTotal = new XElement(NamespaceProvider.Cac + NodeName);

                if (!String.IsNullOrWhiteSpace(obj.LegalMonetaryTotal.LineExtensionAmount.ToString()) && !String.IsNullOrWhiteSpace(obj.LegalMonetaryTotal.LineExtensionAmount_currencyID.ToString()))
                {
                    LegalMonetaryTotal.Add(new XElement(NamespaceProvider.Cbc + "LineExtensionAmount", obj.LegalMonetaryTotal.LineExtensionAmount.ToString(String.Format("F{0}", cantidadDecimales), CultureInfo.CurrentCulture), new XAttribute("currencyID", obj.LegalMonetaryTotal.LineExtensionAmount_currencyID)));
                }

                if (!String.IsNullOrWhiteSpace(obj.LegalMonetaryTotal.TaxExclusiveAmount.ToString()) && !String.IsNullOrWhiteSpace(obj.LegalMonetaryTotal.TaxExclusiveAmount_currencyID.ToString()))
                {
                    LegalMonetaryTotal.Add(new XElement(NamespaceProvider.Cbc + "TaxExclusiveAmount", obj.LegalMonetaryTotal.TaxExclusiveAmount.ToString(String.Format("F{0}", cantidadDecimales), CultureInfo.CurrentCulture), new XAttribute("currencyID", obj.LegalMonetaryTotal.TaxExclusiveAmount_currencyID)));
                }

                if (!String.IsNullOrWhiteSpace(obj.LegalMonetaryTotal.TaxInclusiveAmount.ToString()) && !String.IsNullOrWhiteSpace(obj.LegalMonetaryTotal.TaxInclusiveAmount_currencyID.ToString()))
                {
                    LegalMonetaryTotal.Add(new XElement(NamespaceProvider.Cbc + "TaxInclusiveAmount", obj.LegalMonetaryTotal.TaxInclusiveAmount.ToString(String.Format("F{0}", cantidadDecimales), CultureInfo.CurrentCulture), new XAttribute("currencyID", obj.LegalMonetaryTotal.TaxInclusiveAmount_currencyID)));
                }

                if (obj.LegalMonetaryTotal.AllowanceTotalAmount.HasValue && !String.IsNullOrWhiteSpace(obj.LegalMonetaryTotal.AllowanceTotalAmount_currencyID.ToString()))
                {
                    LegalMonetaryTotal.Add(new XElement(NamespaceProvider.Cbc + "AllowanceTotalAmount", obj.LegalMonetaryTotal.AllowanceTotalAmount.Value.ToString(String.Format("F{0}", cantidadDecimales), CultureInfo.CurrentCulture), new XAttribute("currencyID", obj.LegalMonetaryTotal.AllowanceTotalAmount_currencyID)));
                }

                if (obj.LegalMonetaryTotal.ChargeTotalAmount.HasValue && !String.IsNullOrWhiteSpace(obj.LegalMonetaryTotal.ChargeTotalAmount_currencyID.ToString()))
                {
                    LegalMonetaryTotal.Add(new XElement(NamespaceProvider.Cbc + "ChargeTotalAmount", obj.LegalMonetaryTotal.ChargeTotalAmount.Value.ToString(String.Format("F{0}", cantidadDecimales), CultureInfo.CurrentCulture), new XAttribute("currencyID", obj.LegalMonetaryTotal.ChargeTotalAmount_currencyID)));
                }

                if (obj.LegalMonetaryTotal.PrepaidAmount.HasValue && !String.IsNullOrWhiteSpace(obj.LegalMonetaryTotal.PrepaidAmount_currencyID.ToString()))
                {
                    LegalMonetaryTotal.Add(new XElement(NamespaceProvider.Cbc + "PrepaidAmount", obj.LegalMonetaryTotal.PrepaidAmount.Value.ToString(String.Format("F{0}", cantidadDecimales), CultureInfo.CurrentCulture), new XAttribute("currencyID", obj.LegalMonetaryTotal.PrepaidAmount_currencyID)));
                }

                if (obj.LegalMonetaryTotal.PayableRoundingAmount.HasValue && !String.IsNullOrWhiteSpace(obj.LegalMonetaryTotal.PayableRoundingAmount_currencyID.ToString()))
                {
                    LegalMonetaryTotal.Add(new XElement(NamespaceProvider.Cbc + "PayableRoundingAmount", obj.LegalMonetaryTotal.PayableRoundingAmount.Value.ToString(String.Format("F{0}", cantidadDecimales), CultureInfo.CurrentCulture), new XAttribute("currencyID", obj.LegalMonetaryTotal.PayableRoundingAmount_currencyID)));
                }

                if (!String.IsNullOrWhiteSpace(obj.LegalMonetaryTotal.PayableAmount.ToString()) && !String.IsNullOrWhiteSpace(obj.LegalMonetaryTotal.PayableAmount_currencyID.ToString()))
                {
                    LegalMonetaryTotal.Add(new XElement(NamespaceProvider.Cbc + "PayableAmount", obj.LegalMonetaryTotal.PayableAmount.ToString(String.Format("F{0}", cantidadDecimales), CultureInfo.CurrentCulture), new XAttribute("currencyID", obj.LegalMonetaryTotal.PayableAmount_currencyID)));
                }

                return LegalMonetaryTotal;
            }

            return null;
        }

    }
}
