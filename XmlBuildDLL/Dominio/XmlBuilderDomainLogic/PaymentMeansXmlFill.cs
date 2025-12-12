using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class PaymentMeansXmlFill
    {
        internal static XElement FillPaymentMeans(PaymentMeans obj)
        {
            if (obj != null)
            {
                XElement PaymentMeans = new XElement(NamespaceProvider.Cac + "PaymentMeans");

                if (!String.IsNullOrWhiteSpace(obj.ID))
                {
                    if ((!string.IsNullOrEmpty(obj.IdSchemeId)) && (!string.IsNullOrEmpty(obj.IdSchemeName))) //Sector Salud
                    {
                        PaymentMeans.Add(new XElement(NamespaceProvider.Cbc + "ID", obj.ID, new XAttribute("schemeID", obj.IdSchemeId), new XAttribute("schemeName", obj.IdSchemeName)));
                    }
                    else
                    {
                        PaymentMeans.Add(new XElement(NamespaceProvider.Cbc + "ID", obj.ID));
                    }
                }

                if (!String.IsNullOrWhiteSpace(obj.PaymentMeansCode))
                {
                    PaymentMeans.Add(new XElement(NamespaceProvider.Cbc + "PaymentMeansCode", obj.PaymentMeansCode));
                }

                if (obj.PaymentDueDate.HasValue)
                {
                    PaymentMeans.Add(new XElement(NamespaceProvider.Cbc + "PaymentDueDate", obj.PaymentDueDate.Value.ToString("yyyy-MM-dd")));
                }

                if (!String.IsNullOrWhiteSpace(obj.PaymentChannelCode))
                {
                    PaymentMeans.Add(new XElement(NamespaceProvider.Cbc + "PaymentChannelCode", obj.PaymentChannelCode));
                }

                if (!String.IsNullOrWhiteSpace(obj.InstructionID))
                {
                    PaymentMeans.Add(new XElement(NamespaceProvider.Cbc + "InstructionID", obj.InstructionID));
                }

                if (!String.IsNullOrWhiteSpace(obj.InstructionNote))
                {
                    PaymentMeans.Add(new XElement(NamespaceProvider.Cbc + "InstructionNote", obj.InstructionNote));
                }

                if (!String.IsNullOrWhiteSpace(obj.PaymentID))
                {
                    PaymentMeans.Add(new XElement(NamespaceProvider.Cbc + "PaymentID", obj.PaymentID));
                }
                if (!String.IsNullOrWhiteSpace(obj.PayeeFinancialAccountTypeCode))
                {
                    PaymentMeans.Add(new XElement(NamespaceProvider.Cac + "PayeeFinancialAccount",
                       new XElement(NamespaceProvider.Cbc + "ID", obj.PayeeFinancialAccountID),
                       new XElement(NamespaceProvider.Cbc + "Name", obj.PayeeFinancialAccountName),
                       new XElement(NamespaceProvider.Cbc + "AccountTypeCode", obj.PayeeFinancialAccountTypeCode)));
                }

                return PaymentMeans;
            }

            return null;
        }
    }
}
