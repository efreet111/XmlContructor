using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.Transversal
{
    public  class HelpersConstantes
    {
        public static class TipoCufe
        {
            public const string CufeSha384 = "CUFE-SHA384";
            public const string CudeSha384 = "CUDE-SHA384";
            public const string CudsSha384 = "CUDS-SHA384";
        }
        public static class Entorno
        {
            public const int Pruebas = 0;
            public const int Habilitacion = 2;
            public const int Produccion = 1;
        }
        public static class TipoDocumento
        {
            public const string Fact = "01";
            public const string FactExportacion = "02";
            public const string FactContingenciaEmisor = "03";
            public const string FactContingenciaDian = "04";
            public const string FactAppMovil = "05";
            public const string NC = "91";
            public const string ND = "92";
            public const string FactDocumentoSoporte = "05";
            public const string NotaAjusteDocumentoSoporte = "95";
        }
        public static class TipoOperacion
        {
            public const string Mandato = "11";
            public const string Transporte = "12";
        }
    }
}
