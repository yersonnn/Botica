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
    public partial class CRUD_MetodoPago : Form
    {
        public CRUD_MetodoPago()
        {
            InitializeComponent();
            OcultarBarra();
            listarMetPag();
            groupBoxMetPag.Enabled = false;
            txt_CodMetodo.Enabled = false;

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
            txt_CodMetodo.Text = "";
            txt_NombMetodo.Text = "";
            comboBoxTipoMetPag.Text = " ";
            checkBox_MetPag.Checked = false;

        }

        public void listarMetPag()
        {
            dgv_MetPago.DataSource = logMetPag.Instancia.ListarMetPag();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entMetodoPago met = new entMetodoPago();
                met.MetodoPago = txt_NombMetodo.Text.Trim();
                met.Tipo = comboBoxTipoMetPag.Text.Trim();
                //c.fecRegCliente = dtPickerRegCliente.Value;
                //c.idCiudad = int.Parse(txtidCiudad.Text.Trim());
                met.estMetPag = checkBox_MetPag.Checked;
                logMetPag.Instancia.InsertaMetPag(met);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxMetPag.Enabled = false;
            listarMetPag();
        }

        private void btn_ModMetodo_Click(object sender, EventArgs e)
        {

            try
            {
                entMetodoPago met = new entMetodoPago();
                met.MetodoDePagoID = int.Parse(txt_CodMetodo.Text.Trim());
                met.MetodoPago = txt_NombMetodo.Text.Trim();
                met.Tipo = comboBoxTipoMetPag.Text.Trim();
                //c.idTipoCliente = int.Parse(txtidTipoCliente.Text.Trim());
                //c.fecRegCliente = dtPickerRegCliente.Value;
                //c.idCiudad = int.Parse(txtidCiudad.Text.Trim());
                met.estMetPag = checkBox_MetPag.Checked;

                logMetPag.Instancia.EditaMetPag(met);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxMetPag.Enabled = false;
            listarMetPag();


        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            groupBoxMetPag.Enabled = true;

            btn_AgrMetodo.Visible = true;
            LimpiarVariables();
            btn_ModMetodo.Visible = false;

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            groupBoxMetPag.Enabled = true;
            btn_ModMetodo.Visible = true;
            btn_AgrMetodo.Visible = false;

        }

        private void btn_InMetodo_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago met = new entMetodoPago();

                met.MetodoDePagoID = int.Parse(txt_CodMetodo.Text.Trim());
                //cbkEstadoCliente.Checked = false;
                //c.estCliente = cbkEstadoCliente.Checked;
                met.estMetPag = checkBox_MetPag.Checked;
                logMetPag.Instancia.DeshabilitarMetPag(met);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxMetPag.Enabled = false;
            listarMetPag();

        }

        private void dgv_MetPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgv_MetPago.Rows[e.RowIndex];
            txt_CodMetodo.Text = filaActual.Cells[0].Value.ToString();
            txt_NombMetodo.Text = filaActual.Cells[1].Value.ToString();
            comboBoxTipoMetPag.Text = filaActual.Cells[2].Value.ToString();
            checkBox_MetPag.Checked = Convert.ToBoolean(filaActual.Cells[3].Value);
        }

        private void txt_CodMetodo_TextChanged(object sender, EventArgs e)
        {

        }



        private void dgv_MetPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
