namespace CapaPresentacion
{
    partial class CRUD_MetodoPago
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
            btn_InMetodo = new Button();
            btn_ModMetodo = new Button();
            btn_AgrMetodo = new Button();
            groupBox1 = new GroupBox();
            txt_TipoMetodo = new TextBox();
            label4 = new Label();
            txt_NombMetodo = new TextBox();
            txt_CodMetodo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_InMetodo
            // 
            btn_InMetodo.Location = new Point(436, 372);
            btn_InMetodo.Name = "btn_InMetodo";
            btn_InMetodo.Size = new Size(170, 38);
            btn_InMetodo.TabIndex = 19;
            btn_InMetodo.Text = "INHABILITAR ";
            btn_InMetodo.UseVisualStyleBackColor = true;
            // 
            // btn_ModMetodo
            // 
            btn_ModMetodo.Location = new Point(436, 317);
            btn_ModMetodo.Name = "btn_ModMetodo";
            btn_ModMetodo.Size = new Size(170, 38);
            btn_ModMetodo.TabIndex = 18;
            btn_ModMetodo.Text = "MODIFICAR DATOS";
            btn_ModMetodo.UseVisualStyleBackColor = true;
            // 
            // btn_AgrMetodo
            // 
            btn_AgrMetodo.Location = new Point(436, 262);
            btn_AgrMetodo.Name = "btn_AgrMetodo";
            btn_AgrMetodo.Size = new Size(170, 38);
            btn_AgrMetodo.TabIndex = 17;
            btn_AgrMetodo.Text = "AGREGAR";
            btn_AgrMetodo.UseVisualStyleBackColor = true;
            btn_AgrMetodo.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_TipoMetodo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_NombMetodo);
            groupBox1.Controls.Add(txt_CodMetodo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 138);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLES";
            // 
            // txt_TipoMetodo
            // 
            txt_TipoMetodo.Font = new Font("Segoe UI", 9.75F);
            txt_TipoMetodo.Location = new Point(154, 100);
            txt_TipoMetodo.Name = "txt_TipoMetodo";
            txt_TipoMetodo.Size = new Size(193, 25);
            txt_TipoMetodo.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 100);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 10;
            label4.Text = "Tipo:";
            // 
            // txt_NombMetodo
            // 
            txt_NombMetodo.Font = new Font("Segoe UI", 9.75F);
            txt_NombMetodo.Location = new Point(154, 67);
            txt_NombMetodo.Name = "txt_NombMetodo";
            txt_NombMetodo.Size = new Size(193, 25);
            txt_NombMetodo.TabIndex = 9;
            // 
            // txt_CodMetodo
            // 
            txt_CodMetodo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_CodMetodo.Location = new Point(154, 36);
            txt_CodMetodo.Name = "txt_CodMetodo";
            txt_CodMetodo.Size = new Size(193, 25);
            txt_CodMetodo.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 67);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 7;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 36);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 6;
            label2.Text = "Codigo:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(607, 181);
            dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 30);
            label1.TabIndex = 14;
            label1.Text = "METODOS DE PAGO";
            // 
            // CRUD_MetodoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 432);
            Controls.Add(btn_InMetodo);
            Controls.Add(btn_ModMetodo);
            Controls.Add(btn_AgrMetodo);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CRUD_MetodoPago";
            Text = "CRUD_MetodoPago";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_InMetodo;
        private Button btn_ModMetodo;
        private Button btn_AgrMetodo;
        private GroupBox groupBox1;
        private TextBox txt_NombMetodo;
        private TextBox txt_CodMetodo;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txt_TipoMetodo;
        private Label label4;
    }
}