namespace CapaPresentacion
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelCont = new Panel();
            btn_Proveedor = new Button();
            btn_Cliente = new Button();
            btn_Empleado = new Button();
            btn_Venta = new Button();
            btn_Producto = new Button();
            btn_Inventario = new Button();
            panelmenu = new Panel();
            btn_ProdProv = new Button();
            btn_DispMedic = new Button();
            btn_Categoria = new Button();
            btn_MetPago = new Button();
            pictureBox1 = new PictureBox();
            panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelCont
            // 
            PanelCont.BackColor = SystemColors.ActiveCaption;
            PanelCont.Location = new Point(191, 1);
            PanelCont.Name = "PanelCont";
            PanelCont.Size = new Size(1215, 726);
            PanelCont.TabIndex = 0;
            PanelCont.Paint += PanelCont_Paint;
            // 
            // btn_Proveedor
            // 
            btn_Proveedor.BackColor = Color.AliceBlue;
            btn_Proveedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Proveedor.Location = new Point(-6, 492);
            btn_Proveedor.Name = "btn_Proveedor";
            btn_Proveedor.Size = new Size(194, 42);
            btn_Proveedor.TabIndex = 5;
            btn_Proveedor.Text = "Proveedores";
            btn_Proveedor.UseVisualStyleBackColor = false;
            btn_Proveedor.Click += btn_Proveedor_Click;
            // 
            // btn_Cliente
            // 
            btn_Cliente.BackColor = Color.AliceBlue;
            btn_Cliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cliente.Location = new Point(-4, 284);
            btn_Cliente.Name = "btn_Cliente";
            btn_Cliente.Size = new Size(194, 41);
            btn_Cliente.TabIndex = 1;
            btn_Cliente.Text = "Clientes";
            btn_Cliente.UseVisualStyleBackColor = false;
            btn_Cliente.Click += btn_Cliente_Click;
            // 
            // btn_Empleado
            // 
            btn_Empleado.BackColor = Color.AliceBlue;
            btn_Empleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Empleado.Location = new Point(-4, 453);
            btn_Empleado.Name = "btn_Empleado";
            btn_Empleado.Size = new Size(194, 43);
            btn_Empleado.TabIndex = 3;
            btn_Empleado.Text = "Empleados";
            btn_Empleado.UseVisualStyleBackColor = false;
            btn_Empleado.Click += btn_Empleado_Click;
            // 
            // btn_Venta
            // 
            btn_Venta.BackColor = SystemColors.GradientActiveCaption;
            btn_Venta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Venta.ForeColor = SystemColors.ControlText;
            btn_Venta.Location = new Point(0, 181);
            btn_Venta.Name = "btn_Venta";
            btn_Venta.Size = new Size(194, 47);
            btn_Venta.TabIndex = 6;
            btn_Venta.Text = "VENTA";
            btn_Venta.UseVisualStyleBackColor = false;
            btn_Venta.Click += btn_Venta_Click;
            // 
            // btn_Producto
            // 
            btn_Producto.BackColor = Color.AliceBlue;
            btn_Producto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Producto.Location = new Point(-4, 323);
            btn_Producto.Name = "btn_Producto";
            btn_Producto.Size = new Size(194, 42);
            btn_Producto.TabIndex = 4;
            btn_Producto.Text = "Productos";
            btn_Producto.UseVisualStyleBackColor = false;
            btn_Producto.Click += btn_Producto_Click;
            // 
            // btn_Inventario
            // 
            btn_Inventario.BackColor = SystemColors.GradientActiveCaption;
            btn_Inventario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Inventario.Location = new Point(0, 224);
            btn_Inventario.Name = "btn_Inventario";
            btn_Inventario.Size = new Size(194, 45);
            btn_Inventario.TabIndex = 7;
            btn_Inventario.Text = "INVENTARIO";
            btn_Inventario.UseVisualStyleBackColor = false;
            btn_Inventario.Click += btn_Inventario_Click;
            // 
            // panelmenu
            // 
            panelmenu.BackColor = SystemColors.GradientInactiveCaption;
            panelmenu.Controls.Add(btn_ProdProv);
            panelmenu.Controls.Add(btn_DispMedic);
            panelmenu.Controls.Add(btn_Empleado);
            panelmenu.Controls.Add(btn_Categoria);
            panelmenu.Controls.Add(btn_MetPago);
            panelmenu.Controls.Add(btn_Inventario);
            panelmenu.Controls.Add(btn_Producto);
            panelmenu.Controls.Add(btn_Venta);
            panelmenu.Controls.Add(btn_Cliente);
            panelmenu.Controls.Add(btn_Proveedor);
            panelmenu.Controls.Add(pictureBox1);
            panelmenu.Location = new Point(1, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(190, 727);
            panelmenu.TabIndex = 1;
            panelmenu.Paint += panelmenu_Paint;
            // 
            // btn_ProdProv
            // 
            btn_ProdProv.BackColor = SystemColors.Info;
            btn_ProdProv.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ProdProv.Location = new Point(-4, 609);
            btn_ProdProv.Name = "btn_ProdProv";
            btn_ProdProv.Size = new Size(194, 53);
            btn_ProdProv.TabIndex = 12;
            btn_ProdProv.Text = "Productos por Proveedor";
            btn_ProdProv.UseVisualStyleBackColor = false;
            btn_ProdProv.Click += btn_ProdProv_Click;
            // 
            // btn_DispMedic
            // 
            btn_DispMedic.BackColor = SystemColors.Info;
            btn_DispMedic.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DispMedic.Location = new Point(-4, 560);
            btn_DispMedic.Name = "btn_DispMedic";
            btn_DispMedic.Size = new Size(194, 53);
            btn_DispMedic.TabIndex = 11;
            btn_DispMedic.Text = "Disponibilidad de Medicamentos";
            btn_DispMedic.UseVisualStyleBackColor = false;
            btn_DispMedic.Click += btn_DispMedic_Click;
            // 
            // btn_Categoria
            // 
            btn_Categoria.BackColor = Color.AliceBlue;
            btn_Categoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Categoria.Location = new Point(-4, 364);
            btn_Categoria.Name = "btn_Categoria";
            btn_Categoria.Size = new Size(194, 51);
            btn_Categoria.TabIndex = 10;
            btn_Categoria.Text = "Categoria de Productos";
            btn_Categoria.UseVisualStyleBackColor = false;
            btn_Categoria.Click += btn_Categoria_Click;
            // 
            // btn_MetPago
            // 
            btn_MetPago.BackColor = Color.AliceBlue;
            btn_MetPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_MetPago.Location = new Point(-4, 413);
            btn_MetPago.Name = "btn_MetPago";
            btn_MetPago.Size = new Size(194, 42);
            btn_MetPago.TabIndex = 8;
            btn_MetPago.Text = "Metodos de Pago";
            btn_MetPago.UseVisualStyleBackColor = false;
            btn_MetPago.Click += btn_MetPago_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._418478871_122104982660174565_4749043646504816287_n_removebg_preview;
            pictureBox1.Location = new Point(-35, -31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 730);
            Controls.Add(panelmenu);
            Controls.Add(PanelCont);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelCont;
        private Button btn_Proveedor;
        private Button btn_Cliente;
        private Button btn_Empleado;
        private Button btn_Venta;
        private Button btn_Producto;
        private Button btn_Inventario;
        private Panel panelmenu;
        private Button btn_MetPago;
        private PictureBox pictureBox1;
        private Button btn_Categoria;
        private Button btn_DispMedic;
        private Button btn_ProdProv;
    }
}