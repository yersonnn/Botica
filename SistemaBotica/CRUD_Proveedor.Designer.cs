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
            btn_ModProveedor = new Button();
            btn_AgrProveedor = new Button();
            groupBox1 = new GroupBox();
            txt_TelfProveedor = new TextBox();
            label5 = new Label();
            txt_CorreoProveedor = new TextBox();
            label4 = new Label();
            txt_NombProveedor = new TextBox();
            txt_CodProveedor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgv_Proveedores = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Proveedores).BeginInit();
            SuspendLayout();
            // 
            // btn_InProveedor
            // 
            btn_InProveedor.Location = new Point(507, 389);
            btn_InProveedor.Name = "btn_InProveedor";
            btn_InProveedor.Size = new Size(170, 38);
            btn_InProveedor.TabIndex = 19;
            btn_InProveedor.Text = "INHABILITAR PROVEEDOR";
            btn_InProveedor.UseVisualStyleBackColor = true;
            // 
            // btn_ModProveedor
            // 
            btn_ModProveedor.Location = new Point(507, 334);
            btn_ModProveedor.Name = "btn_ModProveedor";
            btn_ModProveedor.Size = new Size(170, 38);
            btn_ModProveedor.TabIndex = 18;
            btn_ModProveedor.Text = "MODIFICAR DATOS";
            btn_ModProveedor.UseVisualStyleBackColor = true;
            // 
            // btn_AgrProveedor
            // 
            btn_AgrProveedor.Location = new Point(507, 279);
            btn_AgrProveedor.Name = "btn_AgrProveedor";
            btn_AgrProveedor.Size = new Size(170, 38);
            btn_AgrProveedor.TabIndex = 17;
            btn_AgrProveedor.Text = "AGREGAR PROVEEDOR";
            btn_AgrProveedor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_TelfProveedor);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_CorreoProveedor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_NombProveedor);
            groupBox1.Controls.Add(txt_CodProveedor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(22, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 192);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLES";
            // 
            // txt_TelfProveedor
            // 
            txt_TelfProveedor.Font = new Font("Segoe UI", 9.75F);
            txt_TelfProveedor.Location = new Point(154, 140);
            txt_TelfProveedor.Name = "txt_TelfProveedor";
            txt_TelfProveedor.Size = new Size(193, 25);
            txt_TelfProveedor.TabIndex = 13;
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
            // txt_CorreoProveedor
            // 
            txt_CorreoProveedor.Font = new Font("Segoe UI", 9.75F);
            txt_CorreoProveedor.Location = new Point(154, 103);
            txt_CorreoProveedor.Name = "txt_CorreoProveedor";
            txt_CorreoProveedor.Size = new Size(288, 25);
            txt_CorreoProveedor.TabIndex = 11;
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
            dgv_Proveedores.Location = new Point(22, 48);
            dgv_Proveedores.Name = "dgv_Proveedores";
            dgv_Proveedores.Size = new Size(655, 181);
            dgv_Proveedores.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 14;
            label1.Text = "PROVEEDORES";
            // 
            // CRUD_Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 467);
            Controls.Add(btn_InProveedor);
            Controls.Add(btn_ModProveedor);
            Controls.Add(btn_AgrProveedor);
            Controls.Add(groupBox1);
            Controls.Add(dgv_Proveedores);
            Controls.Add(label1);
            Name = "CRUD_Proveedor";
            Text = "CRUD_Proveedor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Proveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_InProveedor;
        private Button btn_ModProveedor;
        private Button btn_AgrProveedor;
        private GroupBox groupBox1;
        private TextBox txt_TelfProveedor;
        private Label label5;
        private TextBox txt_CorreoProveedor;
        private Label label4;
        private TextBox txt_NombProveedor;
        private TextBox txt_CodProveedor;
        private Label label3;
        private Label label2;
        private DataGridView dgv_Proveedores;
        private Label label1;
    }
}