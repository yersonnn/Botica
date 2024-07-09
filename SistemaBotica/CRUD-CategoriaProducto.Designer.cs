namespace CapaPresentacion
{
    partial class CRUD_CategoriaProducto
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
            panel1 = new Panel();
            label7 = new Label();
            btn_Edit = new Button();
            btn_Nuev = new Button();
            btn_Inhabilitar = new Button();
            groupBox1 = new GroupBox();
            checkBox_CAT = new CheckBox();
            btn_ModCAT = new Button();
            btn_AgCat = new Button();
            txt_NombCat = new TextBox();
            txt_CodCat = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgv_CAT = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_CAT).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-162, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1541, 55);
            panel1.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(174, 6);
            label7.Name = "label7";
            label7.Size = new Size(216, 45);
            label7.TabIndex = 0;
            label7.Text = "CATEGORIAS";
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(660, 147);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(170, 38);
            btn_Edit.TabIndex = 30;
            btn_Edit.Text = "EDITAR DATOS";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Nuev
            // 
            btn_Nuev.Location = new Point(660, 93);
            btn_Nuev.Name = "btn_Nuev";
            btn_Nuev.Size = new Size(170, 38);
            btn_Nuev.TabIndex = 29;
            btn_Nuev.Text = "NUEVO";
            btn_Nuev.UseVisualStyleBackColor = true;
            btn_Nuev.Click += btn_Nuev_Click;
            // 
            // btn_Inhabilitar
            // 
            btn_Inhabilitar.Location = new Point(660, 205);
            btn_Inhabilitar.Name = "btn_Inhabilitar";
            btn_Inhabilitar.Size = new Size(170, 38);
            btn_Inhabilitar.TabIndex = 28;
            btn_Inhabilitar.Text = "INHABILITAR ";
            btn_Inhabilitar.UseVisualStyleBackColor = true;
            btn_Inhabilitar.Click += btn_Inhabilitar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox_CAT);
            groupBox1.Controls.Add(btn_ModCAT);
            groupBox1.Controls.Add(btn_AgCat);
            groupBox1.Controls.Add(txt_NombCat);
            groupBox1.Controls.Add(txt_CodCat);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 281);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 141);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLES";
            // 
            // checkBox_CAT
            // 
            checkBox_CAT.AutoSize = true;
            checkBox_CAT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_CAT.Location = new Point(338, 70);
            checkBox_CAT.Name = "checkBox_CAT";
            checkBox_CAT.Size = new Size(79, 25);
            checkBox_CAT.TabIndex = 27;
            checkBox_CAT.Text = "Estado ";
            checkBox_CAT.UseVisualStyleBackColor = true;
            // 
            // btn_ModCAT
            // 
            btn_ModCAT.Location = new Point(474, 75);
            btn_ModCAT.Name = "btn_ModCAT";
            btn_ModCAT.Size = new Size(170, 38);
            btn_ModCAT.TabIndex = 26;
            btn_ModCAT.Text = "MODIFICAR";
            btn_ModCAT.UseVisualStyleBackColor = true;
            btn_ModCAT.Click += btn_ModCAT_Click;
            // 
            // btn_AgCat
            // 
            btn_AgCat.Location = new Point(474, 31);
            btn_AgCat.Name = "btn_AgCat";
            btn_AgCat.Size = new Size(170, 38);
            btn_AgCat.TabIndex = 25;
            btn_AgCat.Text = "AGREGAR";
            btn_AgCat.UseVisualStyleBackColor = true;
            btn_AgCat.Click += btn_AgCat_Click;
            // 
            // txt_NombCat
            // 
            txt_NombCat.Font = new Font("Segoe UI", 9.75F);
            txt_NombCat.Location = new Point(107, 88);
            txt_NombCat.Name = "txt_NombCat";
            txt_NombCat.Size = new Size(193, 25);
            txt_NombCat.TabIndex = 9;
            // 
            // txt_CodCat
            // 
            txt_CodCat.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_CodCat.Location = new Point(107, 50);
            txt_CodCat.Name = "txt_CodCat";
            txt_CodCat.Size = new Size(193, 25);
            txt_CodCat.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 89);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 7;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 53);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 6;
            label2.Text = "Codigo:";
            // 
            // dgv_CAT
            // 
            dgv_CAT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_CAT.Location = new Point(12, 81);
            dgv_CAT.Name = "dgv_CAT";
            dgv_CAT.Size = new Size(607, 181);
            dgv_CAT.TabIndex = 26;
            dgv_CAT.CellDoubleClick += dgv_CAT_CellDoubleClick;
            // 
            // CRUD_CategoriaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(844, 504);
            Controls.Add(panel1);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Nuev);
            Controls.Add(btn_Inhabilitar);
            Controls.Add(groupBox1);
            Controls.Add(dgv_CAT);
            Name = "CRUD_CategoriaProducto";
            Text = "CRUD_CategoriaProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_CAT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Button btn_Edit;
        private Button btn_Nuev;
        private Button btn_Inhabilitar;
        private GroupBox groupBox1;
        private CheckBox checkBox_CAT;
        private Button btn_ModCAT;
        private Button btn_AgCat;
        private TextBox txt_NombCat;
        private TextBox txt_CodCat;
        private Label label3;
        private Label label2;
        private DataGridView dgv_CAT;
    }
}