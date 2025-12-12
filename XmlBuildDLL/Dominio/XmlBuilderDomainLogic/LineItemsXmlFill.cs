using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//using XmlBuildDLL.BaseClass.XmlBodyComponent;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.Transversal;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal static class LineItemsXmlFill
    {

        internal static XElement FillLineItem( InvoiceLine line, string customizacionid, ref int cantidadDecimales)
        {
            if (line == null)
                return null;

            XElement item = new XElement(NamespaceProvider.Cac + "Item");

            if (!String.IsNullOrEmpty(line.DescripcionItem))
            {
                item.Add(new XElement(NamespaceProvider.Cbc + "Description", line.DescripcionItem));
            }

            if (!String.IsNullOrEmpty(line.DescripcionItem2))
            {
                item.Add(new XElement(NamespaceProvider.Cbc + "Description", line.DescripcionItem2));
            }

            if (!String.IsNullOrEmpty(line.DescripcionItem3))
            {
                item.Add(new XElement(NamespaceProvider.Cbc + "Description", line.DescripcionItem3));
            }

            if (line.PackSizeNumeric.HasValue)
                item.Add(new XElement(NamespaceProvider.Cbc + "PackSizeNumeric", line.PackSizeNumeric.Value.ToString(String.Format("F{0}", cantidadDecimales))));

            if (!String.IsNullOrEmpty(line.AdditionalInformation))
                item.Add(new XElement(NamespaceProvider.Cbc + "AdditionalInformation", line.AdditionalInformation));

            if (!String.IsNullOrEmpty(line.BrandName))
                item.Add(new XElement(NamespaceProvider.Cbc + "BrandName", line.BrandName));

            if (!String.IsNullOrEmpty(line.ModelName))
                item.Add(new XElement(NamespaceProvider.Cbc + "ModelName", line.ModelName));

            #region cac:BuyersItemIdentification

            XElement buyersItemIdentification = new XElement(NamespaceProvider.Cac + "BuyersItemIdentification");

            if (!String.IsNullOrEmpty(line.BuyersItemIdentificationID))
                buyersItemIdentification.Add(new XElement(NamespaceProvider.Cbc + "ID", line.BuyersItemIdentificationID,
                     new XAttribute("schemeAgencyID", line.BuyersItemIdentificationschemeAgencyID),
                     new XAttribute("schemeName", line.BuyersItemIdentificationschemeName)));

            if (buyersItemIdentification.HasElements)
                item.Add(buyersItemIdentification);

            #endregion

            #region cac:SellersItemIdentification

            XElement sellersItemIdentification = new XElement(NamespaceProvider.Cac + "SellersItemIdentification");

            if (!String.IsNullOrEmpty(line.SellersItemIdentification_ID))
                sellersItemIdentification.Add(new XElement(NamespaceProvider.Cbc + "ID", line.SellersItemIdentification_ID));

            if (!String.IsNullOrEmpty(line.SellersItemIdentification_ExtendedID))
                sellersItemIdentification.Add(new XElement(NamespaceProvider.Cbc + "ExtendedID", line.SellersItemIdentification_ExtendedID));

            if (sellersItemIdentification.HasElements)
                item.Add(sellersItemIdentification);

            #endregion

            #region cac:ManufacturersItemIdentification

            XElement manufacturersItemIdentification = new XElement(NamespaceProvider.Cac + "ManufacturersItemIdentification");

            if (!String.IsNullOrEmpty(line.ManufacturersItemIdentification_ID))
                manufacturersItemIdentification.Add(new XElement(NamespaceProvider.Cbc + "ID", line.ManufacturersItemIdentification_ID));

            if (!String.IsNullOrEmpty(line.ManufacturersItemIdentification_ExtendedID))
                manufacturersItemIdentification.Add(new XElement(NamespaceProvider.Cbc + "ExtendedID", line.ManufacturersItemIdentification_ExtendedID));

            if (!String.IsNullOrEmpty(line.PartyNameManufacturers))
                manufacturersItemIdentification.Add(new XElement(NamespaceProvider.Cac + "IssuerParty",
                    new XElement(NamespaceProvider.Cac + "PartyName",
                        new XElement(NamespaceProvider.Cbc + "Name", line.PartyNameManufacturers))
                    ));

            if (manufacturersItemIdentification.HasElements)
                item.Add(manufacturersItemIdentification);

            #endregion

            #region cac:StandardItemIdentification

            XElement standardItemIdentification = new XElement(NamespaceProvider.Cac + "StandardItemIdentification");

            if (!String.IsNullOrEmpty(line.StandardItemIdentification_ID))
            {
                XElement standardItemIdentification_ID = new XElement(NamespaceProvider.Cbc + "ID", line.StandardItemIdentification_ID);

                if (!String.IsNullOrEmpty(line.StandardItemIdentification_SchemeID))
                    standardItemIdentification_ID.Add(new XAttribute("schemeID", line.StandardItemIdentification_SchemeID));

                if (!String.IsNullOrEmpty(line.StandardItemIdentification_SchemeName))
                    standardItemIdentification_ID.Add(new XAttribute("schemeName", line.StandardItemIdentification_SchemeName));

                if (!String.IsNullOrEmpty(line.StandardItemIdentification_SchemeAgencyID))
                    standardItemIdentification_ID.Add(new XAttribute("schemeAgencyID", line.StandardItemIdentification_SchemeAgencyID));

                if (!String.IsNullOrEmpty(line.StandardItemIdentification_SchemeAgencyName))
                    standardItemIdentification_ID.Add(new XAttribute("schemeAgencyName", line.StandardItemIdentification_SchemeAgencyName));

                if (!String.IsNullOrEmpty(line.StandardItemIdentification_SchemeDataURI))
                    standardItemIdentification_ID.Add(new XAttribute("schemeDataURI", line.StandardItemIdentification_SchemeDataURI));

                standardItemIdentification.Add(standardItemIdentification_ID);
            }

            if (!String.IsNullOrEmpty(line.StandardItemIdentification_ExtendedID))
                standardItemIdentification.Add(new XElement(NamespaceProvider.Cbc + "ExtendedID", line.StandardItemIdentification_ExtendedID));


            if (!String.IsNullOrEmpty(line.StandardItemIdentificationName))
                standardItemIdentification.Add(new XElement(NamespaceProvider.Cac + "IssuerParty",
                    new XElement(NamespaceProvider.Cac + "PartyName",
                        new XElement(NamespaceProvider.Cbc + "Name", line.StandardItemIdentificationName))
                    ));


            if (standardItemIdentification.HasElements)
                item.Add(standardItemIdentification);

            #endregion

            #region cac:OriginCountry

            XElement originCountry = new XElement(NamespaceProvider.Cac + "OriginCountry");

            if (!String.IsNullOrEmpty(line.CountryIdentificationCode))
                originCountry.Add(new XElement(NamespaceProvider.Cbc + "IdentificationCode", line.CountryIdentificationCode));

            if (!String.IsNullOrEmpty(line.CountryName))
            {
                XElement lineCountryName = new XElement(NamespaceProvider.Cbc + "Name", line.CountryName);

                if (!String.IsNullOrEmpty(line.CountryLanguage))
                    lineCountryName.Add(new XAttribute("languageID", line.CountryLanguage));

                originCountry.Add(lineCountryName);
            }

            if (originCountry.HasElements)
                item.Add(originCountry);

            #endregion


            #region AdditionalItemProperty   

            XElement AdditionalItemProperty = new XElement(NamespaceProvider.Cac + "AdditionalItemProperty");

            if (line.AdditionalItemProperty != null)
            {
                foreach (AdditionalItemProperty altAppProp in line.AdditionalItemProperty)
                {
                    AdditionalItemProperty = new XElement(NamespaceProvider.Cac + "AdditionalItemProperty");

                    if (!String.IsNullOrEmpty(altAppProp.ID))
                        AdditionalItemProperty.Add(new XElement(NamespaceProvider.Cbc + "ID", altAppProp.ID));

                    if (!String.IsNullOrEmpty(altAppProp.Name))
                        AdditionalItemProperty.Add(new XElement(NamespaceProvider.Cbc + "Name", altAppProp.Name));

                    if (!String.IsNullOrEmpty(altAppProp.NameCode))
                        AdditionalItemProperty.Add(new XElement(NamespaceProvider.Cbc + "NameCode", altAppProp.NameCode));


                    if (!String.IsNullOrEmpty(altAppProp.Value))
                        AdditionalItemProperty.Add(new XElement(NamespaceProvider.Cbc + "Value", altAppProp.Value));

                    if (String.IsNullOrEmpty(altAppProp.ValueQuantity_unitCode))
                    {
                        if (!String.IsNullOrEmpty(altAppProp.ValueQuantity))
                            AdditionalItemProperty.Add(new XElement(NamespaceProvider.Cbc + "ValueQuantity", altAppProp.ValueQuantity));
                    }
                    else if (!String.IsNullOrEmpty(altAppProp.ValueQuantity_unitCode) && (customizacionid != "12" || altAppProp.Name != "03"))
                    {
                        AdditionalItemProperty.Add(new XElement(NamespaceProvider.Cbc + "ValueQuantity", altAppProp.ValueQuantity,
                            new XAttribute("unitCode", altAppProp.ValueQuantity_unitCode)));
                    }
                    else if (customizacionid == "12" && altAppProp.Name == "03")
                    {
                        if (!String.IsNullOrEmpty(altAppProp.ValueQuantity))
                            AdditionalItemProperty.Add(new XElement(NamespaceProvider.Cbc + "ValueQuantity", altAppProp.ValueQuantity,
                                new XAttribute("unitCode", altAppProp.ValueQuantity_unitCode)
                              ));

                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(altAppProp.ValueQuantity))
                            AdditionalItemProperty.Add(new XElement(NamespaceProvider.Cbc + "ValueQuantity", altAppProp.ValueQuantity));

                    }


                    if (AdditionalItemProperty.HasElements)
                        item.Add(AdditionalItemProperty);
                }
            }

            #endregion


            #region InformationContentProviderParty
            XElement InformationContentProviderParty = new XElement(NamespaceProvider.Cac + "InformationContentProviderParty");

            if (!String.IsNullOrEmpty(line.PowerOfAttorneyAgentPartyID))
            {

                XElement PartyIdentificationMandato = new XElement(NamespaceProvider.Cac + "PartyIdentification");

                XElement PartyIdentificationID = new XElement(NamespaceProvider.Cbc + "ID", line.PowerOfAttorneyAgentPartyID,
                    new XAttribute("schemeAgencyID", HelpersConstantes.Catalog.DIAN_ID),
                    new XAttribute("schemeAgencyName", HelpersConstantes.Catalog.DIAN_AgencyName)
                );

                if (!string.IsNullOrEmpty(line.PowerOfAttorneyAgentPartySchemeID))
                    PartyIdentificationID.Add(new XAttribute("schemeID", line.PowerOfAttorneyAgentPartySchemeID));

                if (!string.IsNullOrEmpty(line.PowerOfAttorneyAgentPartySchemeName))
                    PartyIdentificationID.Add(new XAttribute("schemeName", line.PowerOfAttorneyAgentPartySchemeName));

                PartyIdentificationMandato.Add(PartyIdentificationID);

                InformationContentProviderParty.Add(new XElement(NamespaceProvider.Cac + "PowerOfAttorney",
                    new XElement(NamespaceProvider.Cac + "AgentParty",
                        PartyIdentificationMandato
                    )));
            }

            if (InformationContentProviderParty.HasElements)
                item.Add(InformationContentProviderParty);

            #endregion


            #region ItemInstance SerialID

            if (line.ItemInstanceSerialID != null)
            {
                if (line.ItemInstanceSerialID.Count > 0)
                {
                    foreach (string serial in line.ItemInstanceSerialID)
                    {
                        if (!string.IsNullOrEmpty(serial))
                        {
                            XElement ItemInstance = new XElement(NamespaceProvider.Cac + "ItemInstance");

                            ItemInstance.Add(new XElement(NamespaceProvider.Cbc + "SerialID", serial.Trim()));

                            if (ItemInstance.HasElements)
                                item.Add(ItemInstance);
                        }
                    }
                }
            }

            #endregion


            if (item.HasElements)
            {
                return item;
            }
            else
            {
                return null;
            }
        }

    }

}

