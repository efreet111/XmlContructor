using XmlBuildDLL.BaseClass.Modelresponse;
using System.Collections.Generic;
using XmlBuildDLL.DocumentClass.UBL2._1;

namespace XmlBuildDLL
{
    public class UblDocumentBuilder
    {
        public BuildResponse Build(BaseDocument21 data, ref int cantidadDecimales, List<string> nombres)
        {
            BuildResponse response = new BuildResponse();

            BuildDocument21 buildDoc = null;

            switch (data.InvoiceTypeCode)
            {
                case Constantes.TipoDocumento.FacturaNacional:
                case Constantes.TipoDocumento.FacturaExportacion:
                case Constantes.TipoDocumento.FacturaContingenciaEmisor:
                case Constantes.TipoDocumento.FacturaContingenciaDian:
                case Constantes.TipoDocumento.FacturaDocumentoSoporte:
                    buildDoc = new Builder.UBL2._1.BuildDocument21();
                    break;

                case Constantes.TipoDocumento.NotaCredito:
                    buildDoc = new Builder.UBL2._1.CreditNote();
                    break;

                case Constantes.TipoDocumento.NotaDebito:
                    buildDoc = new Builder.UBL2._1.DebitNote();
                    break;

                case Constantes.TipoDocumento.NotaAjusteDocumentoSoporte:
                    // se reutiliza la de nota crédito pero espera cambiarlo
                    buildDoc = new Builder.UBL2._1.CreditNote();
                    break;

                default:
                    buildDoc = new Builder.UBL2._1.BuildDocument21();
                    break;
            }

            data = ObjectConversion<DocumentClass.UBL2._1.BaseDocument21>.FromJson(ObjectConversion<DocumentClass.UBL2._1.BaseDocument21>.ToJson(data));

            response.xml = buildDoc.BuildXML(data, ref cantidadDecimales, nombres);

            return response;
        }
    }
}
