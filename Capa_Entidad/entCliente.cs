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
        public string NombCli { get; set; }
        public string CorreoCli { get; set; }

        public int CeluCli { get; set; }
        //public DateTime fecRegCliente { get; set; }
        //public int idCiudad { get; set; }      /// public entCiudad Ciudad{ get; set; }

        public Boolean estCli { get; set; }

    }
}
