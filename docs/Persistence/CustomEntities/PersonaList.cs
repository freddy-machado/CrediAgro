RUTA: Persistence/CustomEntities/PersonaList.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class PersonaList
    {
        #region campos

        public int PersonaID { get; set; }
        public String Nombre1 { get; set; }
        public String Nombre2 { get; set; }
        public String Apellido1 { get; set; }
        public String Apellido2 { get; set; }
        public String Direccion { get; set; }
        public bool Activo { get; set; }
        public string Sexo { get; set; }
        public String Municipio { get; set; }
        public String Cedula { get; set; }
        public String fechaNacimiento { get; set; }
        public String EstadoCivil { get; set; }
        public String Profesion { get; set; }

        #endregion

        #region constructor

        public PersonaList() { }

        #endregion
    }
}
