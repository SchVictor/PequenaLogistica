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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnInformarViagem_Click(object sender, EventArgs e)
        {
            var verificarFretes = new ListaFretesDisponiveis();
            verificarFretes.Show();
        }

        private void btnInformarFrete_Click(object sender, EventArgs e)
        {
            var solicitaFrete = new FormSolicitacaoFrete();
            solicitaFrete.Show();
        }

        private void btnCadastrarEndereco_Click(object sender, EventArgs e)
        {
            var cadastrarEndereco = new FormCadastroEndereco();
            cadastrarEndereco.Show();
        }

        private void btnCadastroRota_Click(object sender, EventArgs e)
        {
            var cadastrarRota = new CadastroRota();
            cadastrarRota.Show();
        }

        private void btnVerificarFretesDisponiveis_Click(object sender, EventArgs e)
        {
            var verificarFretes = new ListaFretesDisponiveis();
            verificarFretes.Show();
        }
    }
}
