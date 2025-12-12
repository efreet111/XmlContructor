using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.DocumentClass.UBL2._1;
using XmlBuildDLL.BaseClass.Modelresponse; // LegalMonetaryTotal

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class InvoiceLegalMonetaryTotalXmlFillTests_Extra
    {
        [TestMethod]
        public void FillInvoiceLegalMonetaryTotal_BuildsAllAmounts_WithCurrencies()
        {
            var obj = new BillingDocument21Object
            {
                LegalMonetaryTotal = new LegalMonetaryTotal
                {
                    LineExtensionAmount = 1000m,
                    LineExtensionAmount_currencyID = "COP",
                    TaxExclusiveAmount = 900m,
                    TaxExclusiveAmount_currencyID = "COP",
                    TaxInclusiveAmount = 1070m,
                    TaxInclusiveAmount_currencyID = "COP",
                    AllowanceTotalAmount = 30m,
                    AllowanceTotalAmount_currencyID = "COP",
                    ChargeTotalAmount = 100m,
                    ChargeTotalAmount_currencyID = "COP",
                    PrepaidAmount = 10m,
                    PrepaidAmount_currencyID = "COP",
                    PayableRoundingAmount = 0.5m,
                    PayableRoundingAmount_currencyID = "COP",
                    PayableAmount = 1060m,
                    PayableAmount_currencyID = "COP"
                }
            };

            int dec = 2;
            var node = InvoiceLegalMonetaryTotalXmlFill.FillInvoiceLegalMonetaryTotal("LegalMonetaryTotal", ref dec, obj);

            Assert.IsNotNull(node);
            Assert.AreEqual("LegalMonetaryTotal", node.Name.LocalName);

            Assert.AreEqual("1000.00", node.Element(NamespaceProvider.Cbc + "LineExtensionAmount")?.Value);
            Assert.AreEqual("COP", node.Element(NamespaceProvider.Cbc + "LineExtensionAmount")?.Attribute("currencyID")?.Value);

            Assert.AreEqual("900.00", node.Element(NamespaceProvider.Cbc + "TaxExclusiveAmount")?.Value);
            Assert.AreEqual("COP", node.Element(NamespaceProvider.Cbc + "TaxExclusiveAmount")?.Attribute("currencyID")?.Value);

            Assert.AreEqual("1070.00", node.Element(NamespaceProvider.Cbc + "TaxInclusiveAmount")?.Value);
            Assert.AreEqual("COP", node.Element(NamespaceProvider.Cbc + "TaxInclusiveAmount")?.Attribute("currencyID")?.Value);

            Assert.AreEqual("30.00", node.Element(NamespaceProvider.Cbc + "AllowanceTotalAmount")?.Value);
            Assert.AreEqual("COP", node.Element(NamespaceProvider.Cbc + "AllowanceTotalAmount")?.Attribute("currencyID")?.Value);

            Assert.AreEqual("100.00", node.Element(NamespaceProvider.Cbc + "ChargeTotalAmount")?.Value);
            Assert.AreEqual("COP", node.Element(NamespaceProvider.Cbc + "ChargeTotalAmount")?.Attribute("currencyID")?.Value);

            Assert.AreEqual("10.00", node.Element(NamespaceProvider.Cbc + "PrepaidAmount")?.Value);
            Assert.AreEqual("COP", node.Element(NamespaceProvider.Cbc + "PrepaidAmount")?.Attribute("currencyID")?.Value);

            Assert.AreEqual("0.50", node.Element(NamespaceProvider.Cbc + "PayableRoundingAmount")?.Value);
            Assert.AreEqual("COP", node.Element(NamespaceProvider.Cbc + "PayableRoundingAmount")?.Attribute("currencyID")?.Value);

            Assert.AreEqual("1060.00", node.Element(NamespaceProvider.Cbc + "PayableAmount")?.Value);
            Assert.AreEqual("COP", node.Element(NamespaceProvider.Cbc + "PayableAmount")?.Attribute("currencyID")?.Value);
        }
    }
}
