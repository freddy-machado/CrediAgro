RUTA: Persistence/Seguridad/RolCuentaRolEntity.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class RolCuentaRolEntity
    {
        public int cuentaId_ { get; set; }
        public string cuenta { get; set; }
        public int cuentaRolId { get; set; }
    }
}
