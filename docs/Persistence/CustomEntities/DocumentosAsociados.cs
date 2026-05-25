RUTA: Persistence/CustomEntities/DocumentosAsociados.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class DocumentosAsociados
    {
        public int creditoSolicitudID { get; set; }
        public int creditoID { get; set; }
        public int documentoID { get; set; }
        public string noSolicitud { get; set; }
        public string cliente { get; set; }
        public string documento { get; set; }
        public byte[] documentoFoto { get; set; }
    }
}
