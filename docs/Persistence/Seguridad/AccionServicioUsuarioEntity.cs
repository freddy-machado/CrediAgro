RUTA: Persistence/Seguridad/AccionServicioUsuarioEntity.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class AccionServicioUsuarioEntity
    {
        public int accionId { get; set; }
        public int servicioUsuarioId { get; set; }
        public string accion { get; set; }
        public string servicioUsuario { get; set; }
        public bool activo { get; set; }
    }
}
