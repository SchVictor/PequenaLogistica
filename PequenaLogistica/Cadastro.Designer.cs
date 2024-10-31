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
            label1 = new Label();
            lblNome = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            groupBox1 = new GroupBox();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfirmaSenha = new TextBox();
            btnCadastrar = new Button();
            btnBackStart = new Button();
            chkMostraSenha = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 167);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 4;
            label1.Text = "Confirmar Senha";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(81, 8);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(110, 20);
            lblNome.TabIndex = 5;
            lblNome.Text = "Primeiro Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(81, 61);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(81, 114);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkMostraSenha);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtConfirmaSenha);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblSenha);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Location = new Point(223, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(328, 426);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(81, 31);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(174, 27);
            txtNome.TabIndex = 12;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(81, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(174, 27);
            txtEmail.TabIndex = 11;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(81, 137);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(174, 27);
            txtSenha.TabIndex = 10;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(81, 190);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(174, 27);
            txtConfirmaSenha.TabIndex = 9;
            txtConfirmaSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(81, 253);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(174, 47);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnBackStart
            // 
            btnBackStart.Location = new Point(694, 409);
            btnBackStart.Name = "btnBackStart";
            btnBackStart.Size = new Size(94, 29);
            btnBackStart.TabIndex = 13;
            btnBackStart.Text = "INICIO";
            btnBackStart.UseVisualStyleBackColor = true;
            btnBackStart.Click += btnBackStart_Click;
            // 
            // chkMostraSenha
            // 
            chkMostraSenha.AutoSize = true;
            chkMostraSenha.Location = new Point(131, 223);
            chkMostraSenha.Name = "chkMostraSenha";
            chkMostraSenha.Size = new Size(124, 24);
            chkMostraSenha.TabIndex = 13;
            chkMostraSenha.Text = "Mostrar senha";
            chkMostraSenha.UseVisualStyleBackColor = true;
            chkMostraSenha.CheckedChanged += chkMostraSenha_CheckedChanged;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackStart);
            Controls.Add(groupBox1);
            Name = "Cadastro";
            Text = "Cadastro";
            Load += Cadastro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label lblNome;
        private Label lblEmail;
        private Label lblSenha;
        private GroupBox groupBox1;
       
        private Button btnCadastrar;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtConfirmaSenha;
        private Button btnBackStart;
        private CheckBox chkMostraSenha;
    }
}