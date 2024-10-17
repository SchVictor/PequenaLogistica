namespace PequenaLogistica
{
    partial class Cadastro
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            textBox3 = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            lblNome = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(32, 46);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(178, 27);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(32, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(178, 27);
            txtEmail.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(32, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(211, 27);
            textBox3.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(32, 167);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(178, 27);
            txtSenha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 208);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 4;
            label1.Text = "Confirmar Senha";
            label1.Click += label1_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(32, 23);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(143, 20);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome e Sobrenome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(32, 81);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(32, 144);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblSenha);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(12, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 415);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Cadastro";
            Text = "Cadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox textBox3;
        private TextBox txtSenha;
        private Label label1;
        private Label lblNome;
        private Label lblEmail;
        private Label lblSenha;
        private GroupBox groupBox1;
    }
}