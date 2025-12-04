using System.Collections.Generic;

namespace XmlBuildDLL.BaseClass.Modelresponse
{
  public class SectorSalud
  {
    public string TipoEscenario { get; set; }

    public string IdPersonalizacion { get; set; }

    public List<DatosPacienteSalud> Pacientes { get; set; }

    public string NombreResponsableCustomTagGeneral { get; set; }

    public string ValorResponsableCustomTagGeneral { get; set; }

    public string NombreTipoCustomTagGeneral { get; set; }

    public string ValorTipoCustomTagGeneral { get; set; }

    public bool ImprimirNodoUblExtension { get; set; }
  }
}
