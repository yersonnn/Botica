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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            PRODUCTO = new DataGridViewTextBoxColumn();
            CODIGO = new DataGridViewTextBoxColumn();
            CANTIDAD = new DataGridViewTextBoxColumn();
            PRECIO = new DataGridViewTextBoxColumn();
            TOTAL = new DataGridViewTextBoxColumn();
            FECHA = new DataGridViewTextBoxColumn();
            button3 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(505, 51);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 1;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(505, 22);
            button2.Name = "button2";
            button2.Size = new Size(73, 23);
            button2.TabIndex = 2;
            button2.Text = "BUSCAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(29, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 81);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL PROVEDOR";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 23);
            comboBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 26);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 1;
            label4.Text = "EMPRESA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 28);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "FECHA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(29, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(626, 93);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATOS DE LA VENTA";
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
            // textBox2
            // 
            textBox2.Location = new Point(6, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(253, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(221, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PRODUCTO, CODIGO, CANTIDAD, PRECIO, TOTAL, FECHA });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.Location = new Point(29, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 145);
            dataGridView1.TabIndex = 11;
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
            // FECHA
            // 
            FECHA.HeaderText = "FECHA";
            FECHA.Name = "FECHA";
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
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-242, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 52);
            panel1.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(244, 0);
            label7.Name = "label7";
            label7.Size = new Size(656, 45);
            label7.TabIndex = 1;
            label7.Text = "PRODUCTOS VENDIDOS POR PROVEEDOR";
            // 
            // CONSULTA_ProductosProvedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(748, 509);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F);
            Name = "CONSULTA_ProductosProvedor";
            Text = "CONSULTA";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button button3;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn PRODUCTO;
        private DataGridViewTextBoxColumn CODIGO;
        private DataGridViewTextBoxColumn CANTIDAD;
        private DataGridViewTextBoxColumn PRECIO;
        private DataGridViewTextBoxColumn TOTAL;
        private DataGridViewTextBoxColumn FECHA;
        private Panel panel1;
        private Label label7;
    }
}