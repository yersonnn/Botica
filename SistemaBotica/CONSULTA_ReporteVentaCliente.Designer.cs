﻿namespace CapaPresentacion
{
    partial class CONSULTA_ReporteVentaCliente
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(574, 250);
            dataGridView1.TabIndex = 22;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F);
            button2.Location = new Point(12, 391);
            button2.Name = "button2";
            button2.Size = new Size(85, 35);
            button2.TabIndex = 21;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 76);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 20;
            label2.Text = "Dni:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.Location = new Point(305, 69);
            button1.Name = "button1";
            button1.Size = new Size(77, 36);
            button1.TabIndex = 18;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-266, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 47);
            panel1.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(263, 2);
            label7.Name = "label7";
            label7.Size = new Size(545, 45);
            label7.TabIndex = 1;
            label7.Text = "REPORTE DE VENTAS POR CLIENTE";
            // 
            // CONSULTA_ReporteVentaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(706, 440);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "CONSULTA_ReporteVentaCliente";
            Text = "CONSULTA_ReporteVentaCliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label2;
        private Button button1;
        private Panel panel1;
        private Label label7;
    }
}