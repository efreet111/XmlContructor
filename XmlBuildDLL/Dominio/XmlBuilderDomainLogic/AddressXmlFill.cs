using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XmlBuildDLL.BaseClass;

namespace XmlBuildDLL.Dominio.XmlBuilderDomainLogic
{
    internal class AddressXmlFill
    {
        public static XElement Address(Address address)
        {

            var fe = NamespaceProvider.Fe;
            var cac = NamespaceProvider.Cac;
            var cbc = NamespaceProvider.Cbc;
            if (address != null)
            {
                XElement PhysicalLocation = new XElement(fe + "PhysicalLocation");

                XElement Address = new XElement(fe + "Address");

                if (address.Department != "")
                    Address.Add(new XElement(cbc + "Department", address.Department));

                if (address.CitySubdivisionName != "")
                    Address.Add(new XElement(cbc + "CitySubdivisionName", address.CitySubdivisionName));

                if (address.CityName != "")
                    Address.Add(new XElement(cbc + "CityName", address.CityName));

                if (address.AddressLine != "")
                    Address.Add(new XElement(cac + "AddressLine",
                        new XElement(cbc + "Line", address.AddressLine)
                        ));

                if (address.Country != "")
                    Address.Add(new XElement(cac + "Country",
                        new XElement(cbc + "IdentificationCode", address.Country)
                        ));

                if (Address.HasElements)
                    PhysicalLocation.Add(Address);

                if (PhysicalLocation.HasElements)
                    return PhysicalLocation;
            }
            else
            {
                return null;
            }

            return null;
        }

    }
}
