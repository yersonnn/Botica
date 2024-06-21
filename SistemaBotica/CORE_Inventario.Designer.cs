namespace CapaPresentacion
{
    partial class CORE_Inventario
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
            groupBox3 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button5 = new Button();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(254, 85);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(25, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 29);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(429, 152);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "PRODUCTO";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9.75F);
            textBox5.Location = new Point(92, 68);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(272, 25);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 69);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 11;
            label6.Text = "Nombre:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9.75F);
            textBox4.Location = new Point(92, 100);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(71, 25);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 101);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 7;
            label5.Text = "Cantidad:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9.75F);
            textBox3.Location = new Point(92, 31);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(272, 25);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 36);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 1;
            label4.Text = "Codigo:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(464, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 146);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "PROVEEDOR:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.75F);
            textBox2.Location = new Point(150, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 25);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(150, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 25);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 50);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 1;
            label3.Text = "Codigo (RUC):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 84);
            label2.Name = "label2";
            label2.Size = new Size(128, 22);
            label2.TabIndex = 0;
            label2.Text = "Empresa/Entidad:";
            // 
            // button2
            // 
            button2.Location = new Point(904, 421);
            button2.Name = "button2";
            button2.Size = new Size(170, 38);
            button2.TabIndex = 13;
            button2.Text = "ANULAR INVENTARIO";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(904, 314);
            button1.Name = "button1";
            button1.Size = new Size(170, 38);
            button1.TabIndex = 12;
            button1.Text = "REGISTRAR EN INVENTARIO";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(854, 181);
            dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 268);
            label1.Name = "label1";
            label1.Size = new Size(142, 30);
            label1.TabIndex = 10;
            label1.Text = "INVENTARIO";
            // 
            // button5
            // 
            button5.Location = new Point(904, 368);
            button5.Name = "button5";
            button5.Size = new Size(170, 38);
            button5.TabIndex = 20;
            button5.Text = "MODIFICAR INVENTARIO";
            button5.UseVisualStyleBackColor = true;
            // 
            // CORE_Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 519);
            Controls.Add(button5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CORE_Inventario";
            Text = "CORE_Inventario";
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox5;
        private Label label6;
        private Button button5;
    }
}