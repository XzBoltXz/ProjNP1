using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjNP1.Models
{
    class Financeiro
    {
        public int codFinc { get; set; }
        public double Salario { get; set; }
        public string Cargo { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Departamento { get; set; }

        public Financeiro()
        {

        }
    }
}
