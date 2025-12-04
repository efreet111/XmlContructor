using System;
using System.Collections.Generic;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
  
  /// root/de:AccountingSupplierParty
  
  public class AcountingSupplierParty
  {
    
    /// root/de:AccountingSupplierParty/cbc:AdditionalAccountID
    
    public int AdditionalAccountID { get; set; }

    
    /// root/de:AccountingSupplierParty/cbc:AdditionalAccountID/@schemeAgencyID 
    
    public String AdditionalAccountID_SchemeAgencyID { get; set; }

    
    /// root/de:AccountingSupplierParty/cbc:AdditionalAccountID/@schemeName
    
    public String AdditionalAccountID_SchemeName { get; set; }

    
    /// root/de:AccountingSupplierParty/cbc:AdditionalAccountID/@schemeID
    
    public String AdditionalAccountID_SchemeID { get; set; }

    
    /// root/de:AccountingSupplierParty/de:Party/cac:PartyName/cbc:Name
    
    public String PartyName { get; set; }
             
    ///root/de:AccountingSupplierParty/de:PhysicalLocation/de:Address
    
    public Address PhysicalLocation { get; set; }
    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme
    
    public PartyTaxScheme TaxScheme { get; set; }
    
    ///root/de:AccountingSupplierParty/de:Party/de:IndustryClassificationCode
    
    public String IndustryClassificationCode { get; set; }
    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity
    
    public PartyLegalEntity LegalEntity { get; set; }

    public AcountingSupplierPartyContact ASContact { get; set; }

    public List<ShareHolderParty> shareHolder { get; set; }
  }

  
  ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity
  
  public class PartyLegalEntity
  {
    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/cac:RegistrationName
    
    public String RegistrationName { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/cac:CompanyID
    
    public String CompanyID { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/cac:CompanyID/@schemeID
    
    public String CompanySchemeID { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/cac:CompanyID/@schemeName
    
    public String CompanySchemeName { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/cac:CompanyID/@schemeAgencyName
    
    public String CompanySchemeAgencyName { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/cac:CompanyID/@schemeAgencyID
    
    public String CompanySchemeAgencyID { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/cac:CorporateRegistrationScheme/cbc:CorporateRegistrationTypeCode
    
    public String CorporateRegistrationTypeCode { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/cac:CorporateRegistrationScheme/cbc:ID
    
    public String CorporateRegistrationID { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/cac:CorporateRegistrationScheme/cbc:Name
    
    public String CorporateRegistrationName { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/de:ShareholderParty/cac:PartecipationPercent
    
    public String SupplierPartyPartecipationPercent { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/de:ShareholderParty/de:Party/de:PartyTaxScheme/cbc:RegistrationName
    
    public String SupplierPartyRegistrationName { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/de:ShareholderParty/de:Party/de:PartyTaxScheme/cbc:CompanyID
    
    public Int32? SupplierPartyCompanyID { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/de:ShareholderParty/de:Party/de:PartyTaxScheme/cbc:CompanyID@schemeAgencyID
    
    public Int32? SupplierPartyCompanyschemeAgencyID { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/de:ShareholderParty/de:Party/de:PartyTaxScheme/cbc:CompanyID@schemeAgencyName
    
    public String SupplierPartyCompanyschemeAgencyName { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/de:ShareholderParty/de:Party/de:PartyTaxScheme/cbc:CompanyID@schemeID
    
    public Int32? SupplierPartyCompanyschemeID { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/de:ShareholderParty/de:Party/de:PartyTaxScheme/cbc:CompanyID@schemeName
    
    public String SupplierPartyCompanyschemeName { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/de:ShareholderParty/de:Party/de:PartyTaxScheme/cbc:TaxLevelCode
    
    public String SupplierPartyTaxLevelCode { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/de:ShareholderParty/de:Party/de:PartyTaxScheme/cbc:TaxLevelCode@listName
    
    public String SupplierPartyTaxLevellistName { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/de:ShareholderParty/de:Party/de:PartyTaxScheme/cac:TaxScheme
    
    public String SupplierPartyTaxScheme { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/de:ShareholderParty/de:Party/de:PartyTaxScheme/de:TaxScheme/cbc:ID
    
    public String SupplierPartyTaxSchemeID { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyLegalEntity/de:ShareholderParty/de:Party/de:PartyTaxScheme/de:TaxScheme/cbc:Name
    
    public String SupplierPartyTaxSchemeName { get; set; }
  }

  
  /// root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme
  
  public class PartyTaxScheme
  {
    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme/cbc:RegistrationName
    
    public String RegistrationName { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme/cbc:CompanyID
    
    public String CompanyID { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme/cbc:CompanyID/@schemeID
    
    public String SchemeID { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme/cbc:CompanyID/@schemeName
    
    public String SchemeName { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme/cbc:CompanyID/@schemeAgencyName
    
    public String SchemeAgencyName { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme/cbc:CompanyID/@schemeAgencyID
    
    public String SchemeAgencyID { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme/cbc:TaxLevelCode
    
    public String TaxLevelCode { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme/cbc:TaxLevelCode/@listName
    
    public String TaxLevelCodeListName { get; set; }

    
    /// root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme
    
    public String TaxSchemeID { get; set; }

    
    /// root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme/cac:RegistrationAddress
    
    public Address RegistrationAddress { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:PartyTaxScheme
    
    public String TaxSchemeName { get; set; }
  }

  public class AcountingSupplierPartyContact
  {
    
    ///root/de:AccountingSupplierParty/de:Party/de:Contact/cbc:Name
    
    public string Name { get; set; }


    
    ///root/de:AccountingSupplierParty/de:Party/de:Contact/cbc:Telephone
    
    public string Telephone { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:Contact/cbc:-Telefax
    
    public string Telefax { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:Contact/cbc:ElectronicMail
    
    public string ElectronicMail { get; set; }

    
    ///root/de:AccountingSupplierParty/de:Party/de:Contact/cbc:Note
    
    public string Note { get; set; }
  }

  public class ShareHolderParty
  {
    
    ////Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:ShareholderParty/cbc:PartecipationPercent
    
    public String PartecipationPercent { get; set; }

    
    ////Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:ShareholderParty/cac:Party/cac:PartyTaxScheme/cbc:RegistrationName
    
    public String RegistrationName { get; set; }

    
    ////Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:ShareholderParty/cac:Party/cac:PartyTaxScheme/cbc:CompanyID
    
    public String CompanyID { get; set; }

    
    ////Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:ShareholderParty/cac:Party/cac:PartyTaxScheme/cbc:CompanyID/@schemeAgencyID
    
    public String schemeAgencyID { get; set; }

    
    ////Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:ShareholderParty/cac:Party/cac:PartyTaxScheme/cbc:CompanyID/@schemeAgencyName
    
    public String schemeAgencyName { get; set; }

    
    ////Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:ShareholderParty/cac:Party/cac:PartyTaxScheme/cbc:CompanyID/@schemeID
    
    public String schemeID { get; set; }

    
    ////Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:ShareholderParty/cac:Party/cac:PartyTaxScheme/cbc:CompanyID/@schemeName
    
    public String schemeName { get; set; }

    
    ////Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:ShareholderParty/cac:Party/cac:PartyTaxScheme/cbc:TaxLevelCode
    
    public String TaxLevelCode { get; set; }

    
    ////Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:ShareholderParty/cac:Party/cac:PartyTaxScheme/cbc:TaxLevelCode/@listName
    
    public String TaxLevelCodeListName { get; set; }

    
    ////Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:ShareholderParty/cac:Party/cac:PartyTaxScheme/cac:TaxScheme/cbc:ID
    
    public String ID_TaxScheme { get; set; }

    
    ///Invoice/cac:AccountingSupplierParty/cac:Party/cac:PartyLegalEntity/cac:ShareholderParty/cac:Party/cac:PartyTaxScheme/cac:TaxScheme/cbc:ID
    
    public String Name_TaxScheme { get; set; }
  }
}
