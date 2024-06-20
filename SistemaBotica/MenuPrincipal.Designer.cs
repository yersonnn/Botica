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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelCont
            // 
            PanelCont.Location = new Point(263, 1);
            PanelCont.Name = "PanelCont";
            PanelCont.Size = new Size(899, 605);
            PanelCont.TabIndex = 0;
            // 
            // btn_Proveedor
            // 
            btn_Proveedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Proveedor.Location = new Point(8, 487);
            btn_Proveedor.Name = "btn_Proveedor";
            btn_Proveedor.Size = new Size(248, 60);
            btn_Proveedor.TabIndex = 5;
            btn_Proveedor.Text = "Proveedor";
            btn_Proveedor.UseVisualStyleBackColor = true;
            // 
            // btn_Cliente
            // 
            btn_Cliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cliente.Location = new Point(8, 287);
            btn_Cliente.Name = "btn_Cliente";
            btn_Cliente.Size = new Size(248, 60);
            btn_Cliente.TabIndex = 1;
            btn_Cliente.Text = "Cliente";
            btn_Cliente.UseVisualStyleBackColor = true;
            // 
            // btn_Empleado
            // 
            btn_Empleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Empleado.Location = new Point(8, 353);
            btn_Empleado.Name = "btn_Empleado";
            btn_Empleado.Size = new Size(248, 60);
            btn_Empleado.TabIndex = 3;
            btn_Empleado.Text = "Empleado";
            btn_Empleado.UseVisualStyleBackColor = true;
            // 
            // btn_Venta
            // 
            btn_Venta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Venta.Location = new Point(8, 101);
            btn_Venta.Name = "btn_Venta";
            btn_Venta.Size = new Size(248, 60);
            btn_Venta.TabIndex = 6;
            btn_Venta.Text = "VENTA";
            btn_Venta.UseVisualStyleBackColor = true;
            btn_Venta.Click += btn_Venta_Click;
            // 
            // btn_Producto
            // 
            btn_Producto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Producto.Location = new Point(8, 419);
            btn_Producto.Name = "btn_Producto";
            btn_Producto.Size = new Size(248, 60);
            btn_Producto.TabIndex = 4;
            btn_Producto.Text = "Producto";
            btn_Producto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 38);
            label1.Name = "label1";
            label1.Size = new Size(181, 28);
            label1.TabIndex = 2;
            label1.Text = "MENU PRINCIPAL";
            // 
            // btn_Inventario
            // 
            btn_Inventario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Inventario.Location = new Point(8, 167);
            btn_Inventario.Name = "btn_Inventario";
            btn_Inventario.Size = new Size(248, 60);
            btn_Inventario.TabIndex = 7;
            btn_Inventario.Text = "INVENTARIO";
            btn_Inventario.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Inventario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Producto);
            panel1.Controls.Add(btn_Venta);
            panel1.Controls.Add(btn_Empleado);
            panel1.Controls.Add(btn_Cliente);
            panel1.Controls.Add(btn_Proveedor);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(263, 606);
            panel1.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 605);
            Controls.Add(panel1);
            Controls.Add(PanelCont);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
    }
}