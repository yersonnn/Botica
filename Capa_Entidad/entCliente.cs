using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class entCliente
    {

        public int idCli { get; set; }
        public string NombreCliente { get; set; }
        public string Correo { get; set; }

        public int CelularCliente { get; set; }
        //public DateTime fecRegCliente { get; set; }
        //public int idCiudad { get; set; }      /// public entCiudad Ciudad{ get; set; }

        public Boolean estCli { get; set; }

    }
}
