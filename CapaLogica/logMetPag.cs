using Capa_Entidad;
using CapaAccesoDatos;
using System.Collections.Generic;
namespace CapaLogica
{
    public class logMetPag
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMetPag _instancia = new logMetPag();
        //privado para evitar la instanciación directa
        public static logMetPag Instancia
        {
            get
            {
                return logMetPag._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entMetodoPago> ListarMetPag()
        {
            return datMetPag.Instancia.ListarMetPag();
        }
        ///inserta
        public void InsertaMetPag(entMetodoPago Met)
        {
            datMetPag.Instancia.InsertaMetPago(Met);
        }

        //edita
        public void EditaMetPag(entMetodoPago Met)
        {
            datMetPag.Instancia.EditarMetPag(Met);
        }
        public void DeshabilitarCliente(entMetodoPago Met)
        {
            datMetPag.Instancia.DeshabilitarMetPag(Met);
        }
        #endregion metodos
    }
}

