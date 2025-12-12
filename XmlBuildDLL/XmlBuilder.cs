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
        /// <summary>Construye documento XML UBL.</summary>
        public BuildXmlResponse XmlDocument(OrquestatorXmlClass data)
        {
            BuildXmlResponse response = new BuildXmlResponse();

            try
            {
                BuilderXmlDominio buildDoc = new BuilderXmlDominio();

                data = HelperObjConverter<OrquestatorXmlClass>.FromJson(HelperObjConverter<OrquestatorXmlClass>.ToJson(data));

                response.xml = buildDoc.BuildXML(data);
                response.Codigo = 0; // Éxito
            }
            catch (Exception ex)
            {
                response.Codigo = -1;
                response.Mensaje = $"Error al construir XML: {ex.Message}";
            }

            return response;
        }
    }
}
