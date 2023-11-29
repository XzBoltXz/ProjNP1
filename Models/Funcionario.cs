using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjNP1.Models
{
    class Funcionario: Financeiro
    {
        public int CodFunc { get; set; }
        public string Nome { get; set; }
        public double CPF { get; set; }
        public double RG { get; set; }
        public Endereco End { get; set; }

        

        public Funcionario()
        {
            End = new Endereco();            
        }
    }
}
