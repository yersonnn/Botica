namespace CapaPresentacion
{
    partial class CONSULTA_ProductosProvedor
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label7 = new Label();
            PRODUCTO = new DataGridViewTextBoxColumn();
            CODIGO = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            TOTAL = new DataGridViewTextBoxColumn();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(135, 21);
            label1.Name = "label1";
            label1.Size = new Size(414, 21);
            label1.TabIndex = 0;
            label1.Text = "CONSULTAR PRODUCTOS VENDIDOS POR PROVEDOR";
            // 
            // button1
            // 
            button1.Location = new Point(533, 55);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 1;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(533, 26);
            button2.Name = "button2";
            button2.Size = new Size(73, 23);
            button2.TabIndex = 2;
            button2.Text = "BUSCAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(29, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 81);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL PROVEDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(434, 101);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "FECHA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(29, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(626, 93);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATOS DE LA VENTA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 23);
            textBox1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 26);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 1;
            label4.Text = "NOMBRE";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 26);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 5;
            label5.Text = "PRODUCTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(248, 26);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 6;
            label6.Text = "CANTIDAD";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(248, 46);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(43, 23);
            textBox3.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(434, 119);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PRODUCTO, CODIGO, CANTIDAD, PRECIO, TOTAL });
            dataGridView1.Location = new Point(64, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(551, 145);
            dataGridView1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 26);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "CODIGO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(377, 49);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 9;
            label7.Text = "**********";
            // 
            // PRODUCTO
            // 
            PRODUCTO.HeaderText = "PRODUCTO";
            PRODUCTO.Name = "PRODUCTO";
            // 
            // CODIGO
            // 
            CODIGO.HeaderText = "CODIGO";
            CODIGO.Name = "CODIGO";
            // 
            // CANTIDAD
            // 
            CANTIDAD.HeaderText = "CANTIDAD";
            CANTIDAD.Name = "CANTIDAD";
            // 
            // PRECIO
            // 
            PRECIO.HeaderText = "PRECIO";
            PRECIO.Name = "PRECIO";
            // 
            // TOTAL
            // 
            TOTAL.HeaderText = "TOTAL";
            TOTAL.Name = "TOTAL";
            // 
            // button3
            // 
            button3.Location = new Point(600, 474);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "CERRAR";
            button3.UseVisualStyleBackColor = true;
            // 
            // CONSULTA_ProductosProvedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 509);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "CONSULTA_ProductosProvedor";
            Text = "CONSULTA";
            
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label3;
        private DataGridViewTextBoxColumn PRODUCTO;
        private DataGridViewTextBoxColumn CODIGO;
        private DataGridViewTextBoxColumn CANTIDAD;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn TOTAL;
        private Button button3;
    }
}