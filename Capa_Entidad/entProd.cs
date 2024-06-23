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
        public string NombProd { get; set; }
        public int CatProd { get; set; }

        public double PrecProd { get; set; }
        //public DateTime fecRegCliente { get; set; }
        //public int idCiudad { get; set; }      /// public entCiudad Ciudad{ get; set; }
        public int StockProd { get; set; }
        public Boolean estProd { get; set; }

        


    }
}
