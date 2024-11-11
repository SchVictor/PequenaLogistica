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
    public partial class FormSolicitacaoFrete : Form
    {
        public FormSolicitacaoFrete()
        {
            InitializeComponent();
        }

        private void btnSolicitaFrete_Click(object sender, EventArgs e)
        {
            Frete frete = new Frete()
            {
                Peso = txtPeso.Text,
                EnderecoRetirada = txtEnderecoRetirada.Text,
                RuaRetirada = txtRuaRetirada.Text,
                NumeroRetirada = txtNumeroRetirada.Text,
                ComplementoRetirada = txtComplementoRetirada.Text,
                EnderecoEntrega = txtEnderecoEntrega.Text,
                RuaEntrega = txtRuaEntrega.Text,
                ComplementoEntrega = txtComplementoEntrega.Text,
                Contato = txtWhatsapp.Text
            };
            // Usando a classe FreteController para processar a solicitação
            FreteControler freteControler = new FreteControler();
            string mensagem = freteControler.ProcessarSolicitacao(frete);

            // Exibe a mensagem de resultado
            MessageBox.Show(mensagem);
            this.Close();

        }


        private void btnEnderecosSalvos_Click(object sender, EventArgs e)
        {

        }

        private void txComplementoRetirada_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSolicitacaoFrete_Load(object sender, EventArgs e)
        {

        }
    }
}
