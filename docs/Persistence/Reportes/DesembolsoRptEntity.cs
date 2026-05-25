RUTA: Persistence/Reportes/DesembolsoRptEntity.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class DesembolsoRptEntity
    {
        public int SOLICITUDID { get; set; }
        public int CLIENTEID { get; set; }
        public int DESEMBOLSOID { get; set; }
        public string CLIENTE { get; set; }
        public Decimal MONTOCOR { get; set; }
        public Decimal MONTOUSD { get; set; }
        public string RUBRO { get; set; }
        public Decimal TIPOCAMBIO { get; set; }
    }
}
