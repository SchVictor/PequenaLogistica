using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PequenaLogistica
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtConfirmaSenha.Text)//verifica se senhas coicidem
            {
                MessageBox.Show("As senhas não coincidem. Por favor, verifique.");
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            //adicionar formatações e esconder senhas.

            string filePath = Path.Combine(Application.StartupPath, "BancoDados.txt");
            string usuarioData = $"{txtNome.Text},{txtEmail.Text},{txtSenha.Text}";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true)) // Salva os dados no arquivo em modo de acréscimo (append)
                {
                    writer.WriteLine(usuarioData);
                }
                //Exibe mensagem e limpa os campos
                MessageBox.Show("CADASTRO CONCLUIDO");
                txtNome.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                txtConfirmaSenha.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR: " + ex.Message);
            }

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnBackStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkMostraSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar = !chkMostraSenha.Checked;
            txtConfirmaSenha.UseSystemPasswordChar = !chkMostraSenha.Checked;
        }
    }
}
