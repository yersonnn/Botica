using Capa_Entidad;
using CapaAccesoDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaLogica
{
    public class logProd
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProd _instancia = new logProd();
        //privado para evitar la instanciación directa
        public static logProd Instancia
        {
            get
            {
                return logProd._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entProd> ListarProd()
        {
            return datProd.Instancia.ListarProd();
        }
        ///inserta
        public void InsertaProd(entProd Prod)
        {
            datProd.Instancia.InsertaProd(Prod);
        }

        //edita
        public void EditaProd(entProd Prod)
        {
            datProd.Instancia.EditarProd(Prod);
        }
        public void DeshabilitarProd(entProd Prod)
        {
            datProd.Instancia.DeshabilitarProd(Prod);
        }
        public DataTable CargarCategoria()
        {
            return datProd.Instancia.CargarCategoria();
        }

        public DataTable CargarNombre(int idCat)
        {
            return datProd.Instancia.CargarNombre(idCat);
        }

        #endregion metodos

    }
}
