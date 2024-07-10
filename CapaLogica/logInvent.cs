using Capa_Entidad;
using CapaAccesoDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaLogica
{
    public class logInvent
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logInvent _instancia = new logInvent();
        //privado para evitar la instanciación directa
        public static logInvent Instancia
        {
            get
            {
                return logInvent._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entInventario> ListarInv()
        {
            return datInventario.Instancia.ListarInv();
        }
        ///inserta
        public void InsertaInv(entInventario inv)
        {
            datInventario.Instancia.InsertaInv(inv);
        }

        //edita
        public void EditarInv(entInventario inv)
        {
            datInventario.Instancia.EditarInv(inv);
        }
        public void DeshabilitarInv(entInventario inv)
        {
            datInventario.Instancia.DeshabilitarInv(inv);
        }
        public DataTable CargarProducto()
        {
            return datInventario.Instancia.CargarProducto();
        }

        public DataTable CargarNombreProducto(int idProd)
        {
            return datInventario.Instancia.CargarNombreProducto(idProd);
        }

        public DataTable CargarProveedor()
        {
            return datInventario.Instancia.CargarProveedor();
        }

        public DataTable CargarNombreProveedor(int idProveer)
        {
            return datInventario.Instancia.CargarNombreProveedor(idProveer);
        }

        #endregion metodos
    }
}
