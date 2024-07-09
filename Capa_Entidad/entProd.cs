using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class entProd
    {

        public int idProd { get; set; }
        public string Producto { get; set; }
        public int IDCatProd { get; set; }

        public string NombCategoria { get; set; }

        public double PrecioUnitario { get; set; }
        //public DateTime fecRegCliente { get; set; }
        //public int idCiudad { get; set; }      /// public entCiudad Ciudad{ get; set; }
        public int Stock { get; set; }
        public Boolean estProd { get; set; }

        


    }
}
