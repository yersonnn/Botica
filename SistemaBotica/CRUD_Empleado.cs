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
    public partial class CRUD_Empleado : Form
    {
        public CRUD_Empleado()
        {
            InitializeComponent();
            OcultarBarra();
            listarEmpl();
            groupBox1.Enabled = false;
            
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
            txt_DniEmpleado.Text = "";
            txt_NombEmpleado.Text = "";
            txt_TelfEmpleado.Text = " ";
            comboBoxCargo.Text = " ";
            checkBox_Emple.Checked = false;

        }

        public void listarEmpl()
        {
            dgv_Empleados.DataSource = logEmpl.Instancia.ListarEmpl();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Empleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgv_Empleados.Rows[e.RowIndex]; //
            txt_DniEmpleado.Text = filaActual.Cells[0].Value.ToString();
            txt_NombEmpleado.Text = filaActual.Cells[1].Value.ToString();
            txt_TelfEmpleado.Text = filaActual.Cells[2].Value.ToString();
            comboBoxCargo.Text = filaActual.Cells[3].Value.ToString();
            checkBox_Emple.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }

        private void btn_NuevEmplead_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

            btn_AgEmpl.Visible = true;
            LimpiarVariables();
            btn_ModEmple.Visible = false;
        }

        private void btn_AgEmpl_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entEmpl empl = new entEmpl();
                empl.idEmpl= int.Parse(txt_DniEmpleado.Text.Trim());
                empl.NombEmpl = txt_NombEmpleado.Text.Trim();
                empl.CeluEmpl = int.Parse(txt_TelfEmpleado.Text.Trim());
                empl.CargoEmpl = comboBoxCargo.Text.Trim();
                //c.fecRegCliente = dtPickerRegCliente.Value;

                empl.estEmpl = checkBox_Emple.Checked;
                logEmpl.Instancia.InsertaEmpl(empl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarEmpl();
        }

        private void btn_EditEmplead_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btn_ModEmple.Visible = true;
            btn_AgEmpl.Visible = false;
        }

        private void btn_ModEmple_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpl empl = new entEmpl();
                empl.idEmpl = int.Parse(txt_DniEmpleado.Text.Trim());
                empl.NombEmpl = txt_NombEmpleado.Text.Trim();
                empl.CeluEmpl = int.Parse(txt_TelfEmpleado.Text.Trim());
                empl.CargoEmpl = comboBoxCargo.Text.Trim();
                //c.fecRegCliente = dtPickerRegCliente.Value;

                empl.estEmpl = checkBox_Emple.Checked;

                logEmpl.Instancia.EditaEmpl(empl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarEmpl();
        }

        private void btn_InEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpl empl = new entEmpl();

                empl.idEmpl = int.Parse(txt_DniEmpleado.Text.Trim());
                //cbkEstadoCliente.Checked = false;
                //c.estCliente = cbkEstadoCliente.Checked;
                empl.estEmpl = checkBox_Emple.Checked;
                logEmpl.Instancia.DeshabilitarEmpl(empl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarEmpl();
        }
    }
}
