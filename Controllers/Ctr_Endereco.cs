using ProjNP1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjNP1.DAO;

namespace ProjNP1.Controllers
{
    class Ctr_Endereco: Ctr_Telefone
    {
        readonly Dao_Endereco dao_endereco;
        public Ctr_Endereco()
        {
            dao_endereco = new Dao_Endereco();
        }
        public void Adicionar(Endereco endereco)
        {
            //if( endereco.Complemento =="")
            //{
            //    dao_endereco.Adicionar(endereco)= endereco.Complemento;
            //}
            dao_endereco.Adicionar(endereco);
        }
        public void Editar()
        {

        }
        public void Consultar()
        {

        }

        public void Excluir()
        {

        }
    }
}
