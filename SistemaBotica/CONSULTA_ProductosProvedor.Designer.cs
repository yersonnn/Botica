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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            comboEmpresa = new ComboBox();
            label4 = new Label();
            button3 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            btn_buscar = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboEmpresa);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(37, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 68);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL PROVEDOR";
            // 
            // comboEmpresa
            // 
            comboEmpresa.Font = new Font("Segoe UI", 12F);
            comboEmpresa.FormattingEnabled = true;
            comboEmpresa.Location = new Point(91, 28);
            comboEmpresa.Name = "comboEmpresa";
            comboEmpresa.Size = new Size(284, 29);
            comboEmpresa.TabIndex = 2;
            comboEmpresa.SelectedIndexChanged += comboEmpresa_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 31);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 1;
            label4.Text = "Empresa:";
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
            panel1.Size = new Size(1583, 52);
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
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(37, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Size = new Size(691, 275);
            dataGridView1.TabIndex = 24;
            // 
            // btn_buscar
            // 
            btn_buscar.Font = new Font("Segoe UI", 11.25F);
            btn_buscar.Location = new Point(455, 105);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(100, 33);
            btn_buscar.TabIndex = 25;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // CONSULTA_ProductosProvedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(740, 509);
            Controls.Add(btn_buscar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F);
            Name = "CONSULTA_ProductosProvedor";
            Text = "CONSULTA";
            Load += CONSULTA_ProductosProvedor_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label4;
        private Button button3;
        private ComboBox comboEmpresa;
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView1;
        private Button btn_buscar;
    }
}