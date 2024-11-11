using PequenaLogistica.controlers;
using PequenaLogistica.models;
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
    public partial class FormCadastroEndereco : Form
    {
        public FormCadastroEndereco()
        {
            InitializeComponent();
        }

        private void btnSaveEndereco_Click(object sender, EventArgs e)
        {
            Endereco endereco = new Endereco    // Criação de um objeto Endereco com os dados dos campos de texto
            {
                Cidade = txtCidade.Text,
                Localidade = txtLocalidadeBairro.Text,
                Rua = txtEstradaGeral.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text
            };
            // Usando o EnderecoControler para salvar o endereço
            EnderecoControler enderecoControler = new EnderecoControler();
            if (enderecoControler.Salvar(endereco))
            {
                MessageBox.Show("Endereço cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar o endereço. Verifique os campos.");
            }

        }
    }
}
