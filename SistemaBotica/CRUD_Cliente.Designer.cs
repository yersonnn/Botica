namespace CapaPresentacion
{
    partial class CRUD_Cliente
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
            btn_InCliente = new Button();
            groupBox1 = new GroupBox();
            txt_TelfCliente = new TextBox();
            label5 = new Label();
            txt_CorreoCliente = new TextBox();
            label4 = new Label();
            txt_NombCliente = new TextBox();
            txt_DniCliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgv_Clientes = new DataGridView();
            label1 = new Label();
            btn_EditClient = new Button();
            btn_NuevClient = new Button();
            checkBox_Clie = new CheckBox();
            btn_ModClie = new Button();
            btn_AgClien = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Clientes).BeginInit();
            SuspendLayout();
            // 
            // btn_InCliente
            // 
            btn_InCliente.Location = new Point(699, 171);
            btn_InCliente.Name = "btn_InCliente";
            btn_InCliente.Size = new Size(170, 38);
            btn_InCliente.TabIndex = 13;
            btn_InCliente.Text = "INHABILITAR CLIENTE";
            btn_InCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_TelfCliente);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(checkBox_Clie);
            groupBox1.Controls.Add(txt_CorreoCliente);
            groupBox1.Controls.Add(btn_ModClie);
            groupBox1.Controls.Add(btn_AgClien);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_NombCliente);
            groupBox1.Controls.Add(txt_DniCliente);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(22, 255);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(825, 192);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLES";
            // 
            // txt_TelfCliente
            // 
            txt_TelfCliente.Font = new Font("Segoe UI", 9.75F);
            txt_TelfCliente.Location = new Point(154, 140);
            txt_TelfCliente.Name = "txt_TelfCliente";
            txt_TelfCliente.Size = new Size(193, 25);
            txt_TelfCliente.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(57, 143);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 12;
            label5.Text = "Telf. Celular:";
            // 
            // txt_CorreoCliente
            // 
            txt_CorreoCliente.Font = new Font("Segoe UI", 9.75F);
            txt_CorreoCliente.Location = new Point(154, 103);
            txt_CorreoCliente.Name = "txt_CorreoCliente";
            txt_CorreoCliente.Size = new Size(288, 25);
            txt_CorreoCliente.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 104);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 10;
            label4.Text = "Correo Electronico:";
            // 
            // txt_NombCliente
            // 
            txt_NombCliente.Font = new Font("Segoe UI", 9.75F);
            txt_NombCliente.Location = new Point(154, 66);
            txt_NombCliente.Name = "txt_NombCliente";
            txt_NombCliente.Size = new Size(288, 25);
            txt_NombCliente.TabIndex = 9;
            // 
            // txt_DniCliente
            // 
            txt_DniCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_DniCliente.Location = new Point(154, 28);
            txt_DniCliente.Name = "txt_DniCliente";
            txt_DniCliente.Size = new Size(144, 25);
            txt_DniCliente.TabIndex = 8;
            txt_DniCliente.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 67);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 7;
            label3.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(101, 29);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 6;
            label2.Text = "DNI:";
            // 
            // dgv_Clientes
            // 
            dgv_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Clientes.Location = new Point(22, 47);
            dgv_Clientes.Name = "dgv_Clientes";
            dgv_Clientes.Size = new Size(655, 181);
            dgv_Clientes.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 30);
            label1.TabIndex = 8;
            label1.Text = "CLIENTES";
            // 
            // btn_EditClient
            // 
            btn_EditClient.Location = new Point(699, 117);
            btn_EditClient.Name = "btn_EditClient";
            btn_EditClient.Size = new Size(170, 38);
            btn_EditClient.TabIndex = 34;
            btn_EditClient.Text = "EDITAR DATOS";
            btn_EditClient.UseVisualStyleBackColor = true;
            // 
            // btn_NuevClient
            // 
            btn_NuevClient.Location = new Point(699, 62);
            btn_NuevClient.Name = "btn_NuevClient";
            btn_NuevClient.Size = new Size(170, 38);
            btn_NuevClient.TabIndex = 33;
            btn_NuevClient.Text = "NUEVO EMPLEADO";
            btn_NuevClient.UseVisualStyleBackColor = true;
            // 
            // checkBox_Clie
            // 
            checkBox_Clie.AutoSize = true;
            checkBox_Clie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_Clie.Location = new Point(487, 141);
            checkBox_Clie.Name = "checkBox_Clie";
            checkBox_Clie.Size = new Size(79, 25);
            checkBox_Clie.TabIndex = 37;
            checkBox_Clie.Text = "Estado ";
            checkBox_Clie.UseVisualStyleBackColor = true;
            // 
            // btn_ModClie
            // 
            btn_ModClie.Location = new Point(628, 104);
            btn_ModClie.Name = "btn_ModClie";
            btn_ModClie.Size = new Size(170, 38);
            btn_ModClie.TabIndex = 36;
            btn_ModClie.Text = "MODIFICAR";
            btn_ModClie.UseVisualStyleBackColor = true;
            // 
            // btn_AgClien
            // 
            btn_AgClien.Location = new Point(628, 48);
            btn_AgClien.Name = "btn_AgClien";
            btn_AgClien.Size = new Size(170, 38);
            btn_AgClien.TabIndex = 35;
            btn_AgClien.Text = "AGREGAR";
            btn_AgClien.UseVisualStyleBackColor = true;
            // 
            // CRUD_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 459);
            Controls.Add(btn_EditClient);
            Controls.Add(btn_NuevClient);
            Controls.Add(btn_InCliente);
            Controls.Add(groupBox1);
            Controls.Add(dgv_Clientes);
            Controls.Add(label1);
            Name = "CRUD_Cliente";
            Text = "CRUD_Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_InCliente;
        private GroupBox groupBox1;
        private TextBox txt_TelfCliente;
        private Label label5;
        private TextBox txt_CorreoCliente;
        private Label label4;
        private TextBox txt_NombCliente;
        private TextBox txt_DniCliente;
        private Label label3;
        private Label label2;
        private DataGridView dgv_Clientes;
        private Label label1;
        private CheckBox checkBox_Clie;
        private Button btn_ModClie;
        private Button btn_AgClien;
        private Button btn_EditClient;
        private Button btn_NuevClient;
    }
}