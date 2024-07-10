using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class entDetalleVenta
    {
        public int DetVentaID { get; set; }
        public int OrdenventaID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public double PrecioTotal { get; set; }
        public double PrecioUnit { get; set; }

    }
}
