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
    }
}
