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
    public partial class CRUD_Producto : Form
    {
        public CRUD_Producto()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
