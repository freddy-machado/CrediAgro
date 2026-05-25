RUTA: Persistence/Reportes/RptDatosPrestamoCliente.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class RptDatosPrestamoCliente
    {
        public int N_SOLICITUD_ID { get; set; }
        public string cliente { get; set; }
        public Decimal nMontoApruebaC { get; set; }
        public string deslizamiento { get; set; }
        public DateTime dFechaPagado { get; set; }
        public Byte nPlazoMeses { get; set; }
        public Decimal nTasaInteres { get; set; }
        public DateTime vence { get; set; }
        public Byte frecuencia { get; set; }
        public Byte NumPagos { get; set; }
        public Decimal nMontoTCambio { get; set; }
        public string rubro { get; set; }
    }
}
