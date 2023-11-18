using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjNP1.Models;
using System.Data;

namespace ProjNP1.DAO
{
    class Dao_Funcionario
    {
        SqlConnection conexao;
        // teste de atualizaçao de codigo
        //testestsss

        public Dao_Funcionario()
        {
            conexao = new SqlConnection(@"Data Source = SUP-025\SQLEXPRESS;
                                        Trusted_Connection = True;
                                          Initial Catalog = DB_PIM;");
        }
        
        public void Adicionar(Funcionario funcionario)
        {
            string strSQL = "insert into Funcionarios(nome, CPF, RG)values(@NOME, @CPF, @RG)";
            
            SqlCommand comando = new SqlCommand(strSQL,conexao);

            comando.Parameters.AddWithValue("@NOME", funcionario.nome);
            comando.Parameters.AddWithValue("@CPF", funcionario.CPF);
            comando.Parameters.AddWithValue("@RG", funcionario.RG);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {
              
            }
            finally
            {
                conexao.Close();
            }
        }

        public Funcionario Consultar(Funcionario funcionario)
        {
            string strSQL = "Select * from Funcionarios where CPF = " +funcionario.CPF;

            SqlCommand comando = new SqlCommand(strSQL, conexao);            

            try
            {
                conexao.Open();
                SqlDataReader rd = comando.ExecuteReader();

                while(rd.Read())
                {
                    funcionario.cod = Convert.ToInt32(rd["COD_FUNC"]);
                    funcionario.nome = Convert.ToString(rd["NOME"]);
                    funcionario.CPF = Convert.ToString(rd["CPF"]);
                    funcionario.RG = Convert.ToString(rd["RG"]);
                }
                return funcionario;
            }
            catch
            {
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Editar(Funcionario funcionario)
        {
            string strSQL = "Update Funcionarios set NOME = @NOME, RG = '777777777' where CPF = 11111111111";
                //
                //"Update Funcionarios set NOME = @NOME, RG = @RG where CPF = @CPF";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@COD", funcionario.nome);
            comando.Parameters.AddWithValue("@NOME", funcionario.nome);
            comando.Parameters.AddWithValue("@CPF", funcionario.CPF);
            comando.Parameters.AddWithValue("@RG", funcionario.RG);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {
                
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Excluir(Funcionario funcionario)
        {
            string strSQL = "delete from Funcionarios where COD_FUNC = @COD";

            SqlCommand comando = new SqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@COD", funcionario.cod);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
