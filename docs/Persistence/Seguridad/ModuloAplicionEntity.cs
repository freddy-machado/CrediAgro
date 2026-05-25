RUTA: Persistence/Seguridad/ModuloAplicionEntity.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class ModuloAplicionEntity
    {
        public int aplicacionId_ { get; set; }
        public int moduloId_ { get; set; }
        public string aplicacion_ { get; set; }
        public string modulo_ { get; set; }
    }
}
