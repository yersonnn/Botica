using Capa_Entidad;
using CapaAccesoDatos;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logEmpl
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEmpl _instancia = new logEmpl();
        //privado para evitar la instanciación directa
        public static logEmpl Instancia
        {
            get
            {
                return logEmpl._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entEmpl> ListarEmpl()
        {
            return datEmpl.Instancia.ListarEmpl();
        }
        ///inserta
        public void InsertaEmpl(entEmpl Empl)
        {
            datEmpl.Instancia.InsertaEmpl(Empl);
        }

        //edita
        public void EditaEmpl(entEmpl Empl)
        {
            datEmpl.Instancia.EditarEmpl(Empl);
        }
        public void DeshabilitarEmpl(entEmpl Empl)
        {
            datEmpl.Instancia.DeshabilitarEmpl(Empl);
        }
        #endregion metodos

    }
}
