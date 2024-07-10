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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F);
            textBox1.Location = new Point(179, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(368, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(355, 328);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.Location = new Point(115, 115);
            button1.Name = "button1";
            button1.Size = new Size(107, 39);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre del Producto :";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-297, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 55);
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
            // CONSULTA_DisponibilidadMedicamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(735, 418);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "CONSULTA_DisponibilidadMedicamentos";
            Text = "CONSULTA_DisponibilidadMedicamentos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label2;
        private Panel panel1;
        private Label label7;
    }
}
