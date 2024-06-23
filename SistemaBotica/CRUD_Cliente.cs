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
    public partial class CRUD_Cliente : Form
    {
        public CRUD_Cliente()
        {

            InitializeComponent();
            OcultarBarra();
            listarCli();
            groupBox1.Enabled = false;
            //txtidCliente.Enabled = false;
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
            txt_NombCliente.Text = "";
            txt_CorreoCliente.Text = " ";
            txt_TelfCliente.Text = " ";
            checkBox_Clie.Checked = false;

        }

        public void listarCli()
        {
            dgv_Clientes.DataSource = logClient.Instancia.ListarCli();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_NuevClient_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

            btn_AgClien.Visible = true;
            LimpiarVariables();
            btn_ModClie.Visible = false;
        }

        private void btn_AgClien_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCliente cli = new entCliente();
                cli.idCli= int.Parse(txt_DniCliente.Text.Trim());
                cli.NombCli = txt_NombCliente.Text.Trim();
                cli.CorreoCli = txt_CorreoCliente.Text.Trim();
                //c.fecRegCliente = dtPickerRegCliente.Value;
                cli.CeluCli = int.Parse(txt_TelfCliente.Text.Trim());
                cli.estCli = checkBox_Clie.Checked;
                logClient.Instancia.InsertaCli(cli);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarCli();
        }

        private void btn_ModClie_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente cli = new entCliente();
                cli.idCli = int.Parse(txt_DniCliente.Text.Trim());
                cli.NombCli = txt_NombCliente.Text.Trim();
                cli.CorreoCli = txt_CorreoCliente.Text.Trim();
                //c.fecRegCliente = dtPickerRegCliente.Value;
                cli.CeluCli = int.Parse(txt_TelfCliente.Text.Trim());
                cli.estCli = checkBox_Clie.Checked;

                logClient.Instancia.EditaCli(cli);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarCli();
        }

        private void btn_EditClient_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btn_ModClie.Visible = true;
            btn_AgClien.Visible = false;
        }

        private void btn_InCliente_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente cli = new entCliente();

                cli.idCli = int.Parse(txt_DniCliente.Text.Trim());
                //cbkEstadoCliente.Checked = false;
                //c.estCliente = cbkEstadoCliente.Checked;
                cli.estCli = checkBox_Clie.Checked;
                logClient.Instancia.DeshabilitarCli(cli);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarCli();
        }

        private void dgv_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgv_Clientes.Rows[e.RowIndex]; //
            txt_DniCliente.Text = filaActual.Cells[0].Value.ToString();
            txt_NombCliente.Text = filaActual.Cells[1].Value.ToString();
            txt_CorreoCliente.Text = filaActual.Cells[2].Value.ToString();
            txt_TelfCliente.Text = filaActual.Cells[3].Value.ToString();
            checkBox_Clie.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);

        }
    }
}
