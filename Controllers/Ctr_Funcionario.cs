using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjNP1.DAO;
using ProjNP1.Models;


namespace ProjNP1.Controllers
{
    class Ctr_Funcionario: Ctr_Financeiro
    {
        readonly Dao_Funcionario dao_funcionario;
        
        public Ctr_Funcionario()
        {
            dao_funcionario = new Dao_Funcionario();
            
        }
        public void Adicionar(Funcionario funcionario)
        {
            
            dao_funcionario.Adicionar(funcionario);



        }

        public void Editar(Funcionario funcionario)
        {
            Funcionario temp = new Funcionario();
            temp.CPF = funcionario.CPF;
            temp = Consultar(temp);
            
           dao_funcionario.Editar(funcionario);
            
        }

        public Funcionario Consultar(Funcionario funcionario)
        {
            Funcionario temp = new Funcionario();
          temp= dao_funcionario.Consultar(funcionario);
            
           return temp;
           
        }

        public void Excluir(Funcionario funcionario)
        {
            Funcionario temp = new Funcionario();
           temp.CPF = funcionario.CPF;
           temp = Consultar(funcionario);
       
           dao_funcionario.Excluir(funcionario);
       
        }

        public void Ativar()
        {

        }

        public void Desativar()
        {

        }
    }
}
