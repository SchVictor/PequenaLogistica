using PequenaLogistica.controlers;
using PequenaLogistica.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PequenaLogistica
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario //criando um Usuario definindo seus valores.
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                ConfirmaSenha = txtConfirmaSenha.Text,
            };

            UsuarioControler usuarioControler = new UsuarioControler();//instanciando a classe que contem os metodos

            // Tenta cadastrar o usuário e recebe a mensagem de resultado
            string resultado = usuarioControler.CadastrarUsuario(usuario);
            // Exibe a mensagem de resultado e, se bem-sucedido, limpa o formulário
            MessageBox.Show(resultado);
            if (resultado == "Cadastro concluído.")
            {
                txtNome.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                txtConfirmaSenha.Clear();
                this.Close();
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
