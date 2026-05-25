RUTA: Persistence/Reportes/TablaPagoRptEntity.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public class TablaPagoRptEntity
    {
        public int SOLICITUDID { get; set; }
        public int CLIENTEID { get; set; }
        public string CLIENTE { get; set; }
        public decimal MONTOCOR { get; set; }
        public decimal MONTOUSD { get; set; }
        public decimal TASAINTERES { get; set; }
        public byte PLAZO { get; set; }
        public byte NUMPAGOS { get; set; }
        public string FRECUENCIA { get; set; }
        public DateTime FECHAENTREGA { get; set; }
        public DateTime FECHAVENCE { get; set; }
        public decimal TIPOCAMBIO { get; set; }
        public decimal PORDELIZAMIENTO { get; set; }
        public byte NOCUOTA { get; set; }
        public DateTime FECHAPAGO { get; set; }
        public decimal PRINCIPAL { get; set; }
        public decimal MMTO { get; set; }
        public decimal MONTOINTERES { get; set; }
        public decimal TOTAL { get; set; }
        public decimal SALDO { get; set; }
    }
}
