namespace CapaPresentacion
{
    partial class CRUD_Producto
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txt_StockProducto = new TextBox();
            label6 = new Label();
            txt_PrecProducto = new TextBox();
            label5 = new Label();
            txt_CatProducto = new TextBox();
            label4 = new Label();
            txt_NombProducto = new TextBox();
            txt_CodProducto = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btn_ModProducto = new Button();
            btn_AgrProducto = new Button();
            btn_InProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(607, 181);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 30);
            label1.TabIndex = 2;
            label1.Text = "PRODUCTOS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_StockProducto);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_PrecProducto);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_CatProducto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_NombProducto);
            groupBox1.Controls.Add(txt_CodProducto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 222);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLES";
            // 
            // txt_StockProducto
            // 
            txt_StockProducto.Font = new Font("Segoe UI", 9.75F);
            txt_StockProducto.Location = new Point(107, 178);
            txt_StockProducto.Name = "txt_StockProducto";
            txt_StockProducto.Size = new Size(193, 25);
            txt_StockProducto.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(48, 179);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 14;
            label6.Text = "Stock:";
            // 
            // txt_PrecProducto
            // 
            txt_PrecProducto.Font = new Font("Segoe UI", 9.75F);
            txt_PrecProducto.Location = new Point(107, 140);
            txt_PrecProducto.Name = "txt_PrecProducto";
            txt_PrecProducto.Size = new Size(193, 25);
            txt_PrecProducto.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 141);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 12;
            label5.Text = "Precio:";
            // 
            // txt_CatProducto
            // 
            txt_CatProducto.Font = new Font("Segoe UI", 9.75F);
            txt_CatProducto.Location = new Point(107, 103);
            txt_CatProducto.Name = "txt_CatProducto";
            txt_CatProducto.Size = new Size(193, 25);
            txt_CatProducto.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 104);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 10;
            label4.Text = "Categoria:";
            // 
            // txt_NombProducto
            // 
            txt_NombProducto.Font = new Font("Segoe UI", 9.75F);
            txt_NombProducto.Location = new Point(107, 66);
            txt_NombProducto.Name = "txt_NombProducto";
            txt_NombProducto.Size = new Size(193, 25);
            txt_NombProducto.TabIndex = 9;
            // 
            // txt_CodProducto
            // 
            txt_CodProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_CodProducto.Location = new Point(107, 28);
            txt_CodProducto.Name = "txt_CodProducto";
            txt_CodProducto.Size = new Size(193, 25);
            txt_CodProducto.TabIndex = 8;
            txt_CodProducto.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 67);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 7;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 31);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 6;
            label2.Text = "Codigo:";
            // 
            // btn_ModProducto
            // 
            btn_ModProducto.Location = new Point(396, 336);
            btn_ModProducto.Name = "btn_ModProducto";
            btn_ModProducto.Size = new Size(170, 38);
            btn_ModProducto.TabIndex = 6;
            btn_ModProducto.Text = "MODIFICAR PRODUCTO";
            btn_ModProducto.UseVisualStyleBackColor = true;
            // 
            // btn_AgrProducto
            // 
            btn_AgrProducto.Location = new Point(396, 281);
            btn_AgrProducto.Name = "btn_AgrProducto";
            btn_AgrProducto.Size = new Size(170, 38);
            btn_AgrProducto.TabIndex = 5;
            btn_AgrProducto.Text = "AGREGAR PRODUCTO";
            btn_AgrProducto.UseVisualStyleBackColor = true;
            // 
            // btn_InProducto
            // 
            btn_InProducto.Location = new Point(396, 391);
            btn_InProducto.Name = "btn_InProducto";
            btn_InProducto.Size = new Size(170, 38);
            btn_InProducto.TabIndex = 7;
            btn_InProducto.Text = "INHABILITAR PRODUCTO";
            btn_InProducto.UseVisualStyleBackColor = true;
            // 
            // CRUD_Producto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 492);
            Controls.Add(btn_InProducto);
            Controls.Add(btn_ModProducto);
            Controls.Add(btn_AgrProducto);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CRUD_Producto";
            Text = "CRUD_Producto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txt_NombProducto;
        private TextBox txt_CodProducto;
        private Label label3;
        private Label label2;
        private TextBox txt_StockProducto;
        private Label label6;
        private TextBox txt_PrecProducto;
        private Label label5;
        private TextBox txt_CatProducto;
        private Label label4;
        private Button btn_ModProducto;
        private Button btn_AgrProducto;
        private Button btn_InProducto;
    }
}