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
            groupBoxMetPag = new GroupBox();
            comboBoxTipoMetPag = new ComboBox();
            checkBox_MetPag = new CheckBox();
            label4 = new Label();
            txt_NombMetodo = new TextBox();
            txt_CodMetodo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgv_MetPago = new DataGridView();
            btn_Nuevo = new Button();
            btn_Editar = new Button();
            panel1 = new Panel();
            label7 = new Label();
            groupBoxMetPag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_MetPago).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_InMetodo
            // 
            btn_InMetodo.Location = new Point(657, 178);
            btn_InMetodo.Name = "btn_InMetodo";
            btn_InMetodo.Size = new Size(170, 38);
            btn_InMetodo.TabIndex = 19;
            btn_InMetodo.Text = "INHABILITAR ";
            btn_InMetodo.UseVisualStyleBackColor = true;
            btn_InMetodo.Click += btn_InMetodo_Click;
            // 
            // btn_ModMetodo
            // 
            btn_ModMetodo.Location = new Point(508, 87);
            btn_ModMetodo.Name = "btn_ModMetodo";
            btn_ModMetodo.Size = new Size(170, 38);
            btn_ModMetodo.TabIndex = 18;
            btn_ModMetodo.Text = "MODIFICAR DATOS";
            btn_ModMetodo.UseVisualStyleBackColor = true;
            btn_ModMetodo.Click += btn_ModMetodo_Click;
            // 
            // btn_AgrMetodo
            // 
            btn_AgrMetodo.Location = new Point(508, 32);
            btn_AgrMetodo.Name = "btn_AgrMetodo";
            btn_AgrMetodo.Size = new Size(170, 38);
            btn_AgrMetodo.TabIndex = 17;
            btn_AgrMetodo.Text = "AGREGAR";
            btn_AgrMetodo.UseVisualStyleBackColor = true;
            btn_AgrMetodo.Click += button1_Click;
            // 
            // groupBoxMetPag
            // 
            groupBoxMetPag.Controls.Add(comboBoxTipoMetPag);
            groupBoxMetPag.Controls.Add(checkBox_MetPag);
            groupBoxMetPag.Controls.Add(label4);
            groupBoxMetPag.Controls.Add(txt_NombMetodo);
            groupBoxMetPag.Controls.Add(btn_ModMetodo);
            groupBoxMetPag.Controls.Add(btn_AgrMetodo);
            groupBoxMetPag.Controls.Add(txt_CodMetodo);
            groupBoxMetPag.Controls.Add(label3);
            groupBoxMetPag.Controls.Add(label2);
            groupBoxMetPag.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxMetPag.Location = new Point(12, 279);
            groupBoxMetPag.Name = "groupBoxMetPag";
            groupBoxMetPag.Size = new Size(732, 138);
            groupBoxMetPag.TabIndex = 16;
            groupBoxMetPag.TabStop = false;
            groupBoxMetPag.Text = "DETALLES";
            // 
            // comboBoxTipoMetPag
            // 
            comboBoxTipoMetPag.FormattingEnabled = true;
            comboBoxTipoMetPag.Items.AddRange(new object[] { "Tarjeta de Debito", "Billetera Electronica", "Efectivo" });
            comboBoxTipoMetPag.Location = new Point(154, 98);
            comboBoxTipoMetPag.Name = "comboBoxTipoMetPag";
            comboBoxTipoMetPag.Size = new Size(193, 29);
            comboBoxTipoMetPag.TabIndex = 20;
            // 
            // checkBox_MetPag
            // 
            checkBox_MetPag.AutoSize = true;
            checkBox_MetPag.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_MetPag.Location = new Point(370, 95);
            checkBox_MetPag.Name = "checkBox_MetPag";
            checkBox_MetPag.Size = new Size(79, 25);
            checkBox_MetPag.TabIndex = 19;
            checkBox_MetPag.Text = "Estado ";
            checkBox_MetPag.UseVisualStyleBackColor = true;
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
            txt_CodMetodo.TextChanged += txt_CodMetodo_TextChanged;
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
            // dgv_MetPago
            // 
            dgv_MetPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_MetPago.Location = new Point(12, 76);
            dgv_MetPago.Name = "dgv_MetPago";
            dgv_MetPago.Size = new Size(607, 181);
            dgv_MetPago.TabIndex = 15;
            dgv_MetPago.CellContentClick += dgv_MetPago_CellContentClick;
            dgv_MetPago.CellDoubleClick += dgv_MetPago_CellDoubleClick;
            // 
            // btn_Nuevo
            // 
            btn_Nuevo.Location = new Point(657, 70);
            btn_Nuevo.Name = "btn_Nuevo";
            btn_Nuevo.Size = new Size(170, 38);
            btn_Nuevo.TabIndex = 20;
            btn_Nuevo.Text = "NUEVO";
            btn_Nuevo.UseVisualStyleBackColor = true;
            btn_Nuevo.Click += btn_Nuevo_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(657, 125);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(170, 38);
            btn_Editar.TabIndex = 21;
            btn_Editar.Text = "EDITAR";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-95, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 51);
            panel1.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(96, 4);
            label7.Name = "label7";
            label7.Size = new Size(323, 45);
            label7.TabIndex = 1;
            label7.Text = "METODOS DE PAGO";
            // 
            // CRUD_MetodoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(980, 503);
            Controls.Add(panel1);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Nuevo);
            Controls.Add(btn_InMetodo);
            Controls.Add(groupBoxMetPag);
            Controls.Add(dgv_MetPago);
            Name = "CRUD_MetodoPago";
            Text = "CRUD_MetodoPago";
            groupBoxMetPag.ResumeLayout(false);
            groupBoxMetPag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_MetPago).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_InMetodo;
        private Button btn_ModMetodo;
        private Button btn_AgrMetodo;
        private GroupBox groupBoxMetPag;
        private TextBox txt_NombMetodo;
        private TextBox txt_CodMetodo;
        private Label label3;
        private Label label2;
        private DataGridView dgv_MetPago;
        private Label label4;
        private Button btn_Nuevo;
        private Button btn_Editar;
        private CheckBox checkBox_MetPag;
        private Panel panel1;
        private Label label7;
        private ComboBox comboBoxTipoMetPag;
    }
}