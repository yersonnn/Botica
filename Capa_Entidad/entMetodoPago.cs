using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class entMetodoPago
    {
        public int MetodoDePagoID { get; set; }
        public string MetodoPago { get; set; }
        public string Tipo { get; set; }
       

        //public DateTime fecRegCliente { get; set; }
        //public int idCiudad { get; set; }      /// public entCiudad Ciudad{ get; set; }

        public Boolean estMetPag { get; set; }

    }
}
