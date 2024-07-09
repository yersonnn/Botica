using Capa_Entidad;
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
    public partial class CRUD_CategoriaProducto : Form
    {
        public CRUD_CategoriaProducto()
        {
            InitializeComponent();
            OcultarBarra();
            listarCAT();
            groupBox1.Enabled = false;
            txt_CodCat.Enabled = false;
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

        private void LimpiarVariables()
        {
            txt_CodCat.Text = "";
            txt_NombCat.Text = "";
            checkBox_CAT.Checked = false;

        }
        public void listarCAT()
        {
            dgv_CAT.DataSource = logCategoria.Instancia.ListarCategoria();
        }
        private void btn_Nuev_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

            btn_AgCat.Visible = true;
            LimpiarVariables();
            btn_ModCAT.Visible = false;
        }

        private void btn_AgCat_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCategoria cat = new entCategoria();
                cat.NomCategoria = txt_NombCat.Text.Trim();

                cat.estCategoria = checkBox_CAT.Checked;
                logCategoria.Instancia.InsertaCategoria(cat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarCAT();
        }

        private void btn_ModCAT_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria cat = new entCategoria();
                cat.NomCategoria = txt_NombCat.Text.Trim();
                cat.estCategoria = checkBox_CAT.Checked;

                logCategoria.Instancia.EditarCat(cat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarCAT();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btn_ModCAT.Visible = true;
            btn_AgCat.Visible = false;
        }

        private void btn_Inhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria cat = new entCategoria();

                cat.CategoriaID = int.Parse(txt_CodCat.Text.Trim());
                //cbkEstadoCliente.Checked = false;
                //c.estCliente = cbkEstadoCliente.Checked;
                cat.estCategoria = checkBox_CAT.Checked;
                logCategoria.Instancia.DeshabilitarCategoria(cat);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarCAT();
        }

        private void dgv_CAT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgv_CAT.Rows[e.RowIndex]; //
            txt_CodCat.Text = filaActual.Cells[0].Value.ToString();
            txt_NombCat.Text = filaActual.Cells[1].Value.ToString();
            checkBox_CAT.Checked = Convert.ToBoolean(filaActual.Cells[2].Value);
        }
    }
}
