using System;
using System.Collections.Generic;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    public class InvoiceLine
    {
        
        ///de:Invoice/de:InvoiceLine/cbc:ID
        
        public int ID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/cbc:ID/@schemeID
        
        public string ID_schemeID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/cbc:UUID
        
        public String UUID { get; set; }

        
        ////de:Invoice/de:InvoiceLine/cbc:Note
        
        public String Note { get; set; }

        
        ///de:Invoice/de:InvoiceLine/cbc:LineExtensionAmount
        
        public decimal LineExtensionAmount { get; set; }

        
        ///de:Invoice/de:InvoiceLine/cbc:LineExtensionAmount/@currencyID
        
        public String LineExtensionAmountCurrencyID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/cbc:FreeOfChargeIndicator
        
        public bool FreeOfChargeIndicator { get; set; }

        
        ///  de:Invoice/de:InvoiceLine/de:Price/cbc:PriceAmount
        
        public decimal PriceAmount { get; set; }

        
        ///  de:Invoice/de:InvoiceLine/de:Price/cbc:PriceAmount/@currencyID
        
        public String PriceAmount_currencyID { get; set; }

        
        /// de:Invoice/de:InvoiceLine/de:Price/cbc:Quantity
        
        public decimal Quantity { get; set; }

        
        /// de:Invoice/de:InvoiceLine/de:Price/cbc:Quantity/@unitCode
        
        public String Quantity_unitCode { get; set; }

        
        /// de:Invoice/de:InvoiceLine/de:Price/cbc:BaseQuantity
        
        public decimal BaseQuantity { get; set; }

        
        /// de:Invoice/de:InvoiceLine/de:Price/cbc:BaseQuantity/@unitCode
        
        public String BaseQuantity_unitCode { get; set; }

        
        /// de:Invoice/de:InvoiceLine/cac:AllowanceCharge
        
        /// cambiar por el objeto
        public List<AllowanceCharge> AllowanceCharge { get; set; }

        
        ///de:Invoice/de:InvoiceLine/cac:TaxTotal
        
        public List<TaxTotal> TaxTotal { get; set; }

        
        ///root/cac:InvoiceLine/cac:WithholdingTaxTotal
        
        public List<WithholdingTaxTotal> WithholdingTaxTotal { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cbc:Description
        
        public String DescripcionItem { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cbc:Description
        
        public String DescripcionItem2 { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cbc:Description
        
        public String DescripcionItem3 { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cbc:PackSizeNumeric
        
        public decimal? PackSizeNumeric { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cbc:AdditionalInformation
        
        public String AdditionalInformation { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cbc:BrandName
        
        public String BrandName { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cbc:ModelName
        
        public String ModelName { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cbc:BuyersItemIdentification/ID
        
        public String BuyersItemIdentificationID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cbc:BuyersItemIdentification/ID@schemeAgencyID
        
        public String BuyersItemIdentificationschemeAgencyID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cbc:BuyersItemIdentification/ID@schemeName
        
        public String BuyersItemIdentificationschemeName { get; set; }


        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:SellersItemIdentification/cbc:ID
        
        public String SellersItemIdentification_ID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:SellersItemIdentification/cbc:ExtendedID
        
        public String SellersItemIdentification_ExtendedID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:ManufacturersItemIdentification/cbc:ID
        
        public String ManufacturersItemIdentification_ID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:ManufacturersItemIdentification/cbc:ExtendedID
        
        public String ManufacturersItemIdentification_ExtendedID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:ManufacturersItemIdentification/cac:IssuerParty/cac:PartyName/cbc:Name
        
        public String PartyNameManufacturers { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:StandardItemIdentification/cbc:ID
        
        public String StandardItemIdentification_ID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:StandardItemIdentification/cbc:ID/@schemeID
        
        public String StandardItemIdentification_SchemeID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:StandardItemIdentification/cbc:ID/@schemeID_name
        
        public String StandardItemIdentification_SchemeName { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:StandardItemIdentification/cbc:ID/@schemeAgencyID
        
        public String StandardItemIdentification_SchemeAgencyID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:StandardItemIdentification/cbc:ID/@schemeAgencyName
        
        public String StandardItemIdentification_SchemeAgencyName { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:StandardItemIdentification/cbc:ID/@schemeDataURI
        
        public String StandardItemIdentification_SchemeDataURI { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:StandardItemIdentification/cbc:ID/@ExtendedID
        
        public String StandardItemIdentification_ExtendedID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:StandardItemIdentification/cac:IssuerParty/cac:PartyName/cbc:Name
        
        public String StandardItemIdentificationName { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:OriginCountry/cbc:IdentificationCode
        
        public String CountryIdentificationCode { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:OriginCountry/cbc:Name
        
        public String CountryName { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:OriginCountry/cbc:Name/@languageID
        
        public String CountryLanguage { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cac:AdditionalItemProperty
        
        public List<AdditionalItemProperty> AdditionalItemProperty { get; set; }

        
        ///de:CreditNote/de:CreditNoteLine/cbc:CreditedQuantity
        
        public decimal CreditedQuantity { get; set; }

        
        ///de:CreditNote/de:CreditNoteLine/cbc:TaxPointDate
        
        public string TaxPointDate { get; set; }

        
        ///de:CreditNote/de:CreditNoteLine/cac:DiscrepancyResponse
        
        public List<DiscrepancyResponse> DiscrepancyCreditLine { get; set; }

        
        ///de:CreditNote/de:CreditNoteLine/cac:Delivery
        
        public Delivery DeliveryCreditLine { get; set; }

        public List<AlternativeConditionPrice> AlternativeConditionPrice { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/de:InformationContentProviderParty/de:PowerOfAttorney/de:AgentParty/cbc:ID
        
        public String PowerOfAttorneyAgentPartyID { get; set; }

        
        ///root/cac:InvoiceLine/cac:Item/cac:InformationContentProviderParty/cac:PowerOfAttorney/cac:AgentParty/cac:PartyIdentification/cbc:ID@schemeID
        
        public String PowerOfAttorneyAgentPartySchemeID { get; set; }

        
        ///root/cac:InvoiceLine/cac:Item/cac:InformationContentProviderParty/cac:PowerOfAttorney/cac:AgentParty/cac:PartyIdentification/cbc:ID@schemeName
        
        public String PowerOfAttorneyAgentPartySchemeName { get; set; }

        
        ///root/cac:InvoiceLine/cac:Item/de:ItemInstance/cbc:SerialID
        
        public List<String> ItemInstanceSerialID { get; set; }
        
        ///root/cac:InvoiceLine/cbc:InvoicePeriod
        
        public List<InvoicePeriod> InvoicePeriod { get; set; }
    }

    public class AdditionalItemProperty
    {
        
        ///de:Invoice/de:InvoiceLine/cbc:ID
        
        public String ID { get; set; }

        
        ////de:Invoice/de:InvoiceLine/cbc:Note
        
        public String Name { get; set; }

        
        ///de:Invoice/de:InvoiceLine/cbc:LineExtensionAmount
        
        public String NameCode { get; set; }

        
        ///de:Invoice/de:InvoiceLine/cbc:LineExtensionAmount/@currencyID
        
        public String Value { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/de:AdditionalItemProperty/de:UsabilityPeriod/cbc:StartDate
        
        public DateTime? StartDate { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/de:AdditionalItemProperty/de:UsabilityPeriod/cbc:EndDate
        
        public DateTime? EndDate { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/de:AdditionalItemProperty/de:UsabilityPeriod/cbc:EndDate
        
        public String Description { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cbc:Description
        
        public String DescripcionItem2 { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/cbc:Description
        
        public String DescripcionItem3 { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/de:AdditionalItemProperty/cbc:ValueQuantity
        
        public String ValueQuantity { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:Item/de:AdditionalItemProperty/cbc:ValueQuantity@unitCode
        
        public String ValueQuantity_unitCode { get; set; }

    }

    public class AlternativeConditionPrice
    {
        
        ///de:Invoice/de:InvoiceLine/de:PricingReference/de:AlternativeConditionPrice/cbc:PriceAmount
        
        public decimal? PriceAmount { get; set; }

        
        ////de:Invoice/de:InvoiceLine/de:PricingReference/de:AlternativeConditionPrice/PriceAmount@currencyID
        
        public string PriceAmount_currencyID { get; set; }

        
        ///de:Invoice/de:InvoiceLine/de:PricingReference/de:AlternativeConditionPrice/cbc:PriceTypeCode
        
        public String PriceTypeCode { get; set; }
    }
}
