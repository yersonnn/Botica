using Capa_Entidad;
using CapaAccesoDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaLogica
{
    public class logProv
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProv _instancia = new logProv();
        //privado para evitar la instanciación directa
        public static logProv Instancia
        {
            get
            {
                return logProv._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entProv> ListarProv()
        {
            return datProv.Instancia.ListarProv();
        }
        ///inserta
        public void InsertaProv(entProv Prov)
        {
            datProv.Instancia.InsertaProv(Prov);
        }

        //edita
        public void EditarProv(entProv Prov)
        {
            datProv.Instancia.EditarProv(Prov);
        }
        public void DeshabilitarProv(entProv Prov)
        {
            datProv.Instancia.DeshabilitarProv(Prov);
        }

        public DataTable CargarCiudad()
        {
            return datProv.Instancia.CargarCiudad();
        }

        public DataTable CargarNombreCiudad(int idCiudad)
        {
            return datProv.Instancia.CargarNombreCiudad(idCiudad);
        }

        #endregion metodos
    }
}
