﻿namespace CapaPresentacion
{
    partial class CONSULTA_ReporteVentaFecha
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
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(14, 74);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 25);
            dateTimePicker1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(537, 250);
            dataGridView1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F);
            button2.Location = new Point(12, 393);
            button2.Name = "button2";
            button2.Size = new Size(85, 35);
            button2.TabIndex = 9;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 8;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 30);
            label1.TabIndex = 7;
            label1.Text = "REPORTE DE VENTAS POR FECHA";
            label1.UseMnemonic = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F);
            button1.Location = new Point(282, 63);
            button1.Name = "button1";
            button1.Size = new Size(77, 36);
            button1.TabIndex = 6;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // CONSULTA_ReporteVentaFecha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "CONSULTA_ReporteVentaFecha";
            Text = "CONSULTA_ReporteVentaFecha";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}