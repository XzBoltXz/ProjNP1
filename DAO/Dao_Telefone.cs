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
    class Dao_Telefone
    {
        SqlConnection conexao;
        

        public Dao_Telefone()
        {
            conexao = new SqlConnection(@"Data Source = SUP-025\SQLEXPRESS;
                                        Trusted_Connection = True;
                                          Initial Catalog = DB_PIM;");
            
        }

        public void Adicionar(Telefone telefone)
        {
           
            string strSQL = "insert into Funcionarios(DDD,Numero)values( @DDD, @Numero)";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            
            comando.Parameters.AddWithValue("@DDD", telefone.DDD);
            comando.Parameters.AddWithValue("@NUMERO", telefone.Numero);

            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                conexao.Close();
            }
        }

        public Telefone Consultar(Telefone Telefone)
        {
            string strSQL = "Select * from Telefone where DDD = " + Telefone.DDD;

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            try
            {
                conexao.Open();
                SqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    Telefone.DDD = Convert.ToString(rd["DDD"]);
                    Telefone.Numero = Convert.ToInt32(rd["NUMERO"]);


                }
                return Telefone;
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
        public void Editar(Telefone Telefone)
        {
            string strSQL = "Update Funcionarios set DDD = @DDD, where Numero = @NUMERO";
            //
            //"Update Funcionarios set NOME = @NOME, RG = @RG where CPF = @CPF";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@DDD", Telefone.DDD);
            comando.Parameters.AddWithValue("@NUMERO", Telefone.Numero);


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
        public void Excluir(Telefone Telefone)
        {
            string strSQL = "delete from Telefone where DDD = @DDD";

            SqlCommand comando = new SqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@DDD", Telefone.DDD);

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
