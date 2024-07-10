namespace SistemaBotica
{
    partial class CONSULTA_DisponibilidadMedicamentos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_dispMed = new DataGridView();
            btn_buscar = new Button();
            label2 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            comboBoxNombreProd = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_dispMed).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_dispMed
            // 
            dgv_dispMed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_dispMed.Location = new Point(375, 69);
            dgv_dispMed.Name = "dgv_dispMed";
            dgv_dispMed.Size = new Size(355, 328);
            dgv_dispMed.TabIndex = 1;
            // 
            // btn_buscar
            // 
            btn_buscar.Font = new Font("Segoe UI", 11.25F);
            btn_buscar.Location = new Point(138, 112);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(100, 33);
            btn_buscar.TabIndex = 2;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(13, 72);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Producto :";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-297, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1617, 55);
            panel1.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(297, 6);
            label7.Name = "label7";
            label7.Size = new Size(595, 45);
            label7.TabIndex = 1;
            label7.Text = "DISPONIBILIDAD DE MEDICAMENTOS";
            // 
            // comboBoxNombreProd
            // 
            comboBoxNombreProd.FormattingEnabled = true;
            comboBoxNombreProd.Location = new Point(95, 73);
            comboBoxNombreProd.Name = "comboBoxNombreProd";
            comboBoxNombreProd.Size = new Size(246, 23);
            comboBoxNombreProd.TabIndex = 23;
            // 
            // CONSULTA_DisponibilidadMedicamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(742, 418);
            Controls.Add(comboBoxNombreProd);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btn_buscar);
            Controls.Add(dgv_dispMed);
            Name = "CONSULTA_DisponibilidadMedicamentos";
            Text = "CONSULTA_DisponibilidadMedicamentos";
            Load += CONSULTA_DisponibilidadMedicamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_dispMed).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_dispMed;
        private Button btn_buscar;
        private Label label2;
        private Panel panel1;
        private Label label7;
        private ComboBox comboBoxNombreProd;
    }
}
