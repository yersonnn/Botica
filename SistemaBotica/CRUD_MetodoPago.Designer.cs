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
            txt_TipoMetodo = new TextBox();
            label4 = new Label();
            txt_NombMetodo = new TextBox();
            txt_CodMetodo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgv_MetPago = new DataGridView();
            label1 = new Label();
            btn_Nuevo = new Button();
            btn_Editar = new Button();
            checkBox_MetPag = new CheckBox();
            groupBoxMetPag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_MetPago).BeginInit();
            SuspendLayout();
            // 
            // btn_InMetodo
            // 
            btn_InMetodo.Location = new Point(645, 170);
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
            groupBoxMetPag.Controls.Add(checkBox_MetPag);
            groupBoxMetPag.Controls.Add(txt_TipoMetodo);
            groupBoxMetPag.Controls.Add(label4);
            groupBoxMetPag.Controls.Add(txt_NombMetodo);
            groupBoxMetPag.Controls.Add(btn_ModMetodo);
            groupBoxMetPag.Controls.Add(btn_AgrMetodo);
            groupBoxMetPag.Controls.Add(txt_CodMetodo);
            groupBoxMetPag.Controls.Add(label3);
            groupBoxMetPag.Controls.Add(label2);
            groupBoxMetPag.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxMetPag.Location = new Point(12, 250);
            groupBoxMetPag.Name = "groupBoxMetPag";
            groupBoxMetPag.Size = new Size(732, 138);
            groupBoxMetPag.TabIndex = 16;
            groupBoxMetPag.TabStop = false;
            groupBoxMetPag.Text = "DETALLES";
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
            // dgv_MetPago
            // 
            dgv_MetPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_MetPago.Location = new Point(12, 47);
            dgv_MetPago.Name = "dgv_MetPago";
            dgv_MetPago.Size = new Size(607, 181);
            dgv_MetPago.TabIndex = 15;
            dgv_MetPago.CellDoubleClick += dgv_MetPago_CellDoubleClick;
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
            // btn_Nuevo
            // 
            btn_Nuevo.Location = new Point(645, 64);
            btn_Nuevo.Name = "btn_Nuevo";
            btn_Nuevo.Size = new Size(170, 38);
            btn_Nuevo.TabIndex = 20;
            btn_Nuevo.Text = "NUEVO";
            btn_Nuevo.UseVisualStyleBackColor = true;
            btn_Nuevo.Click += btn_Nuevo_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(645, 117);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(170, 38);
            btn_Editar.TabIndex = 21;
            btn_Editar.Text = "EDITAR";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
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
            // CRUD_MetodoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 432);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Nuevo);
            Controls.Add(btn_InMetodo);
            Controls.Add(groupBoxMetPag);
            Controls.Add(dgv_MetPago);
            Controls.Add(label1);
            Name = "CRUD_MetodoPago";
            Text = "CRUD_MetodoPago";
            groupBoxMetPag.ResumeLayout(false);
            groupBoxMetPag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_MetPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private TextBox txt_TipoMetodo;
        private Label label4;
        private Button btn_Nuevo;
        private Button btn_Editar;
        private CheckBox checkBox_MetPag;
    }
}