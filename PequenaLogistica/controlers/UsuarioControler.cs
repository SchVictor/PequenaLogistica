using PequenaLogistica.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PequenaLogistica.controlers
{
    internal class UsuarioControler
    {
        // Verifica se todos os campos obrigatórios estão preenchidos
        public bool ValidarCamposPreenchidos(Usuario usuario)
        {
            return !string.IsNullOrEmpty(usuario.Nome) &&
                   !string.IsNullOrEmpty(usuario.Email) &&
                   !string.IsNullOrEmpty(usuario.Senha) &&
                   !string.IsNullOrEmpty(usuario.ConfirmaSenha);
        }

        // Valida o formato do email
        public bool ValidarEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w\.-]+@[\w\.-]+\.\w+$");
        }

        // Verifica se a senha e a confirmação de senha são iguais
        public bool ValidarSenha(Usuario usuario)
        {
            return usuario.Senha == usuario.ConfirmaSenha;
        }
        
        public string CadastrarUsuario(Usuario usuario, string filePath = "credenciais.txt")
        {
            if (!ValidarCamposPreenchidos(usuario))
                return "Por favor, preencha todos os campos.";

            if (!ValidarSenha(usuario))
                return "As senhas não coincidem. Por favor, verifique.";

            if (!ValidarEmail(usuario.Email))
                return "Email inválido.";

            try
            {
                string usuarioData = $"{usuario.Nome},{usuario.Email},{usuario.Senha}";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(usuarioData);
                }
                return "Cadastro concluído.";
            }
            catch (Exception ex)
            {
                return $"Erro ao cadastrar: {ex.Message}";
            }

        }

        public List <Usuario> ListarUsuarios(string filePath = "credenciais.txt")
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                if (File.Exists(filePath))
                {
                    foreach (var linha in File.ReadAllLines(filePath))
                    {
                        var dados = linha.Split(',');
                        if(dados.Length >=2 )
                        {
                            usuarios.Add(new Usuario
                            {
                                Nome = dados[0],
                                Email = dados[1]
                                // Não incluímos a senha por questões obvias
                            });
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Erro ao carregar usuários: {ex.Message}");

            }
            return usuarios;
        }
    }
}
