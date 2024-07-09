namespace CapaPresentacion
{
    partial class CRUD_Empleado
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
            btn_InEmpleado = new Button();
            groupBox1 = new GroupBox();
            comboBoxCargo = new ComboBox();
            label5 = new Label();
            checkBox_Emple = new CheckBox();
            txt_TelfEmpleado = new TextBox();
            btn_ModEmple = new Button();
            btn_AgEmpl = new Button();
            label4 = new Label();
            txt_NombEmpleado = new TextBox();
            txt_DniEmpleado = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgv_Empleados = new DataGridView();
            btn_EditEmplead = new Button();
            btn_NuevEmplead = new Button();
            label7 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Empleados).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_InEmpleado
            // 
            btn_InEmpleado.Location = new Point(644, 206);
            btn_InEmpleado.Name = "btn_InEmpleado";
            btn_InEmpleado.Size = new Size(170, 38);
            btn_InEmpleado.TabIndex = 13;
            btn_InEmpleado.Text = "INHABILITAR EMPLEADO";
            btn_InEmpleado.UseVisualStyleBackColor = true;
            btn_InEmpleado.Click += btn_InEmpleado_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxCargo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(checkBox_Emple);
            groupBox1.Controls.Add(txt_TelfEmpleado);
            groupBox1.Controls.Add(btn_ModEmple);
            groupBox1.Controls.Add(btn_AgEmpl);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_NombEmpleado);
            groupBox1.Controls.Add(txt_DniEmpleado);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(684, 179);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLES";
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Items.AddRange(new object[] { "Farmaceutico", "Asistente de Almacen", "Tecnico de Farmacia" });
            comboBoxCargo.Location = new Point(161, 137);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(193, 29);
            comboBoxCargo.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(7, 141);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 12;
            label5.Text = "Cargo/Ocupacion:";
            // 
            // checkBox_Emple
            // 
            checkBox_Emple.AutoSize = true;
            checkBox_Emple.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_Emple.Location = new Point(384, 112);
            checkBox_Emple.Name = "checkBox_Emple";
            checkBox_Emple.Size = new Size(79, 25);
            checkBox_Emple.TabIndex = 32;
            checkBox_Emple.Text = "Estado ";
            checkBox_Emple.UseVisualStyleBackColor = true;
            // 
            // txt_TelfEmpleado
            // 
            txt_TelfEmpleado.Font = new Font("Segoe UI", 9.75F);
            txt_TelfEmpleado.Location = new Point(161, 99);
            txt_TelfEmpleado.Name = "txt_TelfEmpleado";
            txt_TelfEmpleado.Size = new Size(193, 25);
            txt_TelfEmpleado.TabIndex = 11;
            // 
            // btn_ModEmple
            // 
            btn_ModEmple.Location = new Point(488, 104);
            btn_ModEmple.Name = "btn_ModEmple";
            btn_ModEmple.Size = new Size(170, 38);
            btn_ModEmple.TabIndex = 31;
            btn_ModEmple.Text = "MODIFICAR";
            btn_ModEmple.UseVisualStyleBackColor = true;
            btn_ModEmple.Click += btn_ModEmple_Click;
            // 
            // btn_AgEmpl
            // 
            btn_AgEmpl.Location = new Point(488, 48);
            btn_AgEmpl.Name = "btn_AgEmpl";
            btn_AgEmpl.Size = new Size(170, 38);
            btn_AgEmpl.TabIndex = 30;
            btn_AgEmpl.Text = "AGREGAR";
            btn_AgEmpl.UseVisualStyleBackColor = true;
            btn_AgEmpl.Click += btn_AgEmpl_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 104);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 10;
            label4.Text = "Telf. Celular:";
            // 
            // txt_NombEmpleado
            // 
            txt_NombEmpleado.Font = new Font("Segoe UI", 9.75F);
            txt_NombEmpleado.Location = new Point(161, 61);
            txt_NombEmpleado.Name = "txt_NombEmpleado";
            txt_NombEmpleado.Size = new Size(193, 25);
            txt_NombEmpleado.TabIndex = 9;
            // 
            // txt_DniEmpleado
            // 
            txt_DniEmpleado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_DniEmpleado.Location = new Point(161, 30);
            txt_DniEmpleado.Name = "txt_DniEmpleado";
            txt_DniEmpleado.Size = new Size(193, 25);
            txt_DniEmpleado.TabIndex = 8;
            txt_DniEmpleado.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 67);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 7;
            label3.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 30);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 6;
            label2.Text = "DNI:";
            // 
            // dgv_Empleados
            // 
            dgv_Empleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Empleados.Location = new Point(12, 77);
            dgv_Empleados.Name = "dgv_Empleados";
            dgv_Empleados.Size = new Size(607, 181);
            dgv_Empleados.TabIndex = 9;
            dgv_Empleados.CellDoubleClick += dgv_Empleados_CellDoubleClick;
            // 
            // btn_EditEmplead
            // 
            btn_EditEmplead.Location = new Point(644, 150);
            btn_EditEmplead.Name = "btn_EditEmplead";
            btn_EditEmplead.Size = new Size(170, 38);
            btn_EditEmplead.TabIndex = 29;
            btn_EditEmplead.Text = "EDITAR DATOS";
            btn_EditEmplead.UseVisualStyleBackColor = true;
            btn_EditEmplead.Click += btn_EditEmplead_Click;
            // 
            // btn_NuevEmplead
            // 
            btn_NuevEmplead.Location = new Point(644, 96);
            btn_NuevEmplead.Name = "btn_NuevEmplead";
            btn_NuevEmplead.Size = new Size(170, 38);
            btn_NuevEmplead.TabIndex = 28;
            btn_NuevEmplead.Text = "NUEVO EMPLEADO";
            btn_NuevEmplead.UseVisualStyleBackColor = true;
            btn_NuevEmplead.Click += btn_NuevEmplead_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(359, 4);
            label7.Name = "label7";
            label7.Size = new Size(210, 45);
            label7.TabIndex = 0;
            label7.Text = "EMPLEADOS";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-347, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1541, 58);
            panel1.TabIndex = 30;
            // 
            // CRUD_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1024, 534);
            Controls.Add(panel1);
            Controls.Add(btn_EditEmplead);
            Controls.Add(btn_NuevEmplead);
            Controls.Add(btn_InEmpleado);
            Controls.Add(groupBox1);
            Controls.Add(dgv_Empleados);
            Name = "CRUD_Empleado";
            Text = "CRUD_Empleado";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Empleados).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_InEmpleado;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox txt_TelfEmpleado;
        private Label label4;
        private TextBox txt_NombEmpleado;
        private TextBox txt_DniEmpleado;
        private Label label3;
        private Label label2;
        private DataGridView dgv_Empleados;
        private Button btn_EditEmplead;
        private Button btn_NuevEmplead;
        private CheckBox checkBox_Emple;
        private Button btn_ModEmple;
        private Button btn_AgEmpl;
        private Label label7;
        private Panel panel1;
        private ComboBox comboBoxCargo;
    }
}