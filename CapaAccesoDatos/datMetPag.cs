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
    public class datMetPag
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datMetPag _instancia = new datMetPag();
        //privado para evitar la instanciación directa
        public static datMetPag Instancia
        {
            get
            {
                return datMetPag._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Clientes
        public List<entMetodoPago> ListarMetPag()
        {
            SqlCommand cmd = null;
            List<entMetodoPago> lista = new List<entMetodoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMetodoPago Met = new entMetodoPago();
                    Met.MetodoDePagoID = Convert.ToInt32(dr["MetodoDePagoID"]);
                    Met.MetodoPago = dr["Nombmetpago"].ToString();
                    Met.Tipo = dr["Tipometpag"].ToString();
                    //Cli.idTipoCliente = Convert.ToInt32(dr["idTipoCliente"]);
                    //Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);
                    //Cli.idCiudad = Convert.ToInt32(dr["idCiudad"]);
                    Met.estMetPag = Convert.ToBoolean(dr["Estmetpag"]);
                    lista.Add(Met);
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
        public Boolean InsertaMetPago(entMetodoPago Met)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarMetPag", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombmetpago", Met.MetodoPago);
                cmd.Parameters.AddWithValue("@Tipometpag", Met.Tipo);
                //cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                //cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@Estmetpag", Met.estMetPag);
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
        public Boolean EditarMetPag(entMetodoPago Met)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarMetPag", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MetodoDePagoID", Met.MetodoDePagoID);     
                cmd.Parameters.AddWithValue("@Nombmetpago", Met.MetodoPago);
                cmd.Parameters.AddWithValue("@Tipometpag", Met.Tipo);
                //cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                //cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@Estmetpag", Met.estMetPag);
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

        public Boolean DeshabilitarMetPag(entMetodoPago Met)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesabilitarMetPag", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MetodoDePagoID", Met.MetodoDePagoID);
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

        //public DataTable CargarTipoMetodo()
        //{
        //    SqlConnection cn = Conexion.Instancia.Conectar();
        //    SqlDataAdapter da = new SqlDataAdapter("spCargarTipoMetodo", cn);
        //    da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}

        //public DataTable CargarMetodoPago(int idTipo)
        //{
        //    SqlCommand cmd = null;
        //    SqlConnection cn = Conexion.Instancia.Conectar();
        //    cmd = new SqlCommand("spCargarMetodoPago", cn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@MetodoDePagoID", idTipo);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}


        #endregion metodos




    }
}

