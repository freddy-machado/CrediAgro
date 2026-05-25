RUTA: Persistence/CustomEntities/EmpresaDatosPlantilla.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CrediAgro.Infrastructure.Persistence.CustomEntities
{
    public static class EmpresaDatosPlantilla
    {
        public static int _nStbEmpresaID { get; set; }
        public static string _cNombreEmpresa { get; set; }
        public static string _cNombreCortoEmpresa { get; set; }
        public static string _cRazonSocialEmpresa { get; set; }
        public static string _cDireccionEmpresa { get; set; }
        public static string _cNumeroRUCEmpresa { get; set; }
        public static string _cNumeroPatronalEmpresa { get; set; }
        public static byte[] _bLogoEmpresa { get; set; }
    }
}
