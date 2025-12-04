namespace XmlBuildDLL.BaseClass.Modelresponse
{
  public class ResidenceAddress
  {

    
    ///root/de:AccountingCustomerParty/de:Party/de:Person/de:ResidenceAddress/cbc:ID
    
    public string ID { get; set; }

    
    ///root/de:AccountingCustomerParty/de:Party/de:Person/de:ResidenceAddress/cbc:ID@schemeName
    
    public string schemeName { get; set; }


    
    ///root/de:AccountingCustomerParty/de:Party/de:Person/de:ResidenceAddress/cbc:CityName
    
    public string CityName { get; set; }

    
    ///root/de:AccountingCustomerParty/de:Party/de:Person/de:ResidenceAddress/de:AddressLine/cbc:Line
    
    public string Line { get; set; }

    
    ///root/de:AccountingCustomerParty/de:Party/de:Person/de:ResidenceAddress/de:Country/cbc:Name
    
    public string CountryName { get; set; }
  }
}
