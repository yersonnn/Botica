using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class datEmpl
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datEmpl _instancia = new datEmpl();
        //privado para evitar la instanciación directa
        public static datEmpl Instancia
        {
            get
            {
                return datEmpl._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Clientes
        public List<entEmpl> ListarEmpl()
        {
            SqlCommand cmd = null;
            List<entEmpl> lista = new List<entEmpl>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarEmpl", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpl Empl = new entEmpl();
                   Empl.idEmpl = Convert.ToInt32(dr["EmpleadoID"]);
                    Empl.NombEmpl = dr["Nombempleado"].ToString();                   
                    Empl.CeluEmpl = Convert.ToInt32(dr["Celemplead"]);
                    Empl.CargoEmpl = dr["Cargo"].ToString();
                    //Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);
                    //Cli.idCiudad = Convert.ToInt32(dr["idCiudad"]);
                    Empl.estEmpl = Convert.ToBoolean(dr["Estemplead"]);
                    lista.Add(Empl);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        /////////////////////////InsertaCliente
        public Boolean InsertaEmpl(entEmpl Empl)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarEmpl", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID", Empl.idEmpl);
                cmd.Parameters.AddWithValue("@Nombempleado", Empl.NombEmpl);
                cmd.Parameters.AddWithValue("@Celemplead", Empl.CeluEmpl);
                cmd.Parameters.AddWithValue("@Cargo", Empl.CargoEmpl);
                //cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                //cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@Estemplead", Empl.estEmpl);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }


        //////////////////////////////////EditaCliente
        public Boolean EditarEmpl(entEmpl Empl)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarEmpl", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID", Empl.idEmpl);
                cmd.Parameters.AddWithValue("@Nombempleado", Empl.NombEmpl);
                cmd.Parameters.AddWithValue("@Celemplead", Empl.CeluEmpl);
                cmd.Parameters.AddWithValue("@Cargo", Empl.CargoEmpl);
                //cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                //cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@Estemplead", Empl.estEmpl);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //deshabilitaCliente

        public Boolean DeshabilitarEmpl(entEmpl Empl)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesabilitarEmpl", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID", Empl.idEmpl);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        #endregion metodos


    }
}
