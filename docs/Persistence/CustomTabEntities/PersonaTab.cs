RUTA: Persistence/CustomTabEntities/PersonaTab.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class PersonaTab
    {
        public string fechaNacimiento { get; set; }
        public string cedula { get; set; }
        public string sexo { get; set; }
        public string municipio { get; set; }
        public string direccion { get; set; }
        public string estadoCivil { get; set; }
        public string profesion { get; set; }
        public byte[] foto { get; set; }
    }
}
