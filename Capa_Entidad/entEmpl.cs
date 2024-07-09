using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class entEmpl
    {


        public int idEmpl { get; set; }
        public string NombreEmpleado { get; set; }
        

        public int CelularEmpleado { get; set; }

        public string Cargo { get; set; }
        //public DateTime fecRegCliente { get; set; }
        //public int idCiudad { get; set; }      /// public entCiudad Ciudad{ get; set; }

        public Boolean estEmpl { get; set; }
    }
}
