namespace PequenaLogistica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            btnCadastro = new Button();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelLogin = new Label();
            groupBox1 = new GroupBox();
            chkshowPassword = new CheckBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Khaki;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ActiveCaptionText;
            btnLogin.Location = new Point(15, 181);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 46);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = SystemColors.ActiveCaptionText;
            btnCadastro.Location = new Point(16, 246);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(217, 27);
            btnCadastro.TabIndex = 3;
            btnCadastro.Text = "CADASTRE-SE";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(16, 46);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(16, 109);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(217, 27);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 363);
            label1.Name = "label1";
            label1.Size = new Size(221, 41);
            label1.TabIndex = 6;
            label1.Text = "RURAL TRACK";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(16, 23);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(16, 86);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 8;
            label3.Text = "Senha";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogin.ForeColor = SystemColors.ActiveCaptionText;
            labelLogin.Location = new Point(572, 37);
            labelLogin.Name = "labelLogin";
            labelLogin.RightToLeft = RightToLeft.No;
            labelLogin.Size = new Size(73, 28);
            labelLogin.TabIndex = 9;
            labelLogin.Text = "LOGIN";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Peru;
            groupBox1.Controls.Add(chkshowPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCadastro);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Location = new Point(482, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 298);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // chkshowPassword
            // 
            chkshowPassword.AutoSize = true;
            chkshowPassword.ForeColor = SystemColors.ActiveCaptionText;
            chkshowPassword.Location = new Point(120, 142);
            chkshowPassword.Name = "chkshowPassword";
            chkshowPassword.Size = new Size(126, 24);
            chkshowPassword.TabIndex = 9;
            chkshowPassword.Text = "Mostrar Senha";
            chkshowPassword.UseVisualStyleBackColor = true;
            chkshowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Khaki;
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(-2, -10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 461);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(labelLogin);
            ForeColor = Color.DarkGreen;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLogin;
        private Button btnCadastro;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelLogin;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chkshowPassword;
    }
}
