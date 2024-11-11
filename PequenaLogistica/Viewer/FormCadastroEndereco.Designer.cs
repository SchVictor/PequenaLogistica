namespace PequenaLogistica
{
    partial class FormCadastroEndereco
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
            lblCity = new Label();
            txtCidade = new TextBox();
            lblLocalidadeBairro = new Label();
            lblRua = new Label();
            lblGps = new Label();
            txtEstradaGeral = new TextBox();
            txtLocalidadeBairro = new TextBox();
            txtLocalizacao = new TextBox();
            lblkMaps = new LinkLabel();
            btnSaveEndereco = new Button();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            SuspendLayout();
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(312, 20);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(56, 20);
            lblCity.TabIndex = 0;
            lblCity.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(312, 43);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(176, 27);
            txtCidade.TabIndex = 1;
            // 
            // lblLocalidadeBairro
            // 
            lblLocalidadeBairro.AutoSize = true;
            lblLocalidadeBairro.Location = new Point(312, 74);
            lblLocalidadeBairro.Name = "lblLocalidadeBairro";
            lblLocalidadeBairro.Size = new Size(128, 20);
            lblLocalidadeBairro.TabIndex = 2;
            lblLocalidadeBairro.Text = "Localidade/Bairro";
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(312, 127);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(176, 20);
            lblRua.TabIndex = 3;
            lblRua.Text = "Estrada Geral/Secundária";
            // 
            // lblGps
            // 
            lblGps.AutoSize = true;
            lblGps.Location = new Point(312, 294);
            lblGps.Name = "lblGps";
            lblGps.Size = new Size(116, 20);
            lblGps.TabIndex = 4;
            lblGps.Text = "Localização Gps";
            // 
            // txtEstradaGeral
            // 
            txtEstradaGeral.Location = new Point(312, 150);
            txtEstradaGeral.Name = "txtEstradaGeral";
            txtEstradaGeral.Size = new Size(176, 27);
            txtEstradaGeral.TabIndex = 6;
            // 
            // txtLocalidadeBairro
            // 
            txtLocalidadeBairro.Location = new Point(312, 97);
            txtLocalidadeBairro.Name = "txtLocalidadeBairro";
            txtLocalidadeBairro.Size = new Size(176, 27);
            txtLocalidadeBairro.TabIndex = 7;
            // 
            // txtLocalizacao
            // 
            txtLocalizacao.Location = new Point(312, 317);
            txtLocalizacao.Name = "txtLocalizacao";
            txtLocalizacao.Size = new Size(176, 27);
            txtLocalizacao.TabIndex = 8;
            // 
            // lblkMaps
            // 
            lblkMaps.AutoSize = true;
            lblkMaps.Location = new Point(390, 347);
            lblkMaps.Name = "lblkMaps";
            lblkMaps.Size = new Size(98, 20);
            lblkMaps.TabIndex = 10;
            lblkMaps.TabStop = true;
            lblkMaps.Text = "Google Maps";
            // 
            // btnSaveEndereco
            // 
            btnSaveEndereco.Location = new Point(312, 387);
            btnSaveEndereco.Name = "btnSaveEndereco";
            btnSaveEndereco.Size = new Size(176, 29);
            btnSaveEndereco.TabIndex = 11;
            btnSaveEndereco.Text = "SALVAR";
            btnSaveEndereco.UseVisualStyleBackColor = true;
            btnSaveEndereco.Click += btnSaveEndereco_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(312, 207);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(176, 27);
            txtNumero.TabIndex = 12;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(312, 184);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 13;
            lblNumero.Text = "Número";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(312, 264);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(176, 27);
            txtComplemento.TabIndex = 14;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(312, 241);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(180, 20);
            lblComplemento.TabIndex = 15;
            lblComplemento.Text = "Complemento/Referência";
            // 
            // FormCadastroEndereco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblComplemento);
            Controls.Add(txtComplemento);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Controls.Add(btnSaveEndereco);
            Controls.Add(lblkMaps);
            Controls.Add(txtLocalizacao);
            Controls.Add(txtLocalidadeBairro);
            Controls.Add(txtEstradaGeral);
            Controls.Add(lblGps);
            Controls.Add(lblRua);
            Controls.Add(lblLocalidadeBairro);
            Controls.Add(txtCidade);
            Controls.Add(lblCity);
            Name = "FormCadastroEndereco";
            Text = "CadastroEndereco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCity;
        private TextBox txtCidade;
        private Label lblLocalidadeBairro;
        private Label lblRua;
        private Label lblGps;
        private Label label5;
        private TextBox txtEstradaGeral;
        private TextBox txtLocalidadeBairro;
        private TextBox txtLocalizacao;
        private TextBox textBox5;
        private LinkLabel lblkMaps;
        private Button btnSaveEndereco;
        private TextBox txtNumero;
        private Label lblNumero;
        private TextBox txtComplemento;
        private Label lblComplemento;
    }
}