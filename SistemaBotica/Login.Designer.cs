namespace CapaPresentacion
{
    partial class Login
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
            label7 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            txt_User = new TextBox();
            textContra = new TextBox();
            label2 = new Label();
            btn_Ingresar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(195, 8);
            label7.Name = "label7";
            label7.Size = new Size(117, 45);
            label7.TabIndex = 0;
            label7.Text = "LOGIN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-185, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 61);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 101);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 23;
            label1.Text = "Usuario:";
            // 
            // txt_User
            // 
            txt_User.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_User.Location = new Point(347, 101);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(243, 29);
            txt_User.TabIndex = 24;
            // 
            // textContra
            // 
            textContra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textContra.Location = new Point(347, 147);
            textContra.Name = "textContra";
            textContra.Size = new Size(243, 29);
            textContra.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(229, 147);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 25;
            label2.Text = "Contraseña:";
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.Location = new Point(347, 207);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(153, 38);
            btn_Ingresar.TabIndex = 27;
            btn_Ingresar.Text = "INGRESAR";
            btn_Ingresar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(971, 313);
            Controls.Add(btn_Ingresar);
            Controls.Add(textContra);
            Controls.Add(label2);
            Controls.Add(txt_User);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel1;
        private Label label1;
        private TextBox txt_User;
        private TextBox textContra;
        private Label label2;
        private Button btn_Ingresar;
    }
}