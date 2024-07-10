namespace CapaPresentacion
{
    partial class CORE_VentaDirecta
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
            label1 = new Label();
            dgvVentaRealizada = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            btn_buscarCliente = new Button();
            labelNombreCliente = new Label();
            textBoxDNI_Cliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            labelStock = new Label();
            label11 = new Label();
            textBoxIDPROD = new TextBox();
            label10 = new Label();
            comboBoxNombreProd = new ComboBox();
            label8 = new Label();
            textBoxCantidad = new TextBox();
            labelPrecio = new Label();
            label6 = new Label();
            label5 = new Label();
            btn_AgCarrito = new Button();
            btn_QuitarCarri = new Button();
            groupBox3 = new GroupBox();
            dateFecha = new DateTimePicker();
            groupBox4 = new GroupBox();
            comboBoxMetodoPago = new ComboBox();
            label9 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label4 = new Label();
            textBox_MontoTotal = new TextBox();
            dgvDetVent = new DataGridView();
            PRODUCTO = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioUnit = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVentaRealizada).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetVent).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 490);
            label1.Name = "label1";
            label1.Size = new Size(227, 30);
            label1.TabIndex = 0;
            label1.Text = "VENTAS REALIZADAS";
            // 
            // dgvVentaRealizada
            // 
            dgvVentaRealizada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentaRealizada.Location = new Point(12, 527);
            dgvVentaRealizada.Name = "dgvVentaRealizada";
            dgvVentaRealizada.Size = new Size(854, 181);
            dgvVentaRealizada.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(921, 548);
            button1.Name = "button1";
            button1.Size = new Size(170, 38);
            button1.TabIndex = 2;
            button1.Text = "REGISTRAR VENTA";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(921, 602);
            button2.Name = "button2";
            button2.Size = new Size(170, 38);
            button2.TabIndex = 3;
            button2.Text = "ANULAR VENTA";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_buscarCliente);
            groupBox1.Controls.Add(labelNombreCliente);
            groupBox1.Controls.Add(textBoxDNI_Cliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 338);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 133);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente:";
            // 
            // btn_buscarCliente
            // 
            btn_buscarCliente.Font = new Font("Segoe UI", 9.75F);
            btn_buscarCliente.Location = new Point(297, 39);
            btn_buscarCliente.Name = "btn_buscarCliente";
            btn_buscarCliente.Size = new Size(92, 25);
            btn_buscarCliente.TabIndex = 14;
            btn_buscarCliente.Text = "BUSCAR";
            btn_buscarCliente.UseVisualStyleBackColor = true;
            btn_buscarCliente.Click += btn_buscarCliente_Click;
            // 
            // labelNombreCliente
            // 
            labelNombreCliente.AutoSize = true;
            labelNombreCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreCliente.Location = new Point(155, 91);
            labelNombreCliente.Name = "labelNombreCliente";
            labelNombreCliente.Size = new Size(21, 20);
            labelNombreCliente.TabIndex = 13;
            labelNombreCliente.Text = "--";
            // 
            // textBoxDNI_Cliente
            // 
            textBoxDNI_Cliente.Font = new Font("Segoe UI", 9.75F);
            textBoxDNI_Cliente.Location = new Point(155, 39);
            textBoxDNI_Cliente.Name = "textBoxDNI_Cliente";
            textBoxDNI_Cliente.Size = new Size(136, 25);
            textBoxDNI_Cliente.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(111, 42);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 1;
            label3.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre Completo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelStock);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBoxIDPROD);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(comboBoxNombreProd);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBoxCantidad);
            groupBox2.Controls.Add(labelPrecio);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(575, 67);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(429, 174);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "PRODUCTOS FARMACEUTICOS";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStock.Location = new Point(223, 107);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(21, 20);
            labelStock.TabIndex = 16;
            labelStock.Text = "--";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(169, 106);
            label11.Name = "label11";
            label11.Size = new Size(48, 20);
            label11.TabIndex = 15;
            label11.Text = "Stock:";
            // 
            // textBoxIDPROD
            // 
            textBoxIDPROD.Font = new Font("Segoe UI", 9.75F);
            textBoxIDPROD.Location = new Point(92, 70);
            textBoxIDPROD.Name = "textBoxIDPROD";
            textBoxIDPROD.Size = new Size(71, 25);
            textBoxIDPROD.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(28, 73);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 13;
            label10.Text = "ProdID:";
            // 
            // comboBoxNombreProd
            // 
            comboBoxNombreProd.FormattingEnabled = true;
            comboBoxNombreProd.Location = new Point(92, 28);
            comboBoxNombreProd.Name = "comboBoxNombreProd";
            comboBoxNombreProd.Size = new Size(295, 29);
            comboBoxNombreProd.TabIndex = 12;
            comboBoxNombreProd.SelectedIndexChanged += comboBoxNombreCliente_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 32);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 11;
            label8.Text = "Nombre:";
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Font = new Font("Segoe UI", 9.75F);
            textBoxCantidad.Location = new Point(92, 106);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(71, 25);
            textBoxCantidad.TabIndex = 10;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrecio.Location = new Point(105, 137);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(21, 20);
            labelPrecio.TabIndex = 9;
            labelPrecio.Text = "--";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 137);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 8;
            label6.Text = "Precio(S/.):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 107);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Cantidad:";
            // 
            // btn_AgCarrito
            // 
            btn_AgCarrito.Location = new Point(1023, 81);
            btn_AgCarrito.Name = "btn_AgCarrito";
            btn_AgCarrito.Size = new Size(135, 51);
            btn_AgCarrito.TabIndex = 6;
            btn_AgCarrito.Text = "AGREGAR AL CARRITO";
            btn_AgCarrito.UseVisualStyleBackColor = true;
            btn_AgCarrito.Click += btn_AgCarrito_Click;
            // 
            // btn_QuitarCarri
            // 
            btn_QuitarCarri.Location = new Point(1023, 143);
            btn_QuitarCarri.Name = "btn_QuitarCarri";
            btn_QuitarCarri.Size = new Size(135, 51);
            btn_QuitarCarri.TabIndex = 7;
            btn_QuitarCarri.Text = "QUITAR DEL CARRITO";
            btn_QuitarCarri.UseVisualStyleBackColor = true;
            btn_QuitarCarri.Click += btn_QuitarCarri_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateFecha);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(861, 400);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(320, 71);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fecha:";
            // 
            // dateFecha
            // 
            dateFecha.Location = new Point(6, 30);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(302, 29);
            dateFecha.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBoxMetodoPago);
            groupBox4.Controls.Add(label9);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(480, 404);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(375, 67);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pago:";
            // 
            // comboBoxMetodoPago
            // 
            comboBoxMetodoPago.FormattingEnabled = true;
            comboBoxMetodoPago.Location = new Point(143, 28);
            comboBoxMetodoPago.Name = "comboBoxMetodoPago";
            comboBoxMetodoPago.Size = new Size(198, 29);
            comboBoxMetodoPago.TabIndex = 1;
            comboBoxMetodoPago.SelectedIndexChanged += comboBoxMetodoPago_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 33);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 0;
            label9.Text = "Metodo de Pago:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1320, 59);
            panel1.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(5, 7);
            label7.Name = "label7";
            label7.Size = new Size(446, 45);
            label7.TabIndex = 0;
            label7.Text = "VENTA DE FARMACEUTICOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(272, 297);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 12;
            label4.Text = "MONTO TOTAL:";
            // 
            // textBox_MontoTotal
            // 
            textBox_MontoTotal.Font = new Font("Segoe UI", 9.75F);
            textBox_MontoTotal.Location = new Point(402, 296);
            textBox_MontoTotal.Name = "textBox_MontoTotal";
            textBox_MontoTotal.Size = new Size(142, 25);
            textBox_MontoTotal.TabIndex = 14;
            // 
            // dgvDetVent
            // 
            dgvDetVent.AllowUserToAddRows = false;
            dgvDetVent.AllowUserToDeleteRows = false;
            dgvDetVent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetVent.Columns.AddRange(new DataGridViewColumn[] { PRODUCTO, Cantidad, PrecioUnit, SubTotal });
            dgvDetVent.Location = new Point(27, 81);
            dgvDetVent.Name = "dgvDetVent";
            dgvDetVent.ReadOnly = true;
            dgvDetVent.Size = new Size(435, 201);
            dgvDetVent.TabIndex = 15;
            // 
            // PRODUCTO
            // 
            PRODUCTO.HeaderText = "Producto";
            PRODUCTO.Name = "PRODUCTO";
            PRODUCTO.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // PrecioUnit
            // 
            PrecioUnit.HeaderText = "PrecioUnit";
            PrecioUnit.Name = "PrecioUnit";
            PrecioUnit.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // CORE_VentaDirecta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1190, 698);
            Controls.Add(dgvDetVent);
            Controls.Add(textBox_MontoTotal);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btn_QuitarCarri);
            Controls.Add(btn_AgCarrito);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvVentaRealizada);
            Controls.Add(label1);
            Name = "CORE_VentaDirecta";
            Text = "CORE_VentaDirecta";
            Load += CORE_VentaDirecta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentaRealizada).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetVent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvVentaRealizada;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox textBoxDNI_Cliente;
        private GroupBox groupBox2;
        private Button btn_AgCarrito;
        private Button btn_QuitarCarri;
        private TextBox textBoxCantidad;
        private Label labelPrecio;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private DateTimePicker dateFecha;
        private Label label8;
        private Label labelNombreCliente;
        private GroupBox groupBox4;
        private ComboBox comboBoxMetodoPago;
        private Label label9;
        private Panel panel1;
        private Label label7;
        private ComboBox comboBoxNombreProd;
        private Label label4;
        private TextBox textBox_MontoTotal;
        private TextBox textBoxIDPROD;
        private Label label10;
        private Label labelStock;
        private Label label11;
        private Button btn_buscarCliente;
        private DataGridView dgvDetVent;
        private DataGridViewTextBoxColumn PRODUCTO;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioUnit;
        private DataGridViewTextBoxColumn SubTotal;
    }
}