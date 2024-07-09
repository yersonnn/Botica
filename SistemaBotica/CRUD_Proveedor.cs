using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using CapaAccesoDatos;
using CapaLogica;


namespace CapaPresentacion
{
    public partial class CRUD_Proveedor : Form
    {
        public CRUD_Proveedor()
        {

            InitializeComponent();
            OcultarBarra();
            listarProv();
            groupBox1.Enabled = false;
            dgv_Proveedores.Columns["CiudadID"].Visible = false;

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
            txt_NombProveedor.Text = "";
            comboBoxCiudad.SelectedIndex = 0;
            txt_TelfProveedor.Text = " ";
            checkBox_Prov.Checked = false;

        }

        public void listarProv()
        {
            dgv_Proveedores.DataSource = logProv.Instancia.ListarProv();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_NuevProveedor_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

            btn_AgProv.Visible = true;
            LimpiarVariables();
            btn_ModProv.Visible = false;
        }

        private void btn_EditProveedor_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btn_ModProv.Visible = true;
            btn_AgProv.Visible = false;
        }

        private void btn_AgProv_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entProv Prov = new entProv();
                Prov.idProv = int.Parse(txt_CodProveedor.Text.Trim());
                Prov.NombProv = txt_NombProveedor.Text.Trim();
                Prov.CiudadID = Convert.ToInt32(comboBoxCiudad.SelectedValue);
                //c.fecRegCliente = dtPickerRegCliente.Value;
                Prov.TelfProv = int.Parse(txt_TelfProveedor.Text.Trim());
                Prov.estProv = checkBox_Prov.Checked;
                logProv.Instancia.InsertaProv(Prov);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarProv();
        }

        private void btn_ModProv_Click(object sender, EventArgs e)
        {
            try
            {
                entProv Prov = new entProv();
                Prov.idProv = int.Parse(txt_CodProveedor.Text.Trim());
                Prov.NombProv = txt_NombProveedor.Text.Trim();
                Prov.CiudadID = (int)comboBoxCiudad.SelectedValue;
                //c.fecRegCliente = dtPickerRegCliente.Value;
                Prov.TelfProv = int.Parse(txt_TelfProveedor.Text.Trim());
                Prov.estProv = checkBox_Prov.Checked;

                logProv.Instancia.EditarProv(Prov);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarProv();
        }

        private void btn_InProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                entProv Prov = new entProv();

                Prov.idProv = int.Parse(txt_CodProveedor.Text.Trim());
                //cbkEstadoCliente.Checked = false;
                //c.estCliente = cbkEstadoCliente.Checked;
                Prov.estProv = checkBox_Prov.Checked;
                logProv.Instancia.DeshabilitarProv(Prov);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarProv();
        }

        private void dgv_Proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgv_Proveedores.Rows[e.RowIndex]; //
            txt_CodProveedor.Text = filaActual.Cells[0].Value.ToString();
            txt_NombProveedor.Text = filaActual.Cells[1].Value.ToString();
            comboBoxCiudad.Text = filaActual.Cells[2].Value.ToString();
            txt_TelfProveedor.Text = filaActual.Cells[3].Value.ToString();
            checkBox_Prov.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void comboBoxCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCiudad.SelectedValue != null)
            {
                if (comboBoxCiudad.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)comboBoxCiudad.SelectedValue;
                    int idCiudad = Convert.ToInt32(drv["CiudadID"]);
                    comboBoxCiudad.DataSource = logProv.Instancia.CargarNombreCiudad(idCiudad);

                }
                else
                {
                    int idCiudad = Convert.ToInt32(comboBoxCiudad.SelectedValue);
                    comboBoxCiudad.DataSource = logProv.Instancia.CargarNombreCiudad(idCiudad);

                }
                comboBoxCiudad.DisplayMember = "Nombciudad";
                comboBoxCiudad.ValueMember = "CiudadID";
            }
        }

        private void CRUD_Proveedor_Load(object sender, EventArgs e)
        {
            comboBoxCiudad.DataSource = logProv.Instancia.CargarCiudad();
            comboBoxCiudad.DisplayMember = "Nombciudad";
            comboBoxCiudad.ValueMember = "CiudadID";
        }
    }
}
