namespace CapaPresentacion
{
    partial class CRUD_Proveedor
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
            btn_InProveedor = new Button();
            btn_EditProveedor = new Button();
            btn_NuevProveedor = new Button();
            groupBox1 = new GroupBox();
            comboBoxCiudad = new ComboBox();
            checkBox_Prov = new CheckBox();
            btn_ModProv = new Button();
            txt_TelfProveedor = new TextBox();
            btn_AgProv = new Button();
            label5 = new Label();
            label4 = new Label();
            txt_NombProveedor = new TextBox();
            txt_CodProveedor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgv_Proveedores = new DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Proveedores).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_InProveedor
            // 
            btn_InProveedor.Location = new Point(721, 206);
            btn_InProveedor.Name = "btn_InProveedor";
            btn_InProveedor.Size = new Size(170, 38);
            btn_InProveedor.TabIndex = 19;
            btn_InProveedor.Text = "INHABILITAR PROVEEDOR";
            btn_InProveedor.UseVisualStyleBackColor = true;
            btn_InProveedor.Click += btn_InProveedor_Click;
            // 
            // btn_EditProveedor
            // 
            btn_EditProveedor.Location = new Point(721, 151);
            btn_EditProveedor.Name = "btn_EditProveedor";
            btn_EditProveedor.Size = new Size(170, 38);
            btn_EditProveedor.TabIndex = 18;
            btn_EditProveedor.Text = "EDITAR DATOS";
            btn_EditProveedor.UseVisualStyleBackColor = true;
            btn_EditProveedor.Click += btn_EditProveedor_Click;
            // 
            // btn_NuevProveedor
            // 
            btn_NuevProveedor.Location = new Point(721, 96);
            btn_NuevProveedor.Name = "btn_NuevProveedor";
            btn_NuevProveedor.Size = new Size(170, 38);
            btn_NuevProveedor.TabIndex = 17;
            btn_NuevProveedor.Text = "NUEVO PROVEEDOR";
            btn_NuevProveedor.UseVisualStyleBackColor = true;
            btn_NuevProveedor.Click += btn_NuevProveedor_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxCiudad);
            groupBox1.Controls.Add(checkBox_Prov);
            groupBox1.Controls.Add(btn_ModProv);
            groupBox1.Controls.Add(txt_TelfProveedor);
            groupBox1.Controls.Add(btn_AgProv);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_NombProveedor);
            groupBox1.Controls.Add(txt_CodProveedor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(22, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(869, 192);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLES";
            // 
            // comboBoxCiudad
            // 
            comboBoxCiudad.FormattingEnabled = true;
            comboBoxCiudad.Location = new Point(152, 102);
            comboBoxCiudad.Name = "comboBoxCiudad";
            comboBoxCiudad.Size = new Size(290, 29);
            comboBoxCiudad.TabIndex = 23;
            comboBoxCiudad.SelectedIndexChanged += comboBoxCiudad_SelectedIndexChanged;
            // 
            // checkBox_Prov
            // 
            checkBox_Prov.AutoSize = true;
            checkBox_Prov.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_Prov.Location = new Point(488, 134);
            checkBox_Prov.Name = "checkBox_Prov";
            checkBox_Prov.Size = new Size(79, 25);
            checkBox_Prov.TabIndex = 22;
            checkBox_Prov.Text = "Estado ";
            checkBox_Prov.UseVisualStyleBackColor = true;
            // 
            // btn_ModProv
            // 
            btn_ModProv.Location = new Point(659, 104);
            btn_ModProv.Name = "btn_ModProv";
            btn_ModProv.Size = new Size(170, 38);
            btn_ModProv.TabIndex = 21;
            btn_ModProv.Text = "MODIFICAR";
            btn_ModProv.UseVisualStyleBackColor = true;
            btn_ModProv.Click += btn_ModProv_Click;
            // 
            // txt_TelfProveedor
            // 
            txt_TelfProveedor.Font = new Font("Segoe UI", 9.75F);
            txt_TelfProveedor.Location = new Point(154, 140);
            txt_TelfProveedor.Name = "txt_TelfProveedor";
            txt_TelfProveedor.Size = new Size(193, 25);
            txt_TelfProveedor.TabIndex = 13;
            // 
            // btn_AgProv
            // 
            btn_AgProv.Location = new Point(659, 49);
            btn_AgProv.Name = "btn_AgProv";
            btn_AgProv.Size = new Size(170, 38);
            btn_AgProv.TabIndex = 20;
            btn_AgProv.Text = "AGREGAR";
            btn_AgProv.UseVisualStyleBackColor = true;
            btn_AgProv.Click += btn_AgProv_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 139);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 12;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 102);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 10;
            label4.Text = "Ciudad:";
            label4.Click += label4_Click;
            // 
            // txt_NombProveedor
            // 
            txt_NombProveedor.Font = new Font("Segoe UI", 9.75F);
            txt_NombProveedor.Location = new Point(154, 66);
            txt_NombProveedor.Name = "txt_NombProveedor";
            txt_NombProveedor.Size = new Size(288, 25);
            txt_NombProveedor.TabIndex = 9;
            // 
            // txt_CodProveedor
            // 
            txt_CodProveedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_CodProveedor.Location = new Point(154, 28);
            txt_CodProveedor.Name = "txt_CodProveedor";
            txt_CodProveedor.Size = new Size(144, 25);
            txt_CodProveedor.TabIndex = 8;
            txt_CodProveedor.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 67);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 7;
            label3.Text = "Empresa/Entidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 29);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 6;
            label2.Text = "Codigo (RUC):";
            // 
            // dgv_Proveedores
            // 
            dgv_Proveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Proveedores.Location = new Point(22, 78);
            dgv_Proveedores.Name = "dgv_Proveedores";
            dgv_Proveedores.Size = new Size(655, 181);
            dgv_Proveedores.TabIndex = 15;
            dgv_Proveedores.CellDoubleClick += dgv_Proveedores_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-72, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 51);
            panel1.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(73, 1);
            label7.Name = "label7";
            label7.Size = new Size(244, 45);
            label7.TabIndex = 1;
            label7.Text = "PROVEEDORES";
            // 
            // CRUD_Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1026, 559);
            Controls.Add(panel1);
            Controls.Add(btn_InProveedor);
            Controls.Add(btn_EditProveedor);
            Controls.Add(btn_NuevProveedor);
            Controls.Add(groupBox1);
            Controls.Add(dgv_Proveedores);
            Name = "CRUD_Proveedor";
            Text = "CRUD_Proveedor";
            Load += CRUD_Proveedor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Proveedores).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_InProveedor;
        private Button btn_EditProveedor;
        private Button btn_NuevProveedor;
        private GroupBox groupBox1;
        private TextBox txt_TelfProveedor;
        private Label label5;
        private Label label4;
        private TextBox txt_NombProveedor;
        private TextBox txt_CodProveedor;
        private Label label3;
        private Label label2;
        private DataGridView dgv_Proveedores;
        private Button btn_ModProv;
        private Button btn_AgProv;
        private CheckBox checkBox_Prov;
        private Panel panel1;
        private Label label7;
        private ComboBox comboBoxCiudad;
    }
}