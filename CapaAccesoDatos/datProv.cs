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
    public class datProv
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProv _instancia = new datProv();
        //privado para evitar la instanciación directa
        public static datProv Instancia
        {
            get
            {
                return datProv._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Clientes
        public List<entProv> ListarProv()
        {
            SqlCommand cmd = null;
            List<entProv> lista = new List<entProv>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProv", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProv Prov = new entProv();
                    Prov.ProvID = Convert.ToInt32(dr["ProveedorID"]);
                    Prov.Proveedor = dr["Nombempresa"].ToString();
                    Prov.Ciudad = dr["Nombciudad"].ToString();
                    Prov.Telefono = Convert.ToInt32(dr["Telfempresa"]);
                    //Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);
                    //Cli.idCiudad = Convert.ToInt32(dr["idCiudad"]);
                    Prov.estProv = Convert.ToBoolean(dr["Estproveed"]);
                    lista.Add(Prov);
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
        public Boolean InsertaProv(entProv Prov)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProv", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", Prov.ProvID);
                cmd.Parameters.AddWithValue("@Nombempresa", Prov.Proveedor);
                cmd.Parameters.AddWithValue("@CiudadID", Prov.CiudadID);
                cmd.Parameters.AddWithValue("@Telfempresa", Prov.Telefono);
                //cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                //cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@Estproveed", Prov.estProv);
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
        public Boolean EditarProv(entProv Prov)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProv", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", Prov.ProvID);
                cmd.Parameters.AddWithValue("@Nombempresa", Prov.Proveedor);
                cmd.Parameters.AddWithValue("@CiudadID", Prov.CiudadID);
                cmd.Parameters.AddWithValue("@Telfempresa", Prov.Telefono);
                //cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                //cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@Estproveed", Prov.estProv);
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

        public Boolean DeshabilitarProv(entProv Prov)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesabilitarProv", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", Prov.ProvID);
                cmd.Parameters.AddWithValue("@Estproveed", Prov.estProv);
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

        public DataTable CargarCiudad()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("spCargarCiudad", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargarNombreCiudad(int idCiudad)
        {
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("spCargarNombreCiudad", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CiudadID", idCiudad);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        #endregion metodos

    }
}
