namespace PequenaLogistica
{
    partial class Home
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
            btnVerificarFretes = new Button();
            btnCadastroRota = new Button();
            btnCadastrarEndereco = new Button();
            btnInformarFrete = new Button();
            SuspendLayout();
            // 
            // btnVerificarFretes
            // 
            btnVerificarFretes.Location = new Point(283, 30);
            btnVerificarFretes.Name = "btnVerificarFretes";
            btnVerificarFretes.Size = new Size(246, 29);
            btnVerificarFretes.TabIndex = 0;
            btnVerificarFretes.Text = "VERIFICAR FRETES DISPONÍVEIS";
            btnVerificarFretes.UseVisualStyleBackColor = true;
            btnVerificarFretes.Click += btnVerificarFretesDisponiveis_Click;
            // 
            // btnCadastroRota
            // 
            btnCadastroRota.Location = new Point(283, 137);
            btnCadastroRota.Name = "btnCadastroRota";
            btnCadastroRota.Size = new Size(246, 30);
            btnCadastroRota.TabIndex = 2;
            btnCadastroRota.Text = "CADASTRAR ROTA";
            btnCadastroRota.UseVisualStyleBackColor = true;
            btnCadastroRota.Click += btnCadastroRota_Click;
            // 
            // btnCadastrarEndereco
            // 
            btnCadastrarEndereco.Location = new Point(283, 173);
            btnCadastrarEndereco.Name = "btnCadastrarEndereco";
            btnCadastrarEndereco.Size = new Size(246, 30);
            btnCadastrarEndereco.TabIndex = 3;
            btnCadastrarEndereco.Text = "CADASTRAR ENDEREÇO";
            btnCadastrarEndereco.UseVisualStyleBackColor = true;
            btnCadastrarEndereco.Click += btnCadastrarEndereco_Click;
            // 
            // btnInformarFrete
            // 
            btnInformarFrete.Location = new Point(283, 65);
            btnInformarFrete.Name = "btnInformarFrete";
            btnInformarFrete.Size = new Size(246, 29);
            btnInformarFrete.TabIndex = 1;
            btnInformarFrete.Text = "SOLICITAR FRETE";
            btnInformarFrete.UseVisualStyleBackColor = true;
            btnInformarFrete.Click += btnInformarFrete_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarEndereco);
            Controls.Add(btnCadastroRota);
            Controls.Add(btnInformarFrete);
            Controls.Add(btnVerificarFretes);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerificarFretes;
        private Button btnCadastroRota;
        private Button btnCadastrarEndereco;
        private Button btnInformarFrete;
    }
}