using PequenaLogistica.models;
using PequenaLogistica.controlers;

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
    public partial class ListagemUsuario : Form
    {
        public ListagemUsuario()
        {
            InitializeComponent();
        }

        private void ListagemUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }
        private void CarregarUsuarios()
        {
            UsuarioControler usuarioControler = new UsuarioControler();
            List<Usuario> usuarios = usuarioControler.ListarUsuarios();

            // Configura o DataGridView com os dados dos usuários
            dataGridViewUsuarios.DataSource = usuarios;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
