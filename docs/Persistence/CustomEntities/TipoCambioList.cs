RUTA: Persistence/CustomEntities/TipoCambioList.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class TipoCambioList
    {
        public int id { get; set; }
        public string anio { get; set; }
        public string mes { get; set; }
        public DateTime fecha { get; set; }
        public Decimal monto { get; set; }
    }
}
