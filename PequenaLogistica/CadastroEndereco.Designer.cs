﻿namespace PequenaLogistica
{
    partial class CadastroEndereco
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
            label2 = new Label();
            lblRua = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            txtLocalidadeBairro = new TextBox();
            txtLocalizacao = new TextBox();
            lblkMaps = new LinkLabel();
            btnSaveEndereco = new Button();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 74);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 2;
            label2.Text = "Localidade/Bairro";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(312, 181);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 4;
            label4.Text = "Localização Gps";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 27);
            textBox2.TabIndex = 6;
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
            txtLocalizacao.Location = new Point(312, 203);
            txtLocalizacao.Name = "txtLocalizacao";
            txtLocalizacao.Size = new Size(176, 27);
            txtLocalizacao.TabIndex = 8;
            // 
            // lblkMaps
            // 
            lblkMaps.AutoSize = true;
            lblkMaps.Location = new Point(312, 233);
            lblkMaps.Name = "lblkMaps";
            lblkMaps.Size = new Size(98, 20);
            lblkMaps.TabIndex = 10;
            lblkMaps.TabStop = true;
            lblkMaps.Text = "Google Maps";
            // 
            // btnSaveEndereco
            // 
            btnSaveEndereco.Location = new Point(312, 273);
            btnSaveEndereco.Name = "btnSaveEndereco";
            btnSaveEndereco.Size = new Size(176, 29);
            btnSaveEndereco.TabIndex = 11;
            btnSaveEndereco.Text = "SALVAR";
            btnSaveEndereco.UseVisualStyleBackColor = true;
            // 
            // CadastroEndereco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveEndereco);
            Controls.Add(lblkMaps);
            Controls.Add(txtLocalizacao);
            Controls.Add(txtLocalidadeBairro);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(lblRua);
            Controls.Add(label2);
            Controls.Add(txtCidade);
            Controls.Add(lblCity);
            Name = "CadastroEndereco";
            Text = "CadastroEndereco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCity;
        private TextBox txtCidade;
        private Label label2;
        private Label lblRua;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox txtLocalidadeBairro;
        private TextBox txtLocalizacao;
        private TextBox textBox5;
        private LinkLabel lblkMaps;
        private Button btnSaveEndereco;
    }
}