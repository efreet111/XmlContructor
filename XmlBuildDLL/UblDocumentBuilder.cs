using System.Collections.Generic;
using XmlBuildDLL.Aplicacion;
using XmlBuildDLL.BaseClass.Modelresponse;
using XmlBuildDLL.DocumentClass.UBL2._1;
using XmlBuildDLL.Dominio;
using XmlBuildDLL.Transversal;

namespace XmlBuildDLL
{
    public class UblDocumentBuilder
    {
        /// <summary>Construye documento UBL 2.1.</summary>
        public BuildXmlResponse Build(BillingDocument21Object data, ref int cantidadDecimales, List<string> nombres)
        {
            BuildXmlResponse response = new BuildXmlResponse();

            try
            {
                BuilderXmlInvoiceDominio buildDoc = null;

                switch (data.InvoiceTypeCode)
                {
                    case HelpersConstantes.TipoDocumento.Fact:
                    case HelpersConstantes.TipoDocumento.FactExportacion:
                    case HelpersConstantes.TipoDocumento.FactContingenciaEmisor:
                    case HelpersConstantes.TipoDocumento.FactContingenciaDian:
                    case HelpersConstantes.TipoDocumento.FactDocumentoSoporte:
                         buildDoc = new BuilderXmlInvoiceDominio();
                        break;

                    case HelpersConstantes.TipoDocumento.NC:
                        //buildDoc = new Builder.UBL2._1.CreditNote();
                        break;

                    case HelpersConstantes.TipoDocumento.ND:
                        //buildDoc = new Builder.UBL2._1.DebitNote();
                        break;

                    case HelpersConstantes.TipoDocumento.NotaAjusteDocumentoSoporte:
                        // se reutiliza la de nota crédito pero espera cambiarlo
                        //buildDoc = new Builder.UBL2._1.CreditNote();
                        break;

                    default:
                        buildDoc = new BuilderXmlInvoiceDominio();
                        break;
                }

                data = HelperObjConverter<BillingDocument21Object>.FromJson(HelperObjConverter<BillingDocument21Object>.ToJson(data));

                response.XmlFile = buildDoc.BuildXML(data, ref cantidadDecimales, nombres);
                response.Codigo = 0; // Éxito
            }
            catch (Exception ex)
            {
                response.Codigo = -1;
                response.Mensaje = $"Error al construir documento UBL: {ex.Message}";
            }

            return response;
        }
    }
}
