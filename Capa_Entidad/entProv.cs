using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class entProv
    {
        public int idProv { get; set; }
        public string NombProv { get; set; }
        public int CiudadProv { get; set; }

        public int TelfProv { get; set; }
        //public DateTime fecRegCliente { get; set; }
        //public int idCiudad { get; set; }      /// public entCiudad Ciudad{ get; set; }

        public Boolean estProv { get; set; }

    }
}
