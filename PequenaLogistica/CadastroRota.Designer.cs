namespace PequenaLogistica
{
    partial class CadastroRota
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
            lblTitle = new Label();
            txtLocalidade = new TextBox();
            txtCidade = new TextBox();
            textBox3 = new TextBox();
            lblLocalidade = new Label();
            lblCidade = new Label();
            lblMaps = new Label();
            lblkMaps = new LinkLabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(251, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(321, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "INFORME SEU TRAJETO COMUM";
            // 
            // txtLocalidade
            // 
            txtLocalidade.Location = new Point(315, 105);
            txtLocalidade.Name = "txtLocalidade";
            txtLocalidade.Size = new Size(204, 27);
            txtLocalidade.TabIndex = 1;
            txtLocalidade.TextChanged += txtLocalidade_TextChanged;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(315, 158);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(204, 27);
            txtCidade.TabIndex = 2;
            txtCidade.TextChanged += txtCidade_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(315, 221);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 27);
            textBox3.TabIndex = 3;
            // 
            // lblLocalidade
            // 
            lblLocalidade.AutoSize = true;
            lblLocalidade.Location = new Point(315, 82);
            lblLocalidade.Name = "lblLocalidade";
            lblLocalidade.Size = new Size(85, 20);
            lblLocalidade.TabIndex = 5;
            lblLocalidade.Text = "Localidade:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(315, 135);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(124, 20);
            lblCidade.TabIndex = 6;
            lblCidade.Text = "Cidade frequente";
            // 
            // lblMaps
            // 
            lblMaps.AutoSize = true;
            lblMaps.Location = new Point(315, 198);
            lblMaps.Name = "lblMaps";
            lblMaps.Size = new Size(204, 20);
            lblMaps.TabIndex = 8;
            lblMaps.Text = "Localização No Google Maps";
            // 
            // lblkMaps
            // 
            lblkMaps.AutoSize = true;
            lblkMaps.Location = new Point(474, 198);
            lblkMaps.Name = "lblkMaps";
            lblkMaps.Size = new Size(45, 20);
            lblkMaps.TabIndex = 9;
            lblkMaps.TabStop = true;
            lblkMaps.Tag = "https://www.google.com.br/maps/preview";
            lblkMaps.Text = "Maps";
            // 
            // CadastroRota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblkMaps);
            Controls.Add(lblMaps);
            Controls.Add(lblCidade);
            Controls.Add(lblLocalidade);
            Controls.Add(textBox3);
            Controls.Add(txtCidade);
            Controls.Add(txtLocalidade);
            Controls.Add(lblTitle);
            Name = "CadastroRota";
            Text = "CadastroRota";
            Load += CadastroRota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtLocalidade;
        private TextBox txtCidade;
        private TextBox textBox3;
        private Label lblLocalidade;
        private Label lblCidade;
        private Label lblMaps;
        private LinkLabel lblkMaps;
    }
}