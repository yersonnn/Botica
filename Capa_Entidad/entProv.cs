using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class entProv
    {
        public int ProvID { get; set; }
        public string Proveedor { get; set; }
        public int CiudadID { get; set; }
        public string Ciudad { get; set; }
        public int Telefono { get; set; }
        //public DateTime fecRegCliente { get; set; }
        //public int idCiudad { get; set; }      /// public entCiudad Ciudad{ get; set; }

        public Boolean estProv { get; set; }

    }
}
