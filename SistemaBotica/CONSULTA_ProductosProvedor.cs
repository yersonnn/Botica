using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class CONSULTA_ProductosProvedor : Form
    {
        public CONSULTA_ProductosProvedor()
        {
            InitializeComponent();
            OcultarBarra();
        }
        void OcultarBarra()
        {
            // Eliminar los botones de minimizar, maximizar y cerrar
            this.ControlBox = false;

            // Quitar la barra de título y los bordes del formulario
            this.FormBorderStyle = FormBorderStyle.None;

            // Opcional: Si deseas que el formulario no tenga un título
            this.Text = "";
        }
        private void comboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ActualizarCombos()
        {
            comboEmpresa.DataSource = logInvent.Instancia.CargarProveedor();
            comboEmpresa.DisplayMember = "Nombempresa";
            comboEmpresa.ValueMember = "ProveedorID";

        }
        private void CONSULTA_ProductosProvedor_Load(object sender, EventArgs e)
        {
            ActualizarCombos();
        }
    }
}
