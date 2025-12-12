using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.DocumentClass.UBL2._1;
using XmlBuildDLL.BaseClass.Modelresponse; // InvoiceLine lives here
using XmlBuildDLL.Transversal;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class InvoiceLineXmlFillTests
    {
        private BillingDocument21Object CreateDoc(string tipo)
        {
            return new BillingDocument21Object
            {
                InvoiceTypeCode = tipo,
                CustomizationID = "11",
                ValorPorDefectoRedondeoAplicado = "false",
                InvoiceLine = new List<InvoiceLine>()
            };
        }

        [TestMethod]
        public void FillInvoiceLine_AddsBasicNodes_WithSchemeId_AndQuantity()
        {
            // arrange
            var doc = CreateDoc(HelpersConstantes.TipoDocumento.Fact);
            doc.InvoiceLine.Add(new InvoiceLine
            {
                ID = 1,
                ID_schemeID = "SCM",
                UUID = "uuid-1",
                Note = "nota",
                Quantity = 5m,
                Quantity_unitCode = "EA",
                LineExtensionAmount = 123.45m,
                LineExtensionAmountCurrencyID = "COP",
                FreeOfChargeIndicator = false
            });

            var root = new XElement("Root");
            var sut = new InvoiceLineXmlFill();
            int dec = 2; // cantidadDecimales

            // act
            sut.FillInvoiceLine(ref root, "InvoiceLine", "Invoiced", ref dec, doc);

            // assert
            var line = root.Element(NamespaceProvider.Cac + "InvoiceLine");
            Assert.IsNotNull(line);

            var id = line.Element(NamespaceProvider.Cbc + "ID");
            Assert.IsNotNull(id);
            Assert.AreEqual("1", id.Value);
            Assert.AreEqual("SCM", id.Attribute("schemeID")?.Value);

            Assert.AreEqual("uuid-1", line.Element(NamespaceProvider.Cbc + "UUID")?.Value);
            Assert.AreEqual("nota", line.Element(NamespaceProvider.Cbc + "Note")?.Value);

            var qty = line.Element(NamespaceProvider.Cbc + "InvoicedQuantity");
            Assert.IsNotNull(qty);
            Assert.AreEqual("5.00", qty.Value);
            Assert.AreEqual("EA", qty.Attribute("unitCode")?.Value);

            var lea = line.Element(NamespaceProvider.Cbc + "LineExtensionAmount");
            Assert.IsNotNull(lea);
            Assert.AreEqual("123.45", lea.Value);
            Assert.AreEqual("COP", lea.Attribute("currencyID")?.Value);

            var free = line.Element(NamespaceProvider.Cbc + "FreeOfChargeIndicator");
            Assert.IsNotNull(free);
            Assert.AreEqual("false", free.Value);
        }

        [TestMethod]
        public void FillInvoiceLine_OmitsOptionalNodes_WhenValuesMissing_AndAddsItemAndPrice()
        {
            // arrange
            var doc = CreateDoc(HelpersConstantes.TipoDocumento.FactExportacion);
            doc.InvoiceLine.Add(new InvoiceLine
            {
                Quantity = 1m,
                Quantity_unitCode = "EA",
                // No ID_schemeID, No UUID, No Note
                LineExtensionAmount = 99m,
                LineExtensionAmountCurrencyID = "USD",
                FreeOfChargeIndicator = true,
                // Minimal item fields so Item and Price fillers can create nodes
                SellersItemIdentification_ID = "SKU-01",
                DescripcionItem = "Producto",
                PriceAmount = 99m,
                PriceAmount_currencyID = "USD"
            });

            var root = new XElement("Root");
            var sut = new InvoiceLineXmlFill();
            int dec = 2;

            // act
            sut.FillInvoiceLine(ref root, "InvoiceLine", "Invoiced", ref dec, doc);

            // assert
            var line = root.Element(NamespaceProvider.Cac + "InvoiceLine");
            Assert.IsNotNull(line);

            // ID without scheme attribute
            var id = line.Element(NamespaceProvider.Cbc + "ID");
            // ID may be null if not provided
            Assert.IsTrue(id == null || id.Attribute("schemeID") == null);

            Assert.IsNull(line.Element(NamespaceProvider.Cbc + "UUID"));
            Assert.IsNull(line.Element(NamespaceProvider.Cbc + "Note"));

            var free = line.Element(NamespaceProvider.Cbc + "FreeOfChargeIndicator");
            Assert.IsNotNull(free);
            Assert.AreEqual("true", free.Value);

            // Item node should exist
            var item = line.Element(NamespaceProvider.Cac + "Item");
            Assert.IsNotNull(item);
            Assert.AreEqual("Producto", item.Element(NamespaceProvider.Cbc + "Description")?.Value);

            // Price node should exist
            var price = line.Element(NamespaceProvider.Cac + "Price");
            Assert.IsNotNull(price);
            var priceAmt = price.Element(NamespaceProvider.Cbc + "PriceAmount");
            Assert.IsNotNull(priceAmt);
            Assert.AreEqual("99.00", priceAmt.Value);
            Assert.AreEqual("USD", priceAmt.Attribute("currencyID")?.Value);
        }
    }
}
