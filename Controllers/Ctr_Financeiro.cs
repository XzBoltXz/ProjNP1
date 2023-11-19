using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjNP1.DAO;
using ProjNP1.Models;

namespace ProjNP1.Controllers
{
    
    class Ctr_Financeiro
    {
        Dao_Financeiro dao_financeiro;
        public Ctr_Financeiro()
        {
            dao_financeiro = new Dao_Financeiro();
        }
        public void AdicioarFin(Financeiro financeiro)
        {
            dao_financeiro.Adicionar(financeiro);
        }
        public void EditarFin()
        {

        }
        public void ConsultarFin()
        {

        }
    }
}
