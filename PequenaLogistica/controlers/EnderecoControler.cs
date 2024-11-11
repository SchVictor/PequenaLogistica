using PequenaLogistica.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PequenaLogistica.controlers
{
    internal class EnderecoControler
    {
        // Valida se todos os campos obrigatórios estão preenchidos
        public bool ValidarCamposPreenchidos(Endereco endereco)
        {
            return !string.IsNullOrEmpty(endereco.Cidade) &&
                   !string.IsNullOrEmpty(endereco.Localidade) &&
                   !string.IsNullOrEmpty(endereco.Rua) &&
                   !string.IsNullOrEmpty(endereco.Numero);
        }
        // Salva os dados do endereço em um arquivo
        public bool Salvar(Endereco endereco, string filePath = "enderecos.txt")
        {
            if (!ValidarCamposPreenchidos(endereco))
                return false;

            try
            {
                string enderecoData = $"{endereco.Cidade},{endereco.Localidade},{endereco.Rua},{endereco.Numero},{endereco.Complemento}";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(enderecoData);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
