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
            btn_ModEmpleado = new Button();
            btn_AgrEmpleado = new Button();
            groupBox1 = new GroupBox();
            txt_CargoEmpleado = new TextBox();
            label5 = new Label();
            txt_TelfEmpleado = new TextBox();
            label4 = new Label();
            txt_NombEmpleado = new TextBox();
            txt_DniEmpleado = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_InEmpleado
            // 
            btn_InEmpleado.Location = new Point(448, 372);
            btn_InEmpleado.Name = "btn_InEmpleado";
            btn_InEmpleado.Size = new Size(170, 38);
            btn_InEmpleado.TabIndex = 13;
            btn_InEmpleado.Text = "INHABILITAR EMPLEADO";
            btn_InEmpleado.UseVisualStyleBackColor = true;
            // 
            // btn_ModEmpleado
            // 
            btn_ModEmpleado.Location = new Point(448, 317);
            btn_ModEmpleado.Name = "btn_ModEmpleado";
            btn_ModEmpleado.Size = new Size(170, 38);
            btn_ModEmpleado.TabIndex = 12;
            btn_ModEmpleado.Text = "MODIFICAR DATOS";
            btn_ModEmpleado.UseVisualStyleBackColor = true;
            // 
            // btn_AgrEmpleado
            // 
            btn_AgrEmpleado.Location = new Point(448, 262);
            btn_AgrEmpleado.Name = "btn_AgrEmpleado";
            btn_AgrEmpleado.Size = new Size(170, 38);
            btn_AgrEmpleado.TabIndex = 11;
            btn_AgrEmpleado.Text = "AGREGAR EMPLEADO";
            btn_AgrEmpleado.UseVisualStyleBackColor = true;
            btn_AgrEmpleado.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_CargoEmpleado);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_TelfEmpleado);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_NombEmpleado);
            groupBox1.Controls.Add(txt_DniEmpleado);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(24, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 179);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLES";
            // 
            // txt_CargoEmpleado
            // 
            txt_CargoEmpleado.Font = new Font("Segoe UI", 9.75F);
            txt_CargoEmpleado.Location = new Point(161, 136);
            txt_CargoEmpleado.Name = "txt_CargoEmpleado";
            txt_CargoEmpleado.Size = new Size(193, 25);
            txt_CargoEmpleado.TabIndex = 13;
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
            // txt_TelfEmpleado
            // 
            txt_TelfEmpleado.Font = new Font("Segoe UI", 9.75F);
            txt_TelfEmpleado.Location = new Point(161, 99);
            txt_TelfEmpleado.Name = "txt_TelfEmpleado";
            txt_TelfEmpleado.Size = new Size(193, 25);
            txt_TelfEmpleado.TabIndex = 11;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(607, 181);
            dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 30);
            label1.TabIndex = 8;
            label1.Text = "EMPLEADOS";
            // 
            // CRUD_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 454);
            Controls.Add(btn_InEmpleado);
            Controls.Add(btn_ModEmpleado);
            Controls.Add(btn_AgrEmpleado);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CRUD_Empleado";
            Text = "CRUD_Empleado";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_InEmpleado;
        private Button btn_ModEmpleado;
        private Button btn_AgrEmpleado;
        private GroupBox groupBox1;
        private TextBox txt_CargoEmpleado;
        private Label label5;
        private TextBox txt_TelfEmpleado;
        private Label label4;
        private TextBox txt_NombEmpleado;
        private TextBox txt_DniEmpleado;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}