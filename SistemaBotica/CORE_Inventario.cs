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
    public partial class CORE_Inventario : Form
    {
        public CORE_Inventario()
        {
            InitializeComponent();
            OcultarBarra();
            listarInv();
            dgvInventario.Columns["ProdID"].Visible = false;
            dgvInventario.Columns["ProveerID"].Visible = false;
            dgvInventario.Columns["estInventario"].Visible = false;
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
            
            comboBoxNombProd.Text = "";
            comboBoxNombProv.Text = "";
            textBoxCantProd.Text = " ";
            //dateFecha.Text = " ";
        }

        public void listarInv()
        {
            dgvInventario.DataSource = logInvent.Instancia.ListarInv();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxNombProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNombProd.SelectedValue != null)
            {
                if (comboBoxNombProd.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)comboBoxNombProd.SelectedValue;
                    int idProd = Convert.ToInt32(drv["ProductoID"]);
                    comboBoxNombProd.DataSource = logInvent.Instancia.CargarNombreProducto(idProd);

                }
                else
                {
                    int idProd = Convert.ToInt32(comboBoxNombProd.SelectedValue);
                    comboBoxNombProd.DataSource = logInvent.Instancia.CargarNombreProducto(idProd);

                }
                comboBoxNombProd.DisplayMember = "Nombproducto";
                comboBoxNombProd.ValueMember = "ProductoID";
            }
        }

        private void comboBoxNombProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNombProv.SelectedValue != null)
            {
                if (comboBoxNombProv.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)comboBoxNombProv.SelectedValue;
                    int IdProveer = Convert.ToInt32(drv["ProveedorID"]);
                    comboBoxNombProv.DataSource = logInvent.Instancia.CargarNombreProveedor(IdProveer);

                }
                else
                {
                    int IdProveer = Convert.ToInt32(comboBoxNombProv.SelectedValue);
                    comboBoxNombProv.DataSource = logInvent.Instancia.CargarNombreProveedor(IdProveer);

                }
                comboBoxNombProv.DisplayMember = "Nombempresa";
                comboBoxNombProv.ValueMember = "ProveedorID";
            }
        }

        public void ActualizarCombos()
        {
            comboBoxNombProd.DataSource = logInvent.Instancia.CargarProducto();
            comboBoxNombProd.DisplayMember = "Nombproducto";
            comboBoxNombProd.ValueMember = "ProductoID";

            comboBoxNombProv.DataSource = logInvent.Instancia.CargarProveedor();
            comboBoxNombProv.DisplayMember = "Nombempresa";
            comboBoxNombProv.ValueMember = "ProveedorID";
        }

        private void CORE_Inventario_Load(object sender, EventArgs e)
        {
            ActualizarCombos();
        }

        private void btn_RegInv_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entInventario inv = new entInventario();
                inv.ProdID = Convert.ToInt32(comboBoxNombProd.SelectedValue);
                inv.Cantidad = Convert.ToInt32(textBoxCantProd.Text);
                inv.ProveerID = Convert.ToInt32(comboBoxNombProv.SelectedValue);
                inv.Fecha = Convert.ToDateTime(dateFecha.Value);
                inv.estInventario = true;
                logInvent.Instancia.InsertaInv(inv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarInv();
            ActualizarCombos();
        }

        private void btn_ModInv_Click(object sender, EventArgs e)
        {
            try
            {
                entInventario inv = new entInventario();
                inv.ProdID = Convert.ToInt32(comboBoxNombProd.SelectedValue);
                inv.Cantidad = Convert.ToInt32(textBoxCantProd.Text);
                inv.ProveerID = Convert.ToInt32(comboBoxNombProv.SelectedValue);
                inv.Fecha = Convert.ToDateTime(dateFecha.Value);
                inv.estInventario = true;
                logInvent.Instancia.EditarInv(inv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarInv();
        }

        private void btn_AnularInv_Click(object sender, EventArgs e)
        {
            try
            {
                entInventario inv = new entInventario();

                inv.idInvent = int.Parse(lbIDinvent.Text.Trim());
                inv.estInventario = false;
                logInvent.Instancia.DeshabilitarInv(inv);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listarInv();
        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvInventario.Rows[e.RowIndex]; //
            lbIDinvent.Text = filaActual.Cells[0].Value.ToString();
            comboBoxNombProd.Text = filaActual.Cells[1].Value.ToString();
            textBoxCantProd.Text = filaActual.Cells[2].Value.ToString();
            comboBoxNombProv.Text = filaActual.Cells[3].Value.ToString();
            dateFecha.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);
        }
    }
}
