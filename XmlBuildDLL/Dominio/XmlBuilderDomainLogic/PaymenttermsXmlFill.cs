using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class PaymenttermsXmlFill
    {
        internal static XElement FillPaymentTerms( PaymentTerms objPaymentTerms)
        {
            XElement xElementPaymentTerms = new XElement(NamespaceProvider.Cac + "PaymentTerms");

            PaymentTerms row = objPaymentTerms;

            if (row != null)
            {
                if (!String.IsNullOrEmpty(row.PaymentTermsID))
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cbc + "ID", row.PaymentTermsID));

                if (!String.IsNullOrEmpty(row.PaymentTermMeansID))
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cbc + "PaymentMeansID", row.PaymentTermMeansID));

                if (!String.IsNullOrEmpty(row.PaymentTermPrepaidPaymentReferenceID))
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cbc + "PrepaidPaymentReferenceID", row.PaymentTermPrepaidPaymentReferenceID));

                if (!String.IsNullOrEmpty(row.PaymentTermNote))
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cbc + "Note", row.PaymentTermNote));

                if (!String.IsNullOrEmpty(row.PaymentTermReferenceEventCode))
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cbc + "ReferenceEventCode", row.PaymentTermReferenceEventCode));


                if (row.PaymentTermSettlementDiscountPercent != null)
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cbc + "SettlementDiscountPercent", row.PaymentTermSettlementDiscountPercent));

                if (!String.IsNullOrEmpty(row.PaymentTermPenaltySurchargePercent))
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cbc + "PenaltySurchargePercent", row.PaymentTermPenaltySurchargePercent));

                if (!String.IsNullOrEmpty(row.PaymentTermPaymentPercert))
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cbc + "PaymentPercent", row.PaymentTermPaymentPercert));


                if (!String.IsNullOrEmpty(row.PaymentTermAmount))
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cbc + "Amount", row.PaymentTermAmount,
                        new XAttribute("currencyID", "COP")));


                if (!String.IsNullOrEmpty(row.PaymentTermPenaltyAmount))
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cbc + "PenaltyAmount", row.PaymentTermPenaltyAmount,
                        new XAttribute("currencyID", "COP")));

                if (row.PaymentTermPaymentDueDate != null)
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cbc + "PaymentDueDate", row.PaymentTermPaymentDueDate.Value.ToString("yyyy-MM-dd")));

                if (!String.IsNullOrEmpty(row.DurationMeasure.ToString()))
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cac + "SettlementPeriod",
                       new XElement(NamespaceProvider.Cbc + "DurationMeasure", row.DurationMeasure
                       , new XAttribute("unitCode", row.PaymentTermSetPeriodDurationMeasure))));

                if (row.PaymentTermStartDate.HasValue && row.PaymentTermEndtDate.HasValue)
                    xElementPaymentTerms.Add(new XElement(NamespaceProvider.Cac + "ValidityPeriod",
                       new XElement(NamespaceProvider.Cbc + "StartDate", row.PaymentTermStartDate.Value.ToString("yyyy-MM-dd")),
                       new XElement(NamespaceProvider.Cbc + "EndDate", row.PaymentTermEndtDate.Value.ToString("yyyy-MM-dd"))));
            }

            return xElementPaymentTerms;
        }

    }
}
