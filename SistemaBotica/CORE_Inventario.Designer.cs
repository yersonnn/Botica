namespace CapaPresentacion
{
    partial class CORE_Inventario
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
            groupBox3 = new GroupBox();
            dateFecha = new DateTimePicker();
            groupBox2 = new GroupBox();
            comboBoxNombProd = new ComboBox();
            label6 = new Label();
            textBoxCantProd = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            comboBoxNombProv = new ComboBox();
            label2 = new Label();
            btn_AnularInv = new Button();
            btn_RegInv = new Button();
            dgvInventario = new DataGridView();
            label1 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            lbIDinvent = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateFecha);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(448, 78);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(374, 72);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fecha:";
            // 
            // dateFecha
            // 
            dateFecha.Location = new Point(19, 33);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(340, 29);
            dateFecha.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxNombProd);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBoxCantProd);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(13, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(429, 112);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "PRODUCTO";
            // 
            // comboBoxNombProd
            // 
            comboBoxNombProd.Font = new Font("Segoe UI", 9.75F);
            comboBoxNombProd.FormattingEnabled = true;
            comboBoxNombProd.Location = new Point(98, 35);
            comboBoxNombProd.Name = "comboBoxNombProd";
            comboBoxNombProd.Size = new Size(256, 25);
            comboBoxNombProd.TabIndex = 12;
            comboBoxNombProd.SelectedIndexChanged += comboBoxNombProd_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 39);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 11;
            label6.Text = "Nombre:";
            // 
            // textBoxCantProd
            // 
            textBoxCantProd.Font = new Font("Segoe UI", 9.75F);
            textBoxCantProd.Location = new Point(98, 70);
            textBoxCantProd.Name = "textBoxCantProd";
            textBoxCantProd.Size = new Size(91, 25);
            textBoxCantProd.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 71);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Cantidad:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxNombProv);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(448, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 102);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "PROVEEDOR:";
            // 
            // comboBoxNombProv
            // 
            comboBoxNombProv.Font = new Font("Segoe UI", 9.75F);
            comboBoxNombProv.FormattingEnabled = true;
            comboBoxNombProv.Location = new Point(151, 40);
            comboBoxNombProv.Name = "comboBoxNombProv";
            comboBoxNombProv.Size = new Size(261, 25);
            comboBoxNombProv.TabIndex = 1;
            comboBoxNombProv.SelectedIndexChanged += comboBoxNombProv_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 40);
            label2.Name = "label2";
            label2.Size = new Size(128, 22);
            label2.TabIndex = 0;
            label2.Text = "Empresa/Entidad:";
            // 
            // btn_AnularInv
            // 
            btn_AnularInv.Location = new Point(718, 368);
            btn_AnularInv.Name = "btn_AnularInv";
            btn_AnularInv.Size = new Size(170, 38);
            btn_AnularInv.TabIndex = 13;
            btn_AnularInv.Text = "ANULAR INVENTARIO";
            btn_AnularInv.UseVisualStyleBackColor = true;
            btn_AnularInv.Click += btn_AnularInv_Click;
            // 
            // btn_RegInv
            // 
            btn_RegInv.Location = new Point(718, 315);
            btn_RegInv.Name = "btn_RegInv";
            btn_RegInv.Size = new Size(170, 38);
            btn_RegInv.TabIndex = 12;
            btn_RegInv.Text = "REGISTRAR EN INVENTARIO";
            btn_RegInv.UseVisualStyleBackColor = true;
            btn_RegInv.Click += btn_RegInv_Click;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(17, 315);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(576, 181);
            dgvInventario.TabIndex = 11;
            dgvInventario.CellDoubleClick += dgvInventario_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 278);
            label1.Name = "label1";
            label1.Size = new Size(142, 30);
            label1.TabIndex = 10;
            label1.Text = "INVENTARIO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(46, 11);
            label7.Name = "label7";
            label7.Size = new Size(213, 45);
            label7.TabIndex = 0;
            label7.Text = "INVENTARIO";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-34, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1335, 66);
            panel1.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(13, 98);
            label3.Name = "label3";
            label3.Size = new Size(31, 21);
            label3.TabIndex = 22;
            label3.Text = "ID:";
            // 
            // lbIDinvent
            // 
            lbIDinvent.AutoSize = true;
            lbIDinvent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbIDinvent.Location = new Point(50, 98);
            lbIDinvent.Name = "lbIDinvent";
            lbIDinvent.Size = new Size(22, 21);
            lbIDinvent.TabIndex = 24;
            lbIDinvent.Text = "--";
            // 
            // CORE_Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(976, 526);
            Controls.Add(lbIDinvent);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_AnularInv);
            Controls.Add(btn_RegInv);
            Controls.Add(dgvInventario);
            Controls.Add(label1);
            Name = "CORE_Inventario";
            Text = "CORE_Inventario";
            Load += CORE_Inventario_Load;
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private DateTimePicker dateFecha;
        private GroupBox groupBox2;
        private TextBox textBoxCantProd;
        private Label label5;
        private GroupBox groupBox1;
        private Label label2;
        private Button btn_AnularInv;
        private Button btn_RegInv;
        private DataGridView dgvInventario;
        private Label label1;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private ComboBox comboBoxNombProd;
        private ComboBox comboBoxNombProv;
        private Label label3;
        private Label lbIDinvent;
    }
}