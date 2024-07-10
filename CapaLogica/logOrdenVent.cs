using Capa_Entidad;
using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaLogica
{
    public class logOrdenVent
    {

        #region singleton
        private static readonly logOrdenVent _instancia = new logOrdenVent();
        public static logOrdenVent Instancia
        {
            get { return logOrdenVent._instancia; }
        }
        #endregion singleton

        #region metodos
        /*public List<entVentaProd> ListarVentaProd()
        {
            try
            {
                return datVentaProd.Instancia.ListarVentaProd();
            }
            catch (Exception e)
            {
                throw e;
            }
        }*/
        public int InsertarVentaOD(entOrdenVenta ordvent)
        {
            int a;
            try
            {
                a = datVentas.Instancia.InsertarVentaOD(ordvent);
            }
            catch (Exception e)
            { throw e; }

            return a;
        }
        public void InsertarDetVenta(entDetalleVenta detVen)
        {
            try
            {
                datVentas.Instancia.InsertarDetVenta(detVen);
            }
            catch (Exception e)
            { throw e; }
        }

        public DataTable CargarMetPag()
        {
            return datVentas.Instancia.CargarMetPag();
        }

        public DataTable CargarNombreMetPag(int idMetodo)
        {
            return datVentas.Instancia.CargarNombreMetodoPago(idMetodo);
        }

        #endregion metodos
    }
}
