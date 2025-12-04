using System.Collections.Generic;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
  public class PartyPerson
  {
    
    ///root/de:AccountingCustomerParty/de:Party/de:Person/cbc:ID
    
    public string ID { get; set; }

    
    ///root/de:AccountingCustomerParty/de:Party/de:Person/cbc:ID@schemeID
    
    public string schemeID { get; set; }

    
    ///root/de:AccountingCustomerParty/de:Party/de:Person/cbc:ID@schemeName
    
    public string schemeName { get; set; }

    
    ///root/de:AccountingCustomerParty/de:Party/de:Person/cbc:FirstName
    
    public string FirstName { get; set; }

    
    ///root/de:AccountingCustomerParty/de:Party/de:Person/cbc:FamilyName
    
    public string FamilyName { get; set; }

    public PartyPersonIdentityDocumentReference IdentityDocumentReference { get; set; }

    public ResidenceAddress ResidenceAddress { get; set; }
  }
}
