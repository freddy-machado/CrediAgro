RUTA: Persistence/CustomEntities/DatosPrestamoEntity.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class DatosPrestamoEntity
    {
        public int? solicitudID_ { get; set; }
        public Decimal? nMonto_ { get; set; }
        public Decimal? deslizamiento_ { get; set; }
        public DateTime fechaInicio_ { get; set; }
        public int? plazo_ { get; set; }
        public Decimal? interes_ { get; set; }
        public DateTime fechaVence_ { get; set; }
        public int? frecuencia_ { get; set; }
        public int? numeroPagos_ { get; set; }
        public Decimal? tipoCambio_ { get; set; }
        public string rubro_ { get; set; }
        public DateTime? fechaUltimoPago { get; set; }
    }
}
