using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjNP1.Models
{
    class Endereco: Telefone
    {
        public int codEnd { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int NumCasa { get; set; }
        public int CEP { get; set; }
        public string Complemento { get; set; }

        public Endereco()
        {

        }

    }
}
