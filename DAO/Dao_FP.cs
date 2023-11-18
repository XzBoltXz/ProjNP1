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
    class Dao_FP
    {
        SqlConnection conexao;


        public Dao_FP()
        {
            conexao = new SqlConnection(@"Data Source = SUP-025\SQLEXPRESS;
                                        Trusted_Connection = True;
                                          Initial Catalog = DB_PIM;");
        }

        public void Adicionar(FolhaDePagamento FolhaDePagamento)
        {
            string strSQL = "insert into Funcionarios(Codigo, SalarioBruto, SalarioLiquido)values(@CODIGO, @SALARIOBRUTO, @SALARIOLIQUIDO)";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@CODIGO", FolhaDePagamento.Codigo);
            comando.Parameters.AddWithValue("@SALARIOBRUTO", FolhaDePagamento.SalarioBruto);
            comando.Parameters.AddWithValue("@SALARIOLIQUIDO", FolhaDePagamento.SalarioLiquido);

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

        public FolhaDePagamento Consultar(FolhaDePagamento FolhaDePagamento)
        {
            string strSQL = "Select * from FolhaDePagamento where Codigo = " + FolhaDePagamento.Codigo;

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            try
            {
                conexao.Open();
                SqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    FolhaDePagamento.Codigo = Convert.ToInt32(rd["COD_FP"]);
                    FolhaDePagamento.SalarioBruto = Convert.ToDouble(rd["SALARIOBRUTO"]);
                    FolhaDePagamento.SalarioLiquido = Convert.ToDouble(rd["SALARIOLIQUIDO"]);

                }
                return FolhaDePagamento;
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
        public void Editar(FolhaDePagamento FolhaDePagamento)
        {
            string strSQL = "Update Funcionarios set Codigo = @CODIGO, SALARIOBRUTO = '777777777' where SALARIOLIQUIDO = 11111111111";
            //
            //"Update Funcionarios set NOME = @NOME, RG = @RG where CPF = @CPF";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@CODIGO", FolhaDePagamento.Codigo);
            comando.Parameters.AddWithValue("@SALARIOBRUTO", FolhaDePagamento.SalarioBruto);
            comando.Parameters.AddWithValue("@SALARIOLIQUIDO", FolhaDePagamento.SalarioLiquido);


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
        public void Excluir(FolhaDePagamento FolhaDePagamento)
        {
            string strSQL = "delete from Funcionarios where COD_FP = @CODIGO";

            SqlCommand comando = new SqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@CODIGO", FolhaDePagamento.Codigo);

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
