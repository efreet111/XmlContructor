using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.XmlBodyComponent;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class LineItemsXmlFill
    {
        internal static XElement LineItems(Line line, String TypeDocumentCode)
        {
            var fe = NamespaceProvider.Fe;
            var cac = NamespaceProvider.Cac;
            var cbc = NamespaceProvider.Cbc;

            XElement lineItem = null;

            if (TypeDocumentCode == "01" || TypeDocumentCode == "02" || TypeDocumentCode == "03")
            {
                lineItem = new XElement(fe + "InvoiceLine");
            }
            else if (TypeDocumentCode == "04" || TypeDocumentCode == "05" || TypeDocumentCode == "06")
            {
                lineItem = new XElement(fe + "CreditNoteLine");
            }
            else if (TypeDocumentCode == "07" || TypeDocumentCode == "08" || TypeDocumentCode == "09")
            {
                lineItem = new XElement(fe + "DebitNoteLine");
            }

            if (line.ID != "")
                lineItem.Add(new XElement(cbc + "ID", line.ID));

            if (line.UUID != "")
                lineItem.Add(new XElement(cbc + "UUID", line.UUID));

            if (line.Note != "")
                lineItem.Add(new XElement(cbc + "Note", line.Note));

            if (TypeDocumentCode == "01" || TypeDocumentCode == "02" || TypeDocumentCode == "03")
            {
                lineItem.Add(new XElement(cbc + "InvoicedQuantity", line.Quantity.ToString("0.0000")));
            }
            else if (TypeDocumentCode == "04" || TypeDocumentCode == "05" || TypeDocumentCode == "06")
            {
                lineItem.Add(new XElement(cbc + "CreditedQuantity", line.Quantity.ToString("0.0000")));
            }
            else if (TypeDocumentCode == "07" || TypeDocumentCode == "08" || TypeDocumentCode == "09")
            {
                lineItem.Add(new XElement(cbc + "DebitedQuantity", line.Quantity.ToString("0.0000")));
            }

            lineItem.Add(new XElement(cbc + "LineExtensionAmount", line.LineExtensionAmount.ToString("0.0000"),
                new XAttribute("currencyID", line.LineExtensionAmountCurrencyID)
                ));

            if (line.AccountingCostCode != "")
                lineItem.Add(new XElement(cbc + "AccountingCostCode", line.AccountingCostCode));

            if (line.AccountingCost != "")
                lineItem.Add(new XElement(cbc + "AccountingCost", line.AccountingCost));

            //if (line.TaxTotal != null)
            //{
            //    foreach (var LTaxtotal in line.TaxTotal)
            //    {

            //    }
            //}

            return lineItem;
        }

    }
}
