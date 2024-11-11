namespace PequenaLogistica
{
    partial class FormSolicitacaoFrete
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
            txtPeso = new TextBox();
            lblPeso = new Label();
            lblRetirada = new Label();
            lblNumero = new Label();
            lblRua = new Label();
            lblComplemento = new Label();
            txtEnderecoRetirada = new TextBox();
            txtRuaRetirada = new TextBox();
            txtNumeroRetirada = new TextBox();
            txtComplementoRetirada = new TextBox();
            btnSolicitaFrete = new Button();
            lblTitleEntrega = new Label();
            txtEnderecoEntrega = new TextBox();
            txtRuaEntrega = new TextBox();
            lblEntrega = new Label();
            lblRuaEntrega = new Label();
            lblComplementoEntrega = new Label();
            txtComplementoEntrega = new TextBox();
            txtWhatsapp = new TextBox();
            lblContato = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 28);
            label1.TabIndex = 0;
            label1.Text = "ESPECIFICAÇÃO DE FRETE ";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(100, 79);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(156, 27);
            txtPeso.TabIndex = 1;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(100, 56);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(156, 20);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso Aproximado (kg)";
            // 
            // lblRetirada
            // 
            lblRetirada.AutoSize = true;
            lblRetirada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRetirada.Location = new Point(100, 125);
            lblRetirada.Name = "lblRetirada";
            lblRetirada.Size = new Size(157, 20);
            lblRetirada.TabIndex = 3;
            lblRetirada.Text = "Endereço de Retirada";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(100, 259);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Número";
            // 
            // lblRua
            // 
            lblRua.AutoSize = true;
            lblRua.Location = new Point(100, 189);
            lblRua.Name = "lblRua";
            lblRua.Size = new Size(34, 20);
            lblRua.TabIndex = 5;
            lblRua.Text = "Rua";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(100, 327);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(104, 20);
            lblComplemento.TabIndex = 6;
            lblComplemento.Text = "Complemento";
            // 
            // txtEnderecoRetirada
            // 
            txtEnderecoRetirada.Location = new Point(100, 148);
            txtEnderecoRetirada.Name = "txtEnderecoRetirada";
            txtEnderecoRetirada.Size = new Size(156, 27);
            txtEnderecoRetirada.TabIndex = 7;
            // 
            // txtRuaRetirada
            // 
            txtRuaRetirada.Location = new Point(100, 212);
            txtRuaRetirada.Name = "txtRuaRetirada";
            txtRuaRetirada.Size = new Size(156, 27);
            txtRuaRetirada.TabIndex = 8;
            // 
            // txtNumeroRetirada
            // 
            txtNumeroRetirada.Location = new Point(100, 282);
            txtNumeroRetirada.Name = "txtNumeroRetirada";
            txtNumeroRetirada.Size = new Size(156, 27);
            txtNumeroRetirada.TabIndex = 9;
            // 
            // txtComplementoRetirada
            // 
            txtComplementoRetirada.Location = new Point(100, 349);
            txtComplementoRetirada.Name = "txtComplementoRetirada";
            txtComplementoRetirada.Size = new Size(156, 27);
            txtComplementoRetirada.TabIndex = 10;
            txtComplementoRetirada.TextChanged += txComplementoRetirada_TextChanged;
            // 
            // btnSolicitaFrete
            // 
            btnSolicitaFrete.Location = new Point(522, 349);
            btnSolicitaFrete.Name = "btnSolicitaFrete";
            btnSolicitaFrete.Size = new Size(156, 29);
            btnSolicitaFrete.TabIndex = 11;
            btnSolicitaFrete.Text = "SOLICITAR FRETE";
            btnSolicitaFrete.UseVisualStyleBackColor = true;
            btnSolicitaFrete.Click += btnSolicitaFrete_Click;
            // 
            // lblTitleEntrega
            // 
            lblTitleEntrega.AutoSize = true;
            lblTitleEntrega.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleEntrega.Location = new Point(522, 9);
            lblTitleEntrega.Name = "lblTitleEntrega";
            lblTitleEntrega.Size = new Size(109, 28);
            lblTitleEntrega.TabIndex = 12;
            lblTitleEntrega.Text = " ENTREGA";
            // 
            // txtEnderecoEntrega
            // 
            txtEnderecoEntrega.Location = new Point(522, 79);
            txtEnderecoEntrega.Name = "txtEnderecoEntrega";
            txtEnderecoEntrega.Size = new Size(156, 27);
            txtEnderecoEntrega.TabIndex = 13;
            // 
            // txtRuaEntrega
            // 
            txtRuaEntrega.Location = new Point(522, 148);
            txtRuaEntrega.Name = "txtRuaEntrega";
            txtRuaEntrega.Size = new Size(156, 27);
            txtRuaEntrega.TabIndex = 14;
            // 
            // lblEntrega
            // 
            lblEntrega.AutoSize = true;
            lblEntrega.Location = new Point(522, 56);
            lblEntrega.Name = "lblEntrega";
            lblEntrega.Size = new Size(147, 20);
            lblEntrega.TabIndex = 15;
            lblEntrega.Text = "Endereço de Entrega";
            // 
            // lblRuaEntrega
            // 
            lblRuaEntrega.AutoSize = true;
            lblRuaEntrega.Location = new Point(522, 125);
            lblRuaEntrega.Name = "lblRuaEntrega";
            lblRuaEntrega.Size = new Size(89, 20);
            lblRuaEntrega.TabIndex = 16;
            lblRuaEntrega.Text = "Rua/Estrada";
            // 
            // lblComplementoEntrega
            // 
            lblComplementoEntrega.AutoSize = true;
            lblComplementoEntrega.Location = new Point(522, 189);
            lblComplementoEntrega.Name = "lblComplementoEntrega";
            lblComplementoEntrega.Size = new Size(104, 20);
            lblComplementoEntrega.TabIndex = 17;
            lblComplementoEntrega.Text = "Complemento";
            // 
            // txtComplementoEntrega
            // 
            txtComplementoEntrega.Location = new Point(522, 212);
            txtComplementoEntrega.Name = "txtComplementoEntrega";
            txtComplementoEntrega.Size = new Size(156, 27);
            txtComplementoEntrega.TabIndex = 20;
            // 
            // txtWhatsapp
            // 
            txtWhatsapp.Location = new Point(522, 282);
            txtWhatsapp.Name = "txtWhatsapp";
            txtWhatsapp.Size = new Size(156, 27);
            txtWhatsapp.TabIndex = 21;
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Location = new Point(522, 259);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(133, 20);
            lblContato.TabIndex = 22;
            lblContato.Text = "Contato Whatsapp";
            // 
            // FormSolicitacaoFrete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblContato);
            Controls.Add(txtWhatsapp);
            Controls.Add(txtComplementoEntrega);
            Controls.Add(lblComplementoEntrega);
            Controls.Add(lblRuaEntrega);
            Controls.Add(lblEntrega);
            Controls.Add(txtRuaEntrega);
            Controls.Add(txtEnderecoEntrega);
            Controls.Add(lblTitleEntrega);
            Controls.Add(btnSolicitaFrete);
            Controls.Add(txtComplementoRetirada);
            Controls.Add(txtNumeroRetirada);
            Controls.Add(txtRuaRetirada);
            Controls.Add(txtEnderecoRetirada);
            Controls.Add(lblComplemento);
            Controls.Add(lblRua);
            Controls.Add(lblNumero);
            Controls.Add(lblRetirada);
            Controls.Add(lblPeso);
            Controls.Add(txtPeso);
            Controls.Add(label1);
            Name = "FormSolicitacaoFrete";
            Text = "SOLICITAR FRETE";
            Load += FormSolicitacaoFrete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPeso;
        private Label lblPeso;
        private Label lblRetirada;
        private Label lblNumero;
        private Label lblRua;
        private Label lblComplemento;
        private TextBox txtEnderecoRetirada;
        private TextBox txtRuaRetirada;
        private TextBox txtNumeroRetirada;
        private TextBox txtComplementoRetirada;
        private Button btnSolicitaFrete;
        private Label lblTitleEntrega;
        private TextBox txtEnderecoEntrega;
        private TextBox txtRuaEntrega;
        private Label lblEntrega;
        private Label lblRuaEntrega;
        private Label lblComplementoEntrega;
        private TextBox txtComplementoEntrega;
        private TextBox txtWhatsapp;
        private Label lblContato;
    }
}