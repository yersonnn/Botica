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
    public class datVentas
    {

        #region singleton
        private static readonly datVentas _instancia = new datVentas();
        public static datVentas Instancia
        {
            get { return datVentas._instancia; }
        }
        #endregion singleton

        #region metodos
        /*public List<entVentaProd> ListarVentaProd()
        {
            /*SqlCommand cmd = null;
            List<entVentaProd> lista = new List<entVentaProd>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarVentaProd", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    entVentaProd Ped = new entVentaProd();
                    //----Ped.idCliente = new entCliente();
                    entCliente Cli = new entCliente();

                    Ped.idPedido = Convert.ToInt32(dr["idPedido"]);
                    Ped.estPedido = Convert.ToBoolean(dr["estPedido"]);
                    Ped.fechPedido = Convert.ToDateTime(dr["fechPedido"]);

                    //----Ped.idCliente.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.idCliente = Convert.ToInt32(dr["idCliente"]);
                    Cli.RazonSocial = dr["RazonSocial"].ToString();


                    Ped.idCliente = Cli;
                    //Ped.idCliente.idCliente =Cli.idCliente;
                    //Ped.idCliente = (entCliente) Cli.idCliente;
                    //Ped.idCliente.idCliente = (int) Cli.idCliente;
                    //Console.WriteLine("idCliente "+Ped.idCliente.idCliente);



                    //////////pd.idDetPedido= Convert.ToInt16(dr["idDetPedido"]);
                    //////////Ped.idPedido= pd.idPedido;
                    //////////pd.cantProducto = Convert.ToInt16(dr["canProducto"]);
                    //////////pd.precProducto = Convert.ToDecimal(dr["precProducto"]);
                    //pd.Importe = Convert.ToDecimal(dr["Importe"]);
                    //pd.Importe = (Decimal)(dr["Importe"]);
                    Ped.TotPedido = Convert.ToDouble(dr["TotPedido"]);
                    lista.Add(Ped);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }*/
        public int InsertarVentaOD(entOrdenVenta ordVent)
        {

            SqlCommand cmd = null;
            int idOrdV = 0;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarOD", cn);
                cmd.CommandType = CommandType.StoredProcedure;

            
                cmd.Parameters.AddWithValue("@ClienteID", ordVent.ClienteID);
                cmd.Parameters.AddWithValue("@EmpleadoID", ordVent.EmpleadoID);
                cmd.Parameters.AddWithValue("@FechaVent", ordVent.FechaVent);
                cmd.Parameters.AddWithValue("@MetodoDePagoID", ordVent.MetodoDePagoID);
                cmd.Parameters.AddWithValue("@Monto", ordVent.Monto);

                SqlParameter m = new SqlParameter("@retorno", DbType.Int32);
                m.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(m);
                cn.Open();
                cmd.ExecuteNonQuery();
                idOrdV = Convert.ToInt16(cmd.Parameters["@retorno"].Value);
                return idOrdV;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

        }
        public Boolean InsertarDetVenta(entDetalleVenta detVent)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarDetVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@OrdenventaID", detVent.OrdenventaID);
                cmd.Parameters.AddWithValue("@ProductoID", detVent.ProductoID);
                cmd.Parameters.AddWithValue("@Cantidad", detVent.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioUnit", detVent.PrecioUnit);
                cmd.Parameters.AddWithValue("@PrecioTotal", detVent.PrecioTotal);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                { inserta = true; }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }
        public DataTable CargarMetPag()
        {
            SqlConnection cn = Conexion.Instancia.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("spCargarMetPag", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable CargarNombreMetodoPago(int idMP)
        {
            SqlCommand cmd = null;
            SqlConnection cn = Conexion.Instancia.Conectar();
            cmd = new SqlCommand("spCargarNombreMetPag", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MetodoDePagoID", idMP);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        #endregion metodos

    }
}
