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
    public partial class CORE_VentaDirecta : Form
    {
        public CORE_VentaDirecta()
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //entDetVentaProd dProd = new entDetVentaProd();
            //entProducto Prod = new entProducto();

            //if ((lbID.Text.Trim() != "") && (txtCantidad.Text.Trim() != ""))
            //{
            //    if ((Convert.ToInt32(txtCantidad.Text) > 0) && (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtStock.Text)))
            //    {
            //        if (confilas == 0)
            //        {
            //            dtgVentaProductos.Rows.Add(lbID.Text, cmbNombre.Text, txtDescProducto.Text, txtCantidad.Text, txtPrecioUni.Text, cmbPromocion.Text);
            //            decimal precioTotal = Convert.ToDecimal(dtgVentaProductos.Rows[confilas].Cells[3].Value) * Convert.ToDecimal(dtgVentaProductos.Rows[confilas].Cells[4].Value);
            //            dtgVentaProductos.Rows[confilas].Cells[6].Value = precioTotal;
            //            decimal descuento = logPromocion.Instancia.ObtenerDescuento(Convert.ToInt32(cmbPromocion.SelectedValue));
            //            decimal precioDescuento = AplicarDescuento(Convert.ToDecimal(dtgVentaProductos.Rows[confilas].Cells[6].Value), descuento);
            //            dtgVentaProductos.Rows[confilas].Cells[7].Value = precioDescuento;
            //            confilas++;
            //        }
            //        else
            //        {
            //            dtgVentaProductos.Rows.Add(lbID.Text, cmbNombre.Text, txtDescProducto.Text, txtCantidad.Text, txtPrecioUni.Text, cmbPromocion.Text);
            //            decimal precioTotal = Convert.ToDecimal(dtgVentaProductos.Rows[confilas].Cells[3].Value) * Convert.ToDecimal(dtgVentaProductos.Rows[confilas].Cells[4].Value);
            //            dtgVentaProductos.Rows[confilas].Cells[6].Value = precioTotal;
            //            decimal descuento = logPromocion.Instancia.ObtenerDescuento(Convert.ToInt32(cmbPromocion.SelectedValue));
            //            decimal precioDescuento = AplicarDescuento(Convert.ToDecimal(dtgVentaProductos.Rows[confilas].Cells[6].Value), descuento);
            //            dtgVentaProductos.Rows[confilas].Cells[7].Value = precioDescuento;
            //            confilas++;
            //        }
            //        //Limpiar();
            //    }
            //    MontoPagar = 0;
            //    foreach (DataGridViewRow Fila in dtgVentaProductos.Rows)
            //    {
            //        MontoPagar += Convert.ToDecimal(Fila.Cells[7].Value);
            //    }
            //    txtMontoPagar.Text = MontoPagar.ToString();
            //}
        }

        private void comboBoxNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNombreProd.SelectedValue != null)
            {
                if (comboBoxNombreProd.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)comboBoxNombreProd.SelectedValue;
                    int idProducto = Convert.ToInt32(drv["ProductoID"]);
                    entProd Prod = logProd.Instancia.BuscarProductoId(idProducto);
                    if (Prod != null && (Prod.estProd = true))
                    {
                        textBoxIDPROD.Text = Convert.ToString(Prod.idProd);
                        labelPrecio.Text = Convert.ToString(Prod.PrecioUnitario);
                        labelStock.Text = Convert.ToString(Prod.Stock);
                    }
                }
                else
                {
                    int idProducto = Convert.ToInt32(comboBoxNombreProd.SelectedValue);
                    entProd Prod = logProd.Instancia.BuscarProductoId(idProducto);
                    if (Prod != null && (Prod.estProd = true))
                    {
                        textBoxIDPROD.Text = Convert.ToString(Prod.idProd);
                        labelPrecio.Text = Convert.ToString(Prod.PrecioUnitario);
                        labelStock.Text = Convert.ToString(Prod.Stock);
                    }
                }
            }
        }

        private void CORE_VentaDirecta_Load(object sender, EventArgs e)
        {
            comboBoxNombreProd.DataSource = logInvent.Instancia.CargarProducto();
            comboBoxNombreProd.DisplayMember = "Nombproducto";
            comboBoxNombreProd.ValueMember = "ProductoID";

            comboBoxMetodoPago.DataSource = logOrdenVent.Instancia.CargarMetPag();
            comboBoxMetodoPago.DisplayMember = "Nombmetpago";
            comboBoxMetodoPago.ValueMember = "MetodoDePagoID";
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDNI_Cliente.Text))
            {
                int idCli;
                if (int.TryParse(textBoxDNI_Cliente.Text, out idCli))
                {
                    entCliente Clie = logClient.Instancia.BuscarClienteId(idCli);
                    if (Clie != null && Clie.estCli)
                    {
                        labelNombreCliente.Text = Convert.ToString(Clie.NombreCliente);
                    }
                    else
                    {
                        // Manejo del caso cuando el cliente no existe o no está activo
                        MessageBox.Show("Cliente no encontrado o inactivo.");
                    }
                }
                else
                {
                    // Manejo del caso cuando el DNI no es un número válido
                    MessageBox.Show("DNI inválido.");
                }
            }
            else
            {
                // Manejo del caso cuando el TextBox está vacío
                MessageBox.Show("Por favor, ingrese un DNI.");
            }

        }
        public static int confilas = 0;
        public static decimal MontoPagar = 0;
        private void btn_AgCarrito_Click(object sender, EventArgs e)
        {
            entDetalleVenta dProd = new entDetalleVenta();
            entProd Prod = new entProd();

            if ((textBoxIDPROD.Text.Trim() != "") && (textBoxCantidad.Text.Trim() != ""))
            {
                if ((Convert.ToInt32(textBoxCantidad.Text) > 0) && (Convert.ToInt32(textBoxCantidad.Text) <= Convert.ToInt32(labelStock.Text)))
                {
                    if (confilas == 0)
                    {
                        dgvDetVent.Rows.Add(comboBoxNombreProd.Text, textBoxCantidad.Text, labelPrecio.Text);
                        decimal precioTotal = Convert.ToDecimal(dgvDetVent.Rows[confilas].Cells[1].Value) * Convert.ToDecimal(dgvDetVent.Rows[confilas].Cells[2].Value);
                        dgvDetVent.Rows[confilas].Cells[3].Value = precioTotal;

                        confilas++;
                    }
                    else
                    {
                        dgvDetVent.Rows.Add(comboBoxNombreProd.Text, textBoxCantidad.Text, labelPrecio.Text);
                        decimal precioTotal = Convert.ToDecimal(dgvDetVent.Rows[confilas].Cells[1].Value) * Convert.ToDecimal(dgvDetVent.Rows[confilas].Cells[2].Value);
                        dgvDetVent.Rows[confilas].Cells[3].Value = precioTotal;
                        confilas++;
                    }
                    //Limpiar();
                }
                MontoPagar = 0;
                foreach (DataGridViewRow Fila in dgvDetVent.Rows)
                {
                    MontoPagar += Convert.ToDecimal(Fila.Cells[3].Value);
                }
                textBox_MontoTotal.Text = MontoPagar.ToString();
            }
        }

        private void GrabarDetalle(int cod)
        {
            foreach (DataGridViewRow Fila in dgvDetVent.Rows)
            {
                entDetalleVenta dProd = new entDetalleVenta();
                dProd.DetVentaID = cod;



                dProd.ProductoID = Convert.ToInt32(Fila.Cells[0].Value.ToString());
                


                dProd.Cantidad = Convert.ToInt32(Fila.Cells[1].Value.ToString());
                dProd.PrecioUnit = Convert.ToDecimal(Fila.Cells[2].Value.ToString());
                dProd.PrecioTotal = Convert.ToDecimal(Fila.Cells[3].Value.ToString());

                logOrdenVent.Instancia.InsertarDetVenta(dProd);
            }
        }

        private void comboBoxMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMetodoPago.SelectedValue != null)
            {
                if (comboBoxMetodoPago.SelectedValue is DataRowView)
                {
                    DataRowView drv = (DataRowView)comboBoxMetodoPago.SelectedValue;
                    int idMetPag = Convert.ToInt32(drv["MetodoDePagoID"]);
                    comboBoxMetodoPago.DataSource = logOrdenVent.Instancia.CargarNombreMetPag(idMetPag);

                }
                else
                {
                    int idMetPag = Convert.ToInt32(comboBoxMetodoPago.SelectedValue);
                    comboBoxMetodoPago.DataSource = logOrdenVent.Instancia.CargarNombreMetPag(idMetPag);

                }
                comboBoxMetodoPago.DisplayMember = "Nombmetpago";
                comboBoxMetodoPago.ValueMember = "MetodoDePagoID";
            }
            
        }

        private void btn_QuitarCarri_Click(object sender, EventArgs e)
        {
            if (confilas > 0)
            {
                MontoPagar = MontoPagar - Convert.ToDecimal(dgvDetVent.Rows[dgvDetVent.CurrentRow.Index].Cells[3].Value);
                textBox_MontoTotal.Text = MontoPagar.ToString();
                dgvDetVent.Rows.RemoveAt(dgvDetVent.CurrentRow.Index);
                confilas--;
            }
        }
    }
}
