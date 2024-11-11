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
    public partial class ListaFretesDisponiveis : Form
    {
        public ListaFretesDisponiveis()
        {
            InitializeComponent();
            CarregarFretes();

        }
        private void CarregarFretes()
        {
            FreteControler freteControler = new FreteControler();
            List<Frete> fretes = freteControler.ListarFretes();
            // Configura o BindingSource com a lista de fretes e vincula ao DataGridView
            fretesBindingSource.DataSource = fretes;
            dataGridViewFretes.DataSource = fretesBindingSource;

            // Configura o DataGridView com os dados dos fretes
            dataGridViewFretes.DataSource = fretes;
        }
        private void ListaFretesDisponiveis_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewFretes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEfetuarFrete_Click(object sender, EventArgs e)
        {
            if (dataGridViewFretes.SelectedRows.Count > 0)
            {
                int index = dataGridViewFretes.SelectedRows[0].Index;
                Frete freteSelecionado = (Frete)dataGridViewFretes.Rows[index].DataBoundItem;

                // Aqui você pode implementar a lógica para processar o frete
                MessageBox.Show($"Frete para {freteSelecionado.EnderecoEntrega} efetuado com sucesso!");

                // Opcional: Remover o frete da lista (se já foi efetuado)
                dataGridViewFretes.Rows.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um frete para efetuar.");
            }
        }
    }
}
