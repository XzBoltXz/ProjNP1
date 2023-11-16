using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjNP1.DAO;
using ProjNP1.Models;


namespace ProjNP1.Controllers
{
    class Ctr_Funcionario: Ctr_Financeiro
    {
        Dao_Proj dao_proj;
        public Ctr_Funcionario()
        {
            dao_proj = new Dao_Proj();
        }
        public void Adicionar(Funcionario funcionario)
        {
            dao_proj.Adicionar(funcionario);
        }

        public void Editar(Funcionario funcionario)
        {
            Funcionario temp = new Funcionario();
            temp.CPF = funcionario.CPF;
            temp = Consultar(temp);

          
                dao_proj.Editar(funcionario);
            
        }

        public Funcionario Consultar(Funcionario funcionario)
        {
            Funcionario temp = new Funcionario();
           temp= dao_proj.Consultar(funcionario);
            return temp;
           
        }

        public void Excluir(Funcionario funcionario)
        {
            Funcionario temp = new Funcionario();
            temp.cod = funcionario.cod;
            temp = Consultar(funcionario);

        //    if (temp.cod != 0)
            {
                dao_proj.Excluir(funcionario);
            }
        }

        public void Ativar()
        {

        }

        public void Desativar()
        {

        }
    }
}
