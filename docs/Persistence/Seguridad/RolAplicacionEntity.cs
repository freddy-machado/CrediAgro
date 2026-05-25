RUTA: Persistence/Seguridad/RolAplicacionEntity.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class RolAplicacionEntity
    {
        public int aplicacionId { get; set; }
        public int rolId { get; set; }
        public string aplicacion { get; set; }
        public string rol { get; set; }
    }
}
