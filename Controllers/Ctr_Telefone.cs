using ProjNP1.Models;
using ProjNP1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjNP1.Controllers
{
    class Ctr_Telefone
    {
        Dao_Telefone dao_telefone;
        public Ctr_Telefone()
        {
            dao_telefone = new Dao_Telefone();
        }
        public void AdicionarTel(Telefone telefone)
        {
            dao_telefone.Adicionar(telefone);
        }
        public void EditarTel()
        {

        }

        public void ConsultarTel() // veriricar existencia
        {

        }

        public void ExcluirTel()
        {

        }
    }
}
