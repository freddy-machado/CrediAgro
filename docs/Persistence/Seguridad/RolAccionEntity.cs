RUTA: Persistence/Seguridad/RolAccionEntity.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class RolAccionEntity
    {
        public int rolAccionId_ { get; set; }
        public int rolId_ { get; set; }
        public int accionId_ { get; set; }
        public string rol_ { get; set; }
        public string accion_ { get; set; }
    }
}
