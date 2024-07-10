using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class entOrdenVenta
    {
        public int OrdenventaID { get; set; }
        public int ClienteID { get; set; }
        public int EmpleadoID { get; set; }
        public DateTime FechaVent { get; set; }
        public string MetodoDePagoID { get; set; }
        public double Monto { get; set; }
    }
}
