RUTA: Persistence/CustomEntities/FiadorList.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class FiadorList
    {
        public int fiadorID { get; set; }
        public int personaID { get; set; }
        public string fiadorName { get; set; }
        public string municipio { get; set; }
        public string lugarTrabajo { get; set; }
        public string puesto { get; set; }
        public string observacion { get; set; }
        public string parentesco { get; set; }
        public string estado { get; set; }
    }
}
