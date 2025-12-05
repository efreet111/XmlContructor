using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal  class AddressXmlFill
    {
        internal static XElement FillAddress(XmlBuildDLL.BaseClass.Modelresponse.Address adrs, String nameNode)
        {
            if (adrs != null)
            {
                XElement Address = new XElement(NamespaceProvider.Cac + nameNode);

                if (!String.IsNullOrWhiteSpace(adrs.ID))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "ID", adrs.ID));
                }

                if (!String.IsNullOrWhiteSpace(adrs.Postbox))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "Postbox", adrs.Postbox));
                }

                if (!String.IsNullOrWhiteSpace(adrs.Floor))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "Floor", adrs.Floor));
                }

                if (!String.IsNullOrWhiteSpace(adrs.Room))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "Room", adrs.Room));
                }

                if (!String.IsNullOrWhiteSpace(adrs.StreetName))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "StreetName", adrs.StreetName));
                }

                if (!String.IsNullOrWhiteSpace(adrs.AdditionalStreetName))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "AdditionalStreetName", adrs.AdditionalStreetName));
                }

                if (!String.IsNullOrWhiteSpace(adrs.BlockName))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "BlockName", adrs.BlockName));
                }

                if (!String.IsNullOrWhiteSpace(adrs.BuildingName))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "BuildingName", adrs.BuildingName));
                }

                if (!String.IsNullOrWhiteSpace(adrs.BuildingNumber))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "BuildingNumber", adrs.BuildingNumber));
                }

                if (!String.IsNullOrWhiteSpace(adrs.InhouseMail))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "InhouseMail", adrs.InhouseMail));
                }

                if (!String.IsNullOrWhiteSpace(adrs.MarkAttention))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "MarkAttention", adrs.MarkAttention));
                }

                if (!String.IsNullOrWhiteSpace(adrs.MarkCare))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "MarkCare", adrs.MarkCare));
                }

                if (!String.IsNullOrWhiteSpace(adrs.PlotIdentification))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "PlotIdentification", adrs.PlotIdentification));
                }

                if (!String.IsNullOrWhiteSpace(adrs.CitySubdivisionName))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "CitySubdivisionName", adrs.CitySubdivisionName));
                }

                if (!String.IsNullOrWhiteSpace(adrs.CityName))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "CityName", adrs.CityName));
                }

                if (!String.IsNullOrWhiteSpace(adrs.PostalZone))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "PostalZone", adrs.PostalZone));
                }

                if (!String.IsNullOrWhiteSpace(adrs.CountrySubentity))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "CountrySubentity", adrs.CountrySubentity));
                }

                if (!String.IsNullOrWhiteSpace(adrs.CountrySubentityCode))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "CountrySubentityCode", adrs.CountrySubentityCode));
                }

                if (!String.IsNullOrWhiteSpace(adrs.Region))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "Region", adrs.Region));
                }

                if (!String.IsNullOrWhiteSpace(adrs.District))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "District", adrs.District));
                }

                if (!String.IsNullOrWhiteSpace(adrs.TimezoneOffset))
                {
                    Address.Add(new XElement(NamespaceProvider.Cbc + "TimezoneOffset", adrs.TimezoneOffset));
                }

                if (!String.IsNullOrWhiteSpace(adrs.AddressLine))
                {
                    XElement AddressLine = new XElement(NamespaceProvider.Cac + "AddressLine");

                    AddressLine.Add(new XElement(NamespaceProvider.Cbc + "Line", adrs.AddressLine));

                    Address.Add(AddressLine);
                }

                if (!String.IsNullOrWhiteSpace(adrs.CountryIdentificationCode))
                {
                    XElement Country = new XElement(NamespaceProvider.Cac + "Country");

                    Country.Add(new XElement(NamespaceProvider.Cbc + "IdentificationCode", adrs.CountryIdentificationCode));

                    if (!String.IsNullOrWhiteSpace(adrs.CountryName) && !String.IsNullOrWhiteSpace(adrs.CountryLanguageID))
                    {
                        Country.Add(new XElement(NamespaceProvider.Cbc + "Name", adrs.CountryName, new XAttribute("languageID", adrs.CountryLanguageID)));
                    }

                    Address.Add(Country);
                }

                if (!String.IsNullOrWhiteSpace(adrs.LocationCoordinateLatitudeDegreesMeasure) && !String.IsNullOrWhiteSpace(adrs.LocationCoordinateLatitudeMinutesMeasure) && !String.IsNullOrWhiteSpace(adrs.LocationCoordinateLatitudeDirectionCode) && !String.IsNullOrWhiteSpace(adrs.LocationCoordinateLongitudeDegreesMeasure) && !String.IsNullOrWhiteSpace(adrs.LocationCoordinateLongitudeMinutesMeasure) && !String.IsNullOrWhiteSpace(adrs.LocationCoordinateLongitudeDirectionCode))
                {
                    XElement LocationCoordinate = new XElement(NamespaceProvider.Cac + "LocationCoordinate");

                    LocationCoordinate.Add(new XElement(NamespaceProvider.Cbc + "LatitudeDegreesMeasure", adrs.LocationCoordinateLatitudeDegreesMeasure, new XAttribute("unitCode", "A")));

                    LocationCoordinate.Add(new XElement(NamespaceProvider.Cbc + "LatitudeMinutesMeasure", adrs.LocationCoordinateLatitudeMinutesMeasure, new XAttribute("unitCode", "A")));

                    LocationCoordinate.Add(new XElement(NamespaceProvider.Cbc + "LatitudeDirectionCode", adrs.LocationCoordinateLatitudeDirectionCode));

                    LocationCoordinate.Add(new XElement(NamespaceProvider.Cbc + "LongitudeDegreesMeasure", adrs.LocationCoordinateLongitudeDegreesMeasure, new XAttribute("unitCode", "A")));

                    LocationCoordinate.Add(new XElement(NamespaceProvider.Cbc + "LongitudeMinutesMeasure", adrs.LocationCoordinateLongitudeMinutesMeasure, new XAttribute("unitCode", "A")));

                    LocationCoordinate.Add(new XElement(NamespaceProvider.Cbc + "LongitudeDirectionCode", adrs.LocationCoordinateLongitudeDirectionCode));

                    Address.Add(LocationCoordinate);
                }

                return Address;

            }

            return null;
        }
    }
}
