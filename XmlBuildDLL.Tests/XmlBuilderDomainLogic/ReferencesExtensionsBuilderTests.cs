using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XmlBuildDLL.Dominio.XmlBuilderDomainLogic;
using XmlBuildDLL.BaseClass;
using XmlBuildDLL.BaseClass.XmlBodyComponent;
using System.Collections.Generic;
using XmlBuildDLL.BaseClass.Dianheaders;

namespace XmlBuildDLL.Tests.XmlBuilderDomainLogic
{
    [TestClass]
    public class ReferencesExtensionsBuilderTests
    {
        [TestMethod]
        public void AddReferencesExtensions_ValidData_AddsElements()
        {
            XElement ePadre = new XElement("Root");
            var docObj = new OrquestatorXmlClass
            {
                Order_Reference = new OrderReference { ID = "ORD001" },
                BodyXml = new BodyXml { DespatchDocumentRefID = "DREF001" },
                ReceiptDocumentReferences = new List<ReceiptDocumentRef>
                {
                    new ReceiptDocumentRef { ID = "REC001", IssueDate = "2023-09-01", UUID = "uuid-rec" }
                }
            };
            ReferencesExtensionsBuilder.AddReferencesExtensions(ePadre, docObj);
            Assert.IsTrue(ePadre.HasElements);
            Assert.IsNotNull(ePadre.Element(NamespaceProvider.Cbc + "OrderReference"));
        }
    }
}
