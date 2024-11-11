namespace PequenaLogistica
{
    partial class ListaFretesDisponiveis
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
            components = new System.ComponentModel.Container();
            btnEfetuarFrete = new Button();
            dataGridViewFretes = new DataGridView();
            fretesBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFretes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fretesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnEfetuarFrete
            // 
            btnEfetuarFrete.Location = new Point(336, 390);
            btnEfetuarFrete.Name = "btnEfetuarFrete";
            btnEfetuarFrete.Size = new Size(94, 29);
            btnEfetuarFrete.TabIndex = 1;
            btnEfetuarFrete.Text = "FRETEAR";
            btnEfetuarFrete.UseVisualStyleBackColor = true;
            btnEfetuarFrete.Click += btnEfetuarFrete_Click;
            // 
            // dataGridViewFretes
            // 
            dataGridViewFretes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFretes.Location = new Point(232, 54);
            dataGridViewFretes.Name = "dataGridViewFretes";
            dataGridViewFretes.RowHeadersWidth = 51;
            dataGridViewFretes.Size = new Size(300, 188);
            dataGridViewFretes.TabIndex = 2;
            // 
            // ListaFretesDisponiveis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewFretes);
            Controls.Add(btnEfetuarFrete);
            Name = "ListaFretesDisponiveis";
            Text = "ListaFretes";
            Load += ListaFretesDisponiveis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewFretes).EndInit();
            ((System.ComponentModel.ISupportInitialize)fretesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEfetuarFrete;
        private DataGridView dataGridViewFretes;
        private BindingSource fretesBindingSource;
    }
}