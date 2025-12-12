using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class AllowanceChargeXmlFill
    {
        internal static XElement FillAllowanceCharge(AllowanceCharge objAllowanceCharge, ref int cantidadDecimales)
        {
            String Charp = String.Empty;
            for (int i = 0; i < cantidadDecimales; i++)
            {
                Charp = Charp + "0";
            }

            XElement allowanceCharge = null;

            if (objAllowanceCharge != null)
            {
                allowanceCharge = new XElement(NamespaceProvider.Cac + "AllowanceCharge");

                if (!String.IsNullOrEmpty(objAllowanceCharge.ID.ToString()))
                    allowanceCharge.Add(new XElement(NamespaceProvider.Cbc + "ID", objAllowanceCharge.ID));

                allowanceCharge.Add(new XElement(NamespaceProvider.Cbc + "ChargeIndicator", (objAllowanceCharge.ChargeIndicator ? "true" : "false")));

                if (!String.IsNullOrEmpty(objAllowanceCharge.AllowanceChargeReasonCode))
                    allowanceCharge.Add(new XElement(NamespaceProvider.Cbc + "AllowanceChargeReasonCode", objAllowanceCharge.AllowanceChargeReasonCode));

                if (!String.IsNullOrEmpty(objAllowanceCharge.AllowanceChargeReason))
                    allowanceCharge.Add(new XElement(NamespaceProvider.Cbc + "AllowanceChargeReason", objAllowanceCharge.AllowanceChargeReason));

                if (objAllowanceCharge.MultiplierFactorNumeric.HasValue)
                    allowanceCharge.Add(new XElement(NamespaceProvider.Cbc + "MultiplierFactorNumeric", objAllowanceCharge.MultiplierFactorNumeric.Value.ToString(String.Format("F{0}", cantidadDecimales))));

                if (!String.IsNullOrEmpty(objAllowanceCharge.Amount.ToString()))
                    allowanceCharge.Add(new XElement(NamespaceProvider.Cbc + "Amount", objAllowanceCharge.Amount.ToString(String.Format("F{0}", cantidadDecimales)),
                        new XAttribute("currencyID", objAllowanceCharge.Amount_CurrencyID)
                        ));

                if (!String.IsNullOrEmpty(objAllowanceCharge.BaseAmount.ToString()))
                    allowanceCharge.Add(new XElement(NamespaceProvider.Cbc + "BaseAmount", objAllowanceCharge.BaseAmount.ToString(String.Format("F{0}", cantidadDecimales)),
                        new XAttribute("currencyID", objAllowanceCharge.BaseAmount_CurrencyID)));

                if (allowanceCharge.HasElements)
                {
                    return allowanceCharge;
                }
                else
                {
                    return null;
                }
            }

            return allowanceCharge;
        }

    }
}
