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
            label1 = new Label();
            btn_Inventario = new Button();
            panelmenu = new Panel();
            label2 = new Label();
            btn_MetPago = new Button();
            panelmenu.SuspendLayout();
            SuspendLayout();
            // 
            // PanelCont
            // 
            PanelCont.Location = new Point(209, 1);
            PanelCont.Name = "PanelCont";
            PanelCont.Size = new Size(1197, 726);
            PanelCont.TabIndex = 0;
            PanelCont.Paint += PanelCont_Paint;
            // 
            // btn_Proveedor
            // 
            btn_Proveedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Proveedor.Location = new Point(1, 397);
            btn_Proveedor.Name = "btn_Proveedor";
            btn_Proveedor.Size = new Size(194, 60);
            btn_Proveedor.TabIndex = 5;
            btn_Proveedor.Text = "Proveedor";
            btn_Proveedor.UseVisualStyleBackColor = true;
            btn_Proveedor.Click += btn_Proveedor_Click;
            // 
            // btn_Cliente
            // 
            btn_Cliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cliente.Location = new Point(1, 197);
            btn_Cliente.Name = "btn_Cliente";
            btn_Cliente.Size = new Size(194, 60);
            btn_Cliente.TabIndex = 1;
            btn_Cliente.Text = "Cliente";
            btn_Cliente.UseVisualStyleBackColor = true;
            btn_Cliente.Click += btn_Cliente_Click;
            // 
            // btn_Empleado
            // 
            btn_Empleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Empleado.Location = new Point(1, 263);
            btn_Empleado.Name = "btn_Empleado";
            btn_Empleado.Size = new Size(194, 60);
            btn_Empleado.TabIndex = 3;
            btn_Empleado.Text = "Empleado";
            btn_Empleado.UseVisualStyleBackColor = true;
            btn_Empleado.Click += btn_Empleado_Click;
            // 
            // btn_Venta
            // 
            btn_Venta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Venta.Location = new Point(8, 37);
            btn_Venta.Name = "btn_Venta";
            btn_Venta.Size = new Size(194, 60);
            btn_Venta.TabIndex = 6;
            btn_Venta.Text = "VENTA";
            btn_Venta.UseVisualStyleBackColor = true;
            btn_Venta.Visible = false;
            btn_Venta.Click += btn_Venta_Click;
            // 
            // btn_Producto
            // 
            btn_Producto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Producto.Location = new Point(1, 329);
            btn_Producto.Name = "btn_Producto";
            btn_Producto.Size = new Size(194, 60);
            btn_Producto.TabIndex = 4;
            btn_Producto.Text = "Producto";
            btn_Producto.UseVisualStyleBackColor = true;
            btn_Producto.Click += btn_Producto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 3);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 2;
            label1.Text = "MENU PRINCIPAL";
            // 
            // btn_Inventario
            // 
            btn_Inventario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Inventario.Location = new Point(8, 103);
            btn_Inventario.Name = "btn_Inventario";
            btn_Inventario.Size = new Size(194, 60);
            btn_Inventario.TabIndex = 7;
            btn_Inventario.Text = "INVENTARIO";
            btn_Inventario.UseVisualStyleBackColor = true;
            btn_Inventario.Visible = false;
            btn_Inventario.Click += btn_Inventario_Click;
            // 
            // panelmenu
            // 
            panelmenu.Controls.Add(label2);
            panelmenu.Controls.Add(btn_MetPago);
            panelmenu.Controls.Add(btn_Inventario);
            panelmenu.Controls.Add(label1);
            panelmenu.Controls.Add(btn_Producto);
            panelmenu.Controls.Add(btn_Venta);
            panelmenu.Controls.Add(btn_Empleado);
            panelmenu.Controls.Add(btn_Cliente);
            panelmenu.Controls.Add(btn_Proveedor);
            panelmenu.Location = new Point(1, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(208, 727);
            panelmenu.TabIndex = 1;
            panelmenu.Paint += panelmenu_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 166);
            label2.Name = "label2";
            label2.Size = new Size(177, 28);
            label2.TabIndex = 9;
            label2.Text = "MANTENEDORES";
            label2.Click += label2_Click;
            // 
            // btn_MetPago
            // 
            btn_MetPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_MetPago.Location = new Point(4, 468);
            btn_MetPago.Name = "btn_MetPago";
            btn_MetPago.Size = new Size(194, 60);
            btn_MetPago.TabIndex = 8;
            btn_MetPago.Text = "Metodo de Pago";
            btn_MetPago.UseVisualStyleBackColor = true;
            btn_MetPago.Click += btn_MetPago_Click;
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
            panelmenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelCont;
        private Button btn_Proveedor;
        private Button btn_Cliente;
        private Button btn_Empleado;
        private Button btn_Venta;
        private Button btn_Producto;
        private Label label1;
        private Button btn_Inventario;
        private Panel panelmenu;
        private Button btn_MetPago;
        private Label label2;
    }
}