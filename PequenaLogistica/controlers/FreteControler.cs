using PequenaLogistica.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace PequenaLogistica.controlers
{
    public class FreteControler
    {
        // Valida os campos obrigatórios para a solicitação de frete
        public bool ValidarCampos(Frete frete)
        {
            if (string.IsNullOrEmpty(frete.EnderecoRetirada) || string.IsNullOrEmpty(frete.RuaRetirada) ||
                string.IsNullOrEmpty(frete.NumeroRetirada) || string.IsNullOrEmpty(frete.EnderecoEntrega) || 
                string.IsNullOrEmpty(frete.RuaEntrega) || string.IsNullOrEmpty(frete.Peso) || frete.Peso == "0")
            {
                // Campos de endereço faltando, incluindo Endereço de Entrega
                return false;
            }

            return true;
        }
        public string ProcessarSolicitacao(Frete frete)
        {
            if (!ValidarCampos(frete))
            {
                return "Por favor, preencha todos os campos corretamente.";
            }
            if (salvarSolicitacao(frete))
            {
                return "Solicitação de frete realizado com sucesso!";
            }
            else
            {
                return "Erro ao solicitar.";
            }
          
            
        }
        public bool salvarSolicitacao(Frete frete)
        {
            try
            {
                string filePath = "solicitacoesFretes.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("Peso: " + frete.Peso);
                    writer.WriteLine("Endereço Retirada: " + frete.EnderecoRetirada);
                    writer.WriteLine("Rua Retirada: " + frete.RuaRetirada);
                    writer.WriteLine("Número Retirada: " + frete.NumeroRetirada);
                    writer.WriteLine("Complemento Retirada: " + frete.ComplementoRetirada);
                    writer.WriteLine("Endereço Entrega: " + frete.EnderecoEntrega);
                    writer.WriteLine("Rua Entrega: " + frete.RuaEntrega);
                    writer.WriteLine("Complemento Entrega: " + frete.ComplementoEntrega);
                    writer.WriteLine("Contato Whatsapp: " + frete.Contato);
                    writer.WriteLine("Data Solicitação: " + DateTime.Now);
                    writer.WriteLine("-------------------------------");
                }
            }
            catch (Exception ) 
            {
                return false;
            }
            return true;
        }
        public List<Frete> ListarFretes()
        {
            List<Frete> fretes = new List<Frete>();
            string filePath = "solicitacoesFretes.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    Frete frete = null;

                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        if (line.StartsWith("Peso:"))
                        {
                            // Adiciona o frete anterior antes de iniciar um novo
                            if (frete != null) fretes.Add(frete);
                            frete = new Frete();
                            frete.Peso = line.Replace("Peso: ", "").Trim();
                        }
                        else if (line.StartsWith("Endereço Retirada:")) frete.EnderecoRetirada = line.Replace("Endereço Retirada: ", "").Trim();
                        else if (line.StartsWith("Rua Retirada:")) frete.RuaRetirada = line.Replace("Rua Retirada: ", "").Trim();
                        else if (line.StartsWith("Número Retirada:")) frete.NumeroRetirada = line.Replace("Número Retirada: ", "").Trim();
                        else if (line.StartsWith("Complemento Retirada:")) frete.ComplementoRetirada = line.Replace("Complemento Retirada: ", "").Trim();
                        else if (line.StartsWith("Endereço Entrega:")) frete.EnderecoEntrega = line.Replace("Endereço Entrega: ", "").Trim();
                        else if (line.StartsWith("Rua Entrega:")) frete.RuaEntrega = line.Replace("Rua Entrega: ", "").Trim();
                        else if (line.StartsWith("Complemento Entrega:")) frete.ComplementoEntrega = line.Replace("Complemento Entrega: ", "").Trim();
                        else if (line.StartsWith("Contato Whatsapp:")) frete.Contato = line.Replace("Contato Whatsapp: ", "").Trim();

                    }
                    if (frete != null) fretes.Add(frete);// Adiciona o último frete
                }
            }
            return fretes;
        }
    }
}
