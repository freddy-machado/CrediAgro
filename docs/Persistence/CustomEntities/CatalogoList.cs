RUTA: Persistence/CustomEntities/CatalogoList.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class CatalogoList
    {
        public int catalogoId { get; set; }
        public string catalogoName { get; set; }
        public string catalogoDesc { get; set; }
        public bool estado { get; set; }
    }
}
