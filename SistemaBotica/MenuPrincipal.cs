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
    public partial class MenuPrincipal : Form
    {
        private int borderSize = 2;
        private Size formSize;
        private Button boton;
        private Panel leftboton;

        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void Cambiar(Form f)
        {
            PanelCont.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.TopMost = true;

            PanelCont.Controls.Add(f);
            f.Show();
        }


        private void btn_Venta_Click(object sender, EventArgs e)
        {
            Cambiar(new CORE_VentaDirecta());

        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            Cambiar(new CORE_Inventario());
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            Cambiar(new CRUD_Cliente());
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            Cambiar(new CRUD_Empleado());
        }

        private void btn_Producto_Click(object sender, EventArgs e)
        {
            Cambiar(new CRUD_Producto());
        }

        private void btn_Proveedor_Click(object sender, EventArgs e)
        {
            Cambiar(new CRUD_Proveedor());
        }

        private void PanelCont_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_MetPago_Click(object sender, EventArgs e)
        {
            Cambiar(new CRUD_MetodoPago());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
