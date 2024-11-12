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
            usuarioBindingSource = new BindingSource(components);
            usuarioBindingSource1 = new BindingSource(components);
            dataGridViewFretes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFretes).BeginInit();
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
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(models.Usuario);
            // 
            // usuarioBindingSource1
            // 
            usuarioBindingSource1.DataSource = typeof(models.Usuario);
            // 
            // dataGridViewFretes
            // 
            dataGridViewFretes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFretes.Location = new Point(-2, -1);
            dataGridViewFretes.Name = "dataGridViewFretes";
            dataGridViewFretes.RowHeadersWidth = 51;
            dataGridViewFretes.Size = new Size(801, 385);
            dataGridViewFretes.TabIndex = 2;
            dataGridViewFretes.CellContentClick += dataGridViewFretes_CellContentClick_1;
            // 
            // ListaFretesDisponiveis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewFretes);
            Controls.Add(btnEfetuarFrete);
            Name = "ListaFretesDisponiveis";
            Load += ListaFretesDisponiveis_Load;
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFretes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnEfetuarFrete;
        private BindingSource usuarioBindingSource;
        private BindingSource usuarioBindingSource1;
        private DataGridView dataGridViewFretes;
    }
}