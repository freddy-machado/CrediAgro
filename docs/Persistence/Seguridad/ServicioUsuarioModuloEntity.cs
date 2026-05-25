RUTA: Persistence/Seguridad/ServicioUsuarioModuloEntity.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class ServicioUsuarioModuloEntity
    {
        public int servicioUsuarioId_ { get; set; }
        public int moduloId_ { get; set; }
        public string servicioUsuario_ { get; set; }
        public string modulo_ { get; set; }
    }
}
