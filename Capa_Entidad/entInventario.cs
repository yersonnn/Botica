using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class entInventario
    {
        public int idInvent { get; set; }
        public int ProdID { get; set; }
        public string NombProd { get; set; }
        public int Cantidad { get; set; }

        public int ProveerID { get; set; }
        public string NombProveer { get; set; }
        public DateTime Fecha { get; set; }

        public Boolean estInventario { get; set; }
    }
}
