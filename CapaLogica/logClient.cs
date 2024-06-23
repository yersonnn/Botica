using Capa_Entidad;
using CapaAccesoDatos;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logClient
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logClient _instancia = new logClient();
        //privado para evitar la instanciación directa
        public static logClient Instancia
        {
            get
            {
                return logClient._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entCliente> ListarCli()
        {
            return datCliente.Instancia.ListarCli();
        }
        ///inserta
        public void InsertaCli(entCliente Cli)
        {
            datCliente.Instancia.InsertaCli(Cli);
        }

        //edita
        public void EditaCli(entCliente Cli)
        {
            datCliente.Instancia.EditarCli(Cli);
        }
        public void DeshabilitarCli(entCliente Cli)
        {
            datCliente.Instancia.DeshabilitarCli(Cli);
        }
        #endregion metodos



    }
}
