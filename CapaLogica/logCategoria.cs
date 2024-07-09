using Capa_Entidad;
using CapaAccesoDatos;
using System;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logCategoria
    {
        #region singleton
        private static readonly logCategoria _instancia = new logCategoria();
        //privado para evitar la instanciación directa
        public static logCategoria Instancia
        {
            get
            {
                return logCategoria._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        public List<entCategoria> ListarCategoria()
        {
            return datCategoria.Instancia.ListarCategorias();
        }

        ///inserta
        public void InsertaCategoria(entCategoria Cat)
        {
            datCategoria.Instancia.InsertarCategoria(Cat);
        }

        public void EditarCat(entCategoria Cat)
        {
            datCategoria.Instancia.EditarCat(Cat);
        }

        ///deshabilitar
        public void DeshabilitarCategoria(entCategoria Cat)
        {
            datCategoria.Instancia.DeshabilitarCategoria(Cat);
        }

        #endregion metodos
    }
}
