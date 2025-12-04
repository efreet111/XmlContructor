using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XmlBuildDLL.BaseClass;
using XmlBuildDLL.Dominio;
using XmlBuildDLL.Response;
using XmlBuildDLL.Transversal;

namespace XmlBuildDLL
{
    public class XmlBuilder
    {
        public BuildXmlResponse XmlDocument(OrquestatorXmlClass data)
        {
            BuildXmlResponse response = new BuildXmlResponse();

            BuilderXmlDominio buildDoc = new BuilderXmlDominio();

            data = HelperObjConverter<OrquestatorXmlClass>.FromJson(HelperObjConverter<OrquestatorXmlClass>.ToJson(data));

            response.xml = buildDoc.BuildXML(data);

            return response;
        }
    }
}
