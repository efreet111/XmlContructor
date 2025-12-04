using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
   public class InteroperabilidadPT
    {
        
        /// ext:UBLExtension/ext:ExtensionContent/ipt:InteroperabilidadPT/ipt:URLDescargaAdjuntos
        
        public String URLDescargaAdjuntos { get; set; }

        
        /// ext:UBLExtension/ext:ExtensionContent/ipt:InteroperabilidadPT/ipt:ServicioAcuseAceptacionRechazo
        
        public String ServicioAcuseAceptacionRechazo { get; set; }
    }
}
