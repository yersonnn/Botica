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
    public class datProd
    { 
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProd _instancia = new datProd();
        //privado para evitar la instanciación directa
        public static datProd Instancia
        {
            get
            {
                return datProd._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Clientes
        public List<entProd> ListarProd()
        {
            SqlCommand cmd = null;
            List<entProd> lista = new List<entProd>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarProd", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProd Prod = new entProd();
                    Prod.idProd = Convert.ToInt32(dr["idProd"]);
                    Prod.NombProd = dr["NombProd"].ToString();
                    Prod.CatProd = Convert.ToInt32(dr["CatProd"]);
                    Prod.PrecProd = Convert.ToDouble(dr["PrecProd"]);
                    //Cli.fecRegCliente = Convert.ToDateTime(dr["fecRegCliente"]);
                    //Cli.idCiudad = Convert.ToInt32(dr["idCiudad"]);
                    Prod.StockProd = Convert.ToInt32(dr["StockProd"]);
                    Prod.estProd = Convert.ToBoolean(dr["estProd"]);
                    lista.Add(Prod);
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
        public Boolean InsertaProd(entProd Prod)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarProd", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombproducto", Prod.NombProd);
                cmd.Parameters.AddWithValue("@CategoriaID", Prod.CatProd);
                cmd.Parameters.AddWithValue("@Precioprod", Prod.PrecProd);
                cmd.Parameters.AddWithValue("@Stock", Prod.StockProd);
                //cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                //cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@Estprod", Prod.estProd);
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
        public Boolean EditarProd(entProd Prod)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarProd", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombproducto", Prod.NombProd);
                cmd.Parameters.AddWithValue("@CategoriaID", Prod.CatProd);
                cmd.Parameters.AddWithValue("@Precioprod", Prod.PrecProd);
                cmd.Parameters.AddWithValue("@Stock", Prod.StockProd);
                //cmd.Parameters.AddWithValue("@fecRegCliente", Cli.fecRegCliente);
                //cmd.Parameters.AddWithValue("@idCiudad", Cli.idCiudad);
                cmd.Parameters.AddWithValue("@Estprod", Prod.estProd);
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

        public Boolean DeshabilitarProd(entProd Prod)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDesabilitarProd", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", Prod.idProd);
                cmd.Parameters.AddWithValue("@Estprod", Prod.estProd);
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
