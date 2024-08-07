﻿using System;
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
    public partial class CRUD_Producto : Form
    {
        public CRUD_Producto()
        {
            InitializeComponent();
            OcultarBarra();
            listarProd();
            groupBox1.Enabled = false;
            txt_CodProducto.Enabled = false;
            dgv_Productos.Columns["IDCatProd"].Visible = false;
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
            comboBoxCatProd.Text = "";
            txt_NombProducto.Text = "";
            comboBoxCatProd.Text = " ";
            txt_PrecProducto.Text = " ";
            checkBox_Produc.Checked = false;

        }

        private void ActualizarCombos()
        {
            comboBoxCatProd.DataSource = logProd.Instancia.CargarCategoria();
            comboBoxCatProd.DisplayMember = "Nombcategoria";
            comboBoxCatProd.ValueMember = "CategoriaID";

        }

        public void listarProd()
        {
            dgv_Productos.DataSource = logProd.Instancia.ListarProd();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_NuevProduc_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btn_AgProduc.Visible = true;
            LimpiarVariables();
            btn_ModProduc.Visible = false;
        }

        private void btn_AgProduc_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entProd Prod = new entProd();
                Prod.Producto = txt_NombProducto.Text.Trim();
                Prod.IDCatProd = Convert.ToInt32(comboBoxCatProd.SelectedValue);
                //c.fecRegCliente = dtPickerRegCliente.Value;
                Prod.PrecioUnitario = double.Parse(txt_PrecProducto.Text.Trim());
                //Prod.StockProd = int.Parse(txt_StockProducto.Text.Trim());
                Prod.estProd = checkBox_Produc.Checked;
                logProd.Instancia.InsertaProd(Prod);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarProd();
            ActualizarCombos();

        }

        private void btn_ModProduc_Click(object sender, EventArgs e)
        {
            try
            {
                entProd Prod = new entProd();
                Prod.Producto = txt_NombProducto.Text.Trim();
                Prod.IDCatProd = (int)comboBoxCatProd.SelectedValue;
                //c.fecRegCliente = dtPickerRegCliente.Value;
                Prod.PrecioUnitario = double.Parse(txt_PrecProducto.Text.Trim());
                //Prod.StockProd = int.Parse(txt_StockProducto.Text.Trim());
                Prod.estProd = checkBox_Produc.Checked;

                logProd.Instancia.EditaProd(Prod);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarProd();
            ActualizarCombos();
        }

        private void btn_EditProduc_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btn_ModProduc.Visible = true;
            btn_AgProduc.Visible = false;
        }

        private void btn_InProducto_Click(object sender, EventArgs e)
        {
            try
            {
                entProd Prod = new entProd();

                Prod.idProd = int.Parse(txt_CodProducto.Text.Trim());
                //cbkEstadoCliente.Checked = false;
                //c.estCliente = cbkEstadoCliente.Checked;

                logProd.Instancia.DeshabilitarProd(Prod);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listarProd();
            
        }

        private void dgv_Productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgv_Productos.Rows[e.RowIndex]; //
            txt_CodProducto.Text = filaActual.Cells[0].Value.ToString();
            txt_NombProducto.Text = filaActual.Cells[1].Value.ToString();
            comboBoxCatProd.Text = filaActual.Cells[3].Value.ToString();
            txt_PrecProducto.Text = filaActual.Cells[4].Value.ToString();
            checkBox_Produc.Checked = Convert.ToBoolean(filaActual.Cells[6].Value);
        }

        private void txt_CatProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCatProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCatProd.SelectedValue != null)
            {
                if (comboBoxCatProd.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)comboBoxCatProd.SelectedValue;
                    int idCategoria = Convert.ToInt32(drv["CategoriaID"]);
                    comboBoxCatProd.DataSource = logProd.Instancia.CargarNombre(idCategoria);

                }
                else
                {
                    int idCategoria = Convert.ToInt32(comboBoxCatProd.SelectedValue);
                    comboBoxCatProd.DataSource = logProd.Instancia.CargarNombre(idCategoria);

                }
                comboBoxCatProd.DisplayMember = "Nombcategoria";
                comboBoxCatProd.ValueMember = "CategoriaID";
            }
        }

        private void CRUD_Producto_Load(object sender, EventArgs e)
        {
            ActualizarCombos();
        }
    }
}
