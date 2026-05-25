RUTA: Persistence/Seguridad/CuentaRolAplicacionEntity.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class CuentaRolAplicacionEntity
    {
        public int cuentaId_ { get; set; }
        public int rolId_ { get; set; }
        public string rol_ { get; set; }
        public string cuenta_ { get; set; }
        public string aplicacion_ { get; set; }
        public bool activa { get; set; }
    }
}
