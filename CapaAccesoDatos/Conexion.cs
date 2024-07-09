using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace CapaAccesoDatos
{
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        public SqlConnection Conectar()
        {
            /////CAMBIAR NOMBRE DEL HOST////////

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-CODMBQV\\SQLEXPRESS; Initial Catalog =ANGEL_GUARDIAN;" +
                                "Integrated Security=true";

            return cn;
        }



    }
}
