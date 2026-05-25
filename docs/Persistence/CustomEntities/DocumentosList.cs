RUTA: Persistence/CustomEntities/DocumentosList.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class DocumentosList
    {
        public int documentoID { get; set; }
        public string tipoDocumento { get; set; }
        public string nombreDocumento { get; set; }
        public byte[] foto { get; set; }
    }
}
