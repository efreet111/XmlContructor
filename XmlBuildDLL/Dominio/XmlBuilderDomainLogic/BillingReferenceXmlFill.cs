using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.Transversal;
using static XmlBuildDLL.BaseClass.ComonXmlComponent.Catalogos;


namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class BillingReferenceXmlFill
    {
        internal static XElement FillBillingReference(BillingReference objBillingReference, string TypeDocument)
        {
            XElement xElement = null;
            XElement xElementReferenceLine = null;
            XElement xElementBillingReference = new XElement(NamespaceProvider.Cac + "BillingReference");


            BillingReference row = objBillingReference;
            //string caseSwitch = obj.TypeDocument.ToString();

            if (TypeDocument != null)
            {
                if (TypeDocument == "Invoice")
                {
                    // Siempre agregar la referencia de documento de factura primero
                    xElement = new XElement(NamespaceProvider.Cac + "InvoiceDocumentReference");
                    if (!string.IsNullOrEmpty(row.InvoiceID))
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "ID", row.InvoiceID));
                    }
                    if (!string.IsNullOrEmpty(row.InvoiceUUID))
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "UUID", row.InvoiceUUID,
                                new XAttribute("schemeName", row.InvoiceschemeName)));
                    }
                    if (row.InvoiceIssueDate.HasValue)
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", row.InvoiceIssueDate.Value.ToString("yyyy-MM-dd")));
                    }
                    if (xElement.HasElements)
                    {
                        xElementBillingReference.Add(xElement);
                    }

                    // A partir de aquí, lógica adicional existente para otras referencias
                    if (TypeDocument == HelpersConstantes.TipoDocumento.Fact)
                    {
                        if (row.Tipo_Documento_Referenciado == "91")
                        {
                            if (!string.IsNullOrEmpty(row.InvoiceID))
                            {
                                xElement = new XElement(NamespaceProvider.Cac + "CreditNoteDocumentReference");
                                if (!string.IsNullOrEmpty(row.InvoiceID))
                                {
                                    xElement.Add(new XElement(NamespaceProvider.Cbc + "ID", row.InvoiceID));
                                }
                                if (!string.IsNullOrEmpty(row.InvoiceUUID))
                                {
                                    xElement.Add(new XElement(NamespaceProvider.Cbc + "UUID", row.InvoiceUUID,
                                            new XAttribute("schemeName", row.InvoiceschemeName)));
                                }
                                if (row.InvoiceIssueDate.HasValue)
                                {
                                    xElement.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", row.InvoiceIssueDate.Value.ToString("yyyy-MM-dd")));

                                }

                                if (xElement.HasElements)
                                    xElementBillingReference.Add(xElement);
                            }
                        }
                        else if (row.Tipo_Documento_Referenciado == "92")
                        {
                            xElement = new XElement(NamespaceProvider.Cac + "DebitNoteDocumentReference");
                            if (!string.IsNullOrEmpty(row.InvoiceID))
                            {
                                xElement.Add(new XElement(NamespaceProvider.Cbc + "ID", row.InvoiceID));
                            }
                            if (!string.IsNullOrEmpty(row.InvoiceUUID))
                            {
                                xElement.Add(new XElement(NamespaceProvider.Cbc + "UUID", row.InvoiceUUID,
                                        new XAttribute("schemeName", row.InvoiceschemeName)));
                            }
                            if (row.InvoiceIssueDate.HasValue)
                            {
                                xElement.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", row.InvoiceIssueDate.Value.ToString("yyyy-MM-dd")));

                            }
                            if (xElement.HasElements)
                                xElementBillingReference.Add(xElement);
                        }
                    }

                    if (TypeDocument == HelpersConstantes.TipoDocumento.FactDocumentoSoporte)
                    {
                        xElement = new XElement(NamespaceProvider.Cac + "CreditNoteDocumentReference");
                        if (!string.IsNullOrEmpty(row.InvoiceID))
                        {
                            xElement.Add(new XElement(NamespaceProvider.Cbc + "ID", row.InvoiceID));
                        }
                        if (!string.IsNullOrEmpty(row.InvoiceUUID))
                        {
                            xElement.Add(new XElement(NamespaceProvider.Cbc + "UUID", row.InvoiceUUID,
                                    new XAttribute("schemeName", row.InvoiceschemeName)));
                        }
                        if (row.InvoiceIssueDate.HasValue)
                        {
                            xElement.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", row.InvoiceIssueDate.Value.ToString("yyyy-MM-dd")));

                        }

                        if (xElement.HasElements)
                            xElementBillingReference.Add(xElement);

                    }
                    else
                    {
                        xElement = new XElement(NamespaceProvider.Cac + "CreditNoteDocumentReference");
                        if (!string.IsNullOrEmpty(row.CreditNoteID))
                        {
                            xElement.Add(new XElement(NamespaceProvider.Cbc + "ID", row.CreditNoteID));
                        }
                        if (!string.IsNullOrEmpty(row.CreditNoteUUID))
                        {
                            xElement.Add(new XElement(NamespaceProvider.Cbc + "UUID", row.CreditNoteUUID,
                                    new XAttribute("schemeName", row.CreditNoteUUIDschemeName)));
                        }
                        if (row.CreditNoteIssueDate.HasValue)
                        {
                            xElement.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", row.CreditNoteIssueDate.Value.ToString("yyyy-MM-dd")));
                        }

                        if (xElement.HasElements)
                            xElementBillingReference.Add(xElement);

                        xElement = null;

                        xElement = new XElement(NamespaceProvider.Cac + "DebitNoteDocumentReference");
                        if (!string.IsNullOrEmpty(row.DebitNoteID))
                        {
                            xElement.Add(new XElement(NamespaceProvider.Cbc + "ID", row.DebitNoteID));
                        }
                        if (!string.IsNullOrEmpty(row.DebitNoteUUID))
                        {
                            xElement.Add(new XElement(NamespaceProvider.Cbc + "UUID", row.DebitNoteUUID,
                                    new XAttribute("schemeName", row.DebitNoteschemeName)));
                        }
                        if (row.DebitNoteIssueDate.HasValue)
                        {
                            xElement.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", row.DebitNoteIssueDate.Value.ToString("yyyy-MM-dd")));

                        }
                        if (xElement.HasElements)
                            xElementBillingReference.Add(xElement);
                    }

                    if (xElementReferenceLine != null)
                    {
                        if (xElementReferenceLine.HasElements)
                            xElementBillingReference.Add(xElementReferenceLine);
                    }
                    xElementReferenceLine = null;
                    xElement = null;

                    xElement = new XElement(NamespaceProvider.Cac + "DebitNoteDocumentReference");
                    if (!string.IsNullOrEmpty(row.DebitNoteID))
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "ID", row.DebitNoteID));
                    }
                    if (!string.IsNullOrEmpty(row.DebitNoteUUID))
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "UUID", row.DebitNoteUUID,
                            new XAttribute("schemeName", row.DebitNoteschemeName)));
                    }
                    if (row.DebitNoteIssueDate.HasValue)
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", row.DebitNoteIssueDate.Value.ToString("yyyy-MM-dd")));

                    }
                    if (xElement.HasElements)
                    {
                        xElementBillingReference.Add(xElement);
                    }

                }
                else if (TypeDocument == "DebitNote")
                {
                    xElement = new XElement(NamespaceProvider.Cac + "InvoiceDocumentReference");
                    if (!string.IsNullOrEmpty(row.InvoiceID))
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "ID", row.InvoiceID));
                    }
                    if (!string.IsNullOrEmpty(row.InvoiceUUID))
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "UUID", row.InvoiceUUID,
                                new XAttribute("schemeName", row.InvoiceschemeName)));
                    }
                    if (row.InvoiceIssueDate.HasValue)
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", row.InvoiceIssueDate.Value.ToString("yyyy-MM-dd")));
                    }
                    xElementBillingReference.Add(xElement);

                }
                else if (TypeDocument == "CreditNote")
                {
                    xElement = new XElement(NamespaceProvider.Cac + "InvoiceDocumentReference");

                    if (!string.IsNullOrEmpty(row.InvoiceID))
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "ID", row.InvoiceID));
                    }
                    if (!string.IsNullOrEmpty(row.InvoiceUUID))
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "UUID", row.InvoiceUUID,
                                new XAttribute("schemeName", row.InvoiceschemeName)));
                    }
                    if (row.InvoiceIssueDate.HasValue)
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", row.InvoiceIssueDate.Value.ToString("yyyy-MM-dd")));
                    }

                    if (xElement.HasElements)
                    {
                        xElementBillingReference.Add(xElement);
                    }
                }
                else if (TypeDocument == "AdjustNote")
                {
                    xElement = new XElement(NamespaceProvider.Cac + "InvoiceDocumentReference");
                    if (!string.IsNullOrEmpty(row.InvoiceID))
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "ID", row.InvoiceID));
                    }
                    if (!string.IsNullOrEmpty(row.InvoiceUUID))
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "UUID", row.InvoiceUUID,
                                new XAttribute("schemeName", row.InvoiceschemeName)));
                    }
                    if (row.InvoiceIssueDate.HasValue)
                    {
                        xElement.Add(new XElement(NamespaceProvider.Cbc + "IssueDate", row.InvoiceIssueDate.Value.ToString("yyyy-MM-dd")));
                    }
                    if (xElement.HasElements)
                    {
                        xElementBillingReference.Add(xElement);
                    }
                }

            }
            return xElementBillingReference;

        }

    }
}
