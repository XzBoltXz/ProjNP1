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
    class Dao_Financeiro
    {
        SqlConnection conexao;


        public Dao_Financeiro()
        {
            conexao = new SqlConnection(@"Data Source = SUP-025\SQLEXPRESS;
                                        Trusted_Connection = True;
                                          Initial Catalog = DB_PIM;");
        }

        public void Adicionar(Financeiro Financeiro)
        {
            string strSQL = "insert into Financeiro(Salario, Cargo, DataAdmissao, Departamento)values(@SALARIO, @CARGO, @DATAADMISSAO, @DEPARTAMENTO)";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@SALARIO", Financeiro.Salario);
            comando.Parameters.AddWithValue("@CARGO", Financeiro.Cargo);
            comando.Parameters.AddWithValue("@DATAADMISSAO", Financeiro.DataAdmissao);
            comando.Parameters.AddWithValue("@DEPARTAMENTO", Financeiro.Departamento);

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

        public Financeiro Consultar(Financeiro Financeiro)
        {
            string strSQL = "Select * from Financeiro where Codigo = " + Financeiro.Cargo;

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            try
            {
                conexao.Open();
                SqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    Financeiro.Salario = Convert.ToInt32(rd["SALARIO"]);
                    Financeiro.Departamento = Convert.ToString(rd["DEPARTAMENTO"]);
                    Financeiro.Cargo = Convert.ToString(rd["CARGO"]);
                    Financeiro.DataAdmissao = Convert.ToString(rd["DATAADMISSAO"]);

                }
                return Financeiro;
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
        public void Editar(Financeiro Financeiro)
        {
            string strSQL = "Update Financeiro set Departamento = @DEPARTAMENTO, Salario = @SALARIO, DataAdmissao = @DATAADMISSAO,  where Cargo = @CARGO";
            //
            //"Update Funcionarios set NOME = @NOME, RG = @RG where CPF = @CPF";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@DEPARTAMENTO", Financeiro.Departamento);
            comando.Parameters.AddWithValue("@CARGO", Financeiro.Cargo);
            comando.Parameters.AddWithValue("@SALARIO", Financeiro.Salario);
            comando.Parameters.AddWithValue("@DATAADMISSAO", Financeiro.DataAdmissao);

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
        public void Excluir(Financeiro Financeiro)
        {
            string strSQL = "delete from FINANCEIRO where DEP_FIN = @DEPARTAMENTO";

            SqlCommand comando = new SqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@DEPARTAMENTO", Financeiro.Departamento);

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
