using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjNP1.Models
{
    class Funcionario: Financeiro
    {
        public int cod { get; set; }
        public string nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Endereco End { get; set; }

        public Funcionario()
        {
            End = new Endereco();
        }
    }
}
