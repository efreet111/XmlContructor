using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
  public class InvoicePeriod
  {
    
    /// ../cac:InvoicePeriod/cbc:StartDate
    
    public DateTime? StartDate { get; set; }

    
    /// ../cac:InvoicePeriod/cbc:StartTime
    
    public DateTime? StartTime { get; set; }

    
    /// ../cac:InvoicePeriod/cbc:EndDate
    
    public DateTime? EndDate { get; set; }

    
    /// ../cac:InvoicePeriod/cbc:EndTime
    
    public DateTime? EndTime { get; set; }

    
    /// ../cac:InvoicePeriod/cbc:DurationMeasure
    
    public String DurationMeasure { get; set; }

    
    /// ../cac:InvoicePeriod/cbc:DescriptionCode
    
    public String DescriptionCode { get; set; }

    
    /// ../cac:InvoicePeriod/cbc:Description
    
    public String Description { get; set; }

  }
}
