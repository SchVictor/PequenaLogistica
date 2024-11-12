using PequenaLogistica.controlers;
using PequenaLogistica.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PequenaLogistica.DesignPattern
{
    internal class LogisticaFacade
    {
        private readonly FreteControler freteController;
        private readonly UsuarioControler usuarioController;
        public LogisticaFacade()
        {
            freteController = new FreteControler();
            usuarioController = new UsuarioControler();
        }

        // Método para solicitar frete
        public string SolicitarFrete(Frete frete)
        {
            return freteController.ProcessarSolicitacao(frete);
        }
        // Método para listar fretes
        public List<Frete> ListarFretes()
        {
            return freteController.ListarFretes();
        }
        // Método para editar frete
        /*public bool EditarFrete(Frete freteEditado)
        {
            return freteController.AtualizarFrete(freteEditado);
        }*/
        // Método para cadastrar usuário
        public string CadastrarUsuario(Usuario usuario)
        {
            return usuarioController.CadastrarUsuario(usuario);
        }
        // Método para listar usuários
        public List<Usuario> ListarUsuarios()
        {
            return usuarioController.ListarUsuarios();
        }
    }
}
