using System;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
  
  //de:Invoice/cac:PaymentMeans
  
  public class PaymentMeans
  {
    
    //de:Invoice/cac:PaymentMeans/cbc:ID
    
    public string ID { get; set; }

    
    //de:Invoice/cac:PaymentMeans/cbc:ID/@schemeName
    
    public string IdSchemeName { get; set; }

    
    //de:Invoice/cac:PaymentMeans/cbc:ID/@schemeID
    
    public string IdSchemeId { get; set; }

    
    //de:Invoice/cac:PaymentMeans/cbc:PaymentMeansCode
    
    public string PaymentMeansCode { get; set; }

    
    //de:Invoice/cac:PaymentMeans/cbc:PaymentDueDate
    
    public DateTime? PaymentDueDate { get; set; }

    
    //de:Invoice/cac:PaymentMeans/cbc:PaymentChannelCode
    
    public string PaymentChannelCode { get; set; }

    
    //de:Invoice/cac:PaymentMeans/cbc:PaymentID
    
    public string PaymentID { get; set; }

    
    //de:Invoice/cac:PaymentMeans/cbc:InstructionID
    
    public string InstructionID { get; set; }

    
    //de:Invoice/cac:PaymentMeans/cbc:InstructionNote
    
    public string InstructionNote { get; set; }

    
    //de:Invoice/cac:PaymentMeans/de:PayeeFinancialAccount/cbc:AccountTypeCode
    
    public string PayeeFinancialAccountTypeCode { get; set; }

    
    //de:Invoice/cac:PaymentMeans/de:PayeeFinancialAccount/cbc:Name
    
    public string PayeeFinancialAccountName { get; set; }

    
    //de:Invoice/cac:PaymentMeans/de:PayeeFinancialAccount/cbc:ID
    
    public string PayeeFinancialAccountID { get; set; }
  }
}
