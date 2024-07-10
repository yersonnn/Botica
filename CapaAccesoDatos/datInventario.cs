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
    public class datInventario
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datInventario _instancia = new datInventario();
        //privado para evitar la instanciación directa
        public static datInventario Instancia
        {
            get
            {
                return datInventario._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Clientes
        public List<entInventario> ListarInv()
        {
            SqlCommand cmd = null;
            List<entInventario> lista = new List<entInventario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarInv", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entInventario inv = new entInventario();
                    inv.idInvent = Convert.ToInt32(dr["InventarioID"]);
                    inv.NombProd = dr["Nombproducto"].ToString();
                    inv.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                    inv.NombProveer = dr["Nombempresa"].ToString();               
                    inv.Fecha = Convert.ToDateTime(dr["Fecha"]);
                    inv.estInventario = Convert.ToBoolean(dr["Estinventario"]);
                    lista.Add(inv);
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
        public Boolean InsertaInv(entInventario inv)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarInv", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", inv.ProdID);
                cmd.Parameters.AddWithValue("@Cantidad", inv.Cantidad);
                cmd.Parameters.AddWithValue("@ProveedorID", inv.ProveerID);
                cmd.Parameters.AddWithValue("@FechaIngreso", inv.Fecha);
                cmd.Parameters.AddWithValue("@Estinv", inv.estInventario);
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
        public Boolean EditarInv(entInventario inv)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarInv", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", inv.ProdID);
                cmd.Parameters.AddWithValue("@Cantidad", inv.Cantidad);
                cmd.Parameters.AddWithValue("@ProveedorID", inv.ProveerID);
                cmd.Parameters.AddWithValue("@FechaIngreso", inv.Fecha);
                cmd.Parameters.AddWithValue("@Estinv", inv.estInventario);
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

        public Boolean DeshabilitarInv(entInventario inv)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesabilitarInv", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@InventarioID", inv.idInvent);
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

        public DataTable CargarProducto()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("spCargarProducto", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargarNombreProducto(int idProd)
        {
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("spCargarNombreProducto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductoID", idProd);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable CargarProveedor()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("spCargarProveedor", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargarNombreProveedor(int idProvee)
        {
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("spCargarNombreProveedor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProveedorID", idProvee);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion metodos


    }
}
