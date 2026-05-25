RUTA: Persistence/CustomEntities/ValorCatalogoList.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class ValorCatalogoList
    {
        public int valorCatalogoId { get; set; }
        public int catalogoId { get; set; }
        public string codigoInterno { get; set; }
        public string valorCatalogoDescripcion { get; set; }
        public bool estado { get; set; }
    }
}
