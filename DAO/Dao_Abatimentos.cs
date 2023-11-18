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
    class Dao_Abatimentos
    {
        SqlConnection conexao;


        public Dao_Abatimentos()
        {
            conexao = new SqlConnection(@"Data Source = SUP-025\SQLEXPRESS;
                                        Trusted_Connection = True;
                                          Initial Catalog = DB_PIM;");
        }

        public void Adicionar(Abatimentos Abatimentos)
        {
            string strSQL = "insert into Abatimentos(INSS, FGTS, Convenio, Faltas)values(@INSS, @FGTS, @CONVENIO, @FALTAS)";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@INSS", Abatimentos.INSS);
            comando.Parameters.AddWithValue("@FGTS", Abatimentos.FGTS);
            comando.Parameters.AddWithValue("@CONVENIO", Abatimentos.Convenio);
            comando.Parameters.AddWithValue("@FALTAS", Abatimentos.Faltas);

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

        public Abatimentos Consultar(Abatimentos Abatimentos)
        {
            string strSQL = "Select * from Abatimentos where INSS = " + Abatimentos.INSS;

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            try
            {
                conexao.Open();
                SqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    Abatimentos.INSS = Convert.ToInt32(rd["INSS"]);
                    Abatimentos.FGTS = Convert.ToDouble(rd["FGTS"]);
                    Abatimentos.Convenio = Convert.ToDouble(rd["CONVENIO"]);
                    Abatimentos.Faltas = Convert.ToDouble(rd["FALTAS"]);

                }
                return Abatimentos;
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
        public void Editar(Abatimentos Abatimentos)
        {
            string strSQL = "Update Funcionarios set INSS = @INSS, FGTS = @FGTS, Convenio = @CONVENIO where Faltas = @FALTAS";
            //
            //"Update Funcionarios set NOME = @NOME, RG = @RG where CPF = @CPF";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@INSS", Abatimentos.INSS);
            comando.Parameters.AddWithValue("@FGTS", Abatimentos.FGTS);
            comando.Parameters.AddWithValue("@CONVENIO", Abatimentos.Convenio);
            comando.Parameters.AddWithValue("@FALTAS", Abatimentos.Faltas);


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
        public void Excluir(Abatimentos Abatimentos)
        {
            string strSQL = "delete from Funcionarios where INSS = @INSS";

            SqlCommand comando = new SqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@INSS", Abatimentos.INSS);

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
