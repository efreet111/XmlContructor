using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
    
    /// ../de:Address
    
    /// 
    public class Address
    {
        public String ID { get; set; }

        
        /// ../de:Address/cbc:Postbox
        
        /// 
        public String Postbox { get; set; }

        
        /// ../de:Address/cbc:Floor
        
        /// 
        public String Floor { get; set; }

        
        /// ../de:Address/cbc:Room
        
        /// 
        public String Room { get; set; }

        
        /// ../de:Address/cbc:StreetName
        
        /// 
        public String StreetName { get; set; }

        
        /// ../de:Address/cbc:AdditionalStreetName
        
        /// 
        public String AdditionalStreetName { get; set; }

        
        /// ../de:Address/cbc:BlockName
        
        /// 
        public String BlockName { get; set; }

        
        /// ../de:Address/cbc:BuildingName
        
        /// 
        public String BuildingName { get; set; }

        
        /// ../de:Address/cbc:BuildingNumber
        
        /// 
        public String BuildingNumber { get; set; }

        
        /// ../de:Address/cbc:InhouseMail
        
        /// 
        public String InhouseMail { get; set; }

        
        /// ../de:Address/cbc:Department
        
        /// 
        public String Department { get; set; }

        
        /// ../de:Address/cbc:MarkAttention
        
        /// 
        public String MarkAttention { get; set; }

        
        /// ../de:Address/cbc:MarkCare
        
        /// 
        public String MarkCare { get; set; }

        
        /// ../de:Address/cbc:PlotIdentification
        
        /// 
        public String PlotIdentification { get; set; }

        
        /// ../de:Address/cbc:CitySubdivisionName
        
        /// 
        public String CitySubdivisionName { get; set; }

        
        /// ../de:Address/cbc:CityName
        
        /// 
        public String CityName { get; set; }

        
        /// ../de:Address/cbc:PostalZone
        
        /// 
        public String PostalZone { get; set; }

        
        /// ../de:Address/cbc:CountrySubentity
        
        /// 
        public String CountrySubentity { get; set; }

        
        /// ../de:Address/cbc:CountrySubentityCode
        
        /// 
        public String CountrySubentityCode { get; set; }

        
        /// ../de:Address/cbc:Region
        
        /// 
        public String Region { get; set; }

        
        /// ../de:Address/cbc:District
        
        /// 
        public String District { get; set; }

        
        /// ../de:Address/cbc:TimezoneOffset
        
        /// 
        public String TimezoneOffset { get; set; }

        
        /// ../de:Address/cac:AddressLine/cbc:Line
        
        /// 
        public String AddressLine { get; set; }

        
        /// ../de:Address/cac:Country/cbc:IdentificationCode
        
        /// 
        public String CountryIdentificationCode { get; set; }

        
        /// ../de:Address/cac:Country/cbc:Name
        
        /// 
        public String CountryName { get; set; }

        
        /// ../de:Address/cac:Country/cbc:Name/@languageID
        
        /// 
        public String CountryLanguageID { get; set; } //@languageID

        
        /// ../de:Address/cac:LocationCoordinate/cbc:LatitudeDegreesMeasure
        
        /// 
        public String LocationCoordinateLatitudeDegreesMeasure { get; set; }

        
        /// ../de:Address/cac:LocationCoordinate/cbc:LatitudeMinutesMeasure
        
        /// 
        public String LocationCoordinateLatitudeMinutesMeasure { get; set; }

        
        /// ../de:Address/cac:LocationCoordinate/cbc:LatitudeDirectionCode
        
        /// 
        public String LocationCoordinateLatitudeDirectionCode { get; set; }

        
        /// ../de:Address/cac:LocationCoordinate/cbc:LongitudeDegreesMeasure
        
        /// 
        public String LocationCoordinateLongitudeDegreesMeasure { get; set; }

        
        /// ../de:Address/cac:LocationCoordinate/cbc:LongitudeMinutesMeasure
        
        /// 
        public String LocationCoordinateLongitudeMinutesMeasure { get; set; }

        
        /// ../de:Address/cac:LocationCoordinate/cbc:LongitudeDirectionCode
        
        /// 
        public String LocationCoordinateLongitudeDirectionCode { get; set; }
    }
}
