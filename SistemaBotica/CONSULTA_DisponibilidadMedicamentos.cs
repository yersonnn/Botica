using Capa_Entidad;
using CapaLogica;
using System.Data;

namespace SistemaBotica
{
    public partial class CONSULTA_DisponibilidadMedicamentos : Form
    {
        public CONSULTA_DisponibilidadMedicamentos()
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
        private void btn_buscar_Click(object sender, EventArgs e)
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
                        dgv_dispMed.DataSource= logProd.Instancia.ObtenerStockProducto(idProducto);
                    }
                }
                else
                {
                    int idProducto = Convert.ToInt32(comboBoxNombreProd.SelectedValue);
                    entProd Prod = logProd.Instancia.BuscarProductoId(idProducto);
                    if (Prod != null && (Prod.estProd = true))
                    {
                        dgv_dispMed.DataSource = logProd.Instancia.ObtenerStockProducto(idProducto);
                    }
                }
            }

            ActualizarCombos();
        }
        public void ActualizarCombos()
        {
            comboBoxNombreProd.DataSource = logInvent.Instancia.CargarProducto();
            comboBoxNombreProd.DisplayMember = "Nombproducto";
            comboBoxNombreProd.ValueMember = "ProductoID";

        }
        private void CONSULTA_DisponibilidadMedicamentos_Load(object sender, EventArgs e)
        {
            ActualizarCombos();
        }
    }
}
