using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PequenaLogistica.models
{
    public class Frete
    {
        public string? Peso {  get; set; }
        public string? EnderecoRetirada { get; set; }
        public string? RuaRetirada { get; set; }
        public string? NumeroRetirada { get;set; }
        public string? ComplementoRetirada { get;set;}
        public string? EnderecoEntrega {  get; set; }
        public string? RuaEntrega { get; set;}
        public string? ComplementoEntrega { get; set;}
        public string? Contato { get; set; }   

    }
}
