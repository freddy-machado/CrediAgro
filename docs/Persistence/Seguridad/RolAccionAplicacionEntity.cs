RUTA: Persistence/Seguridad/RolAccionAplicacionEntity.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class RolAccionAplicacionEntity
    {
        public string servicio_ { get; set; }
        public string modulo_ { get; set; }
        public string accion_ { get; set; }
        public int accionId_ { get; set; }
        public bool activa_ { get; set; }
    }
}
