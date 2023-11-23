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
    class Dao_Bonificacao
    {
        SqlConnection conexao;


        public Dao_Bonificacao()
        {
            conexao = new SqlConnection(@"Data Source = SUP-025\SQLEXPRESS;
                                        Trusted_Connection = True;
                                          Initial Catalog = DB_PIM;");
        }

        public void Adicionar(Bonificacao Bonificacao)
        {
            string strSQL = "insert into Bonicacao(HoraExtra,Comissao, AuxHomeOffice, AuxEstudo )values(@HORAEXTRA, @COMISSAO, @AUXHOMEOFFICE, @AUXESTUDO)";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@HORAEXTRA", Bonificacao.HoraExtra);
            comando.Parameters.AddWithValue("@COMISSAO", Bonificacao.Comissao);
            comando.Parameters.AddWithValue("@AUXHOMEOFFICE", Bonificacao.AuxHomeOffice);
            comando.Parameters.AddWithValue("@AUXESTUDO", Bonificacao.AuxEstudo);

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

        public Bonificacao Consultar(Bonificacao Bonificacao)
        {
            string strSQL = "Select * from Telefone where Comissao = " + Bonificacao.Comissao;

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            try
            {
                conexao.Open();
                SqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    Bonificacao.HoraExtra = Convert.ToInt32(rd["HORAEXTRA"]);
                    Bonificacao.Comissao = Convert.ToInt32(rd["COMISSAO"]);
                    Bonificacao.AuxHomeOffice = Convert.ToInt32(rd["AUXHOMEOFFICE"]);
                    Bonificacao.AuxEstudo = Convert.ToInt32(rd["AUXESTUDO"]);

                }
                return Bonificacao;
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
       /*public void Editar(Bonificacao Bonificacao)
        {
            string strSQL = "Update Bonuficacao set HoraExtra = @HORAEXTRA, Comissao = @COMISSAO, AuxHomeOffice = @AUXHOMEOFFICE, where AuxEstudo =@AUXESTUDO";
            //
            //"Update Funcionarios set NOME = @NOME, RG = @RG where CPF = @CPF";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            Bonificacao.HoraExtra = Convert.ToInt32(rd["HORAEXTRA"]);
            Bonificacao.Comissao = Convert.ToInt32(rd["COMISSAO"]);
            Bonificacao.AuxHomeOffice = Convert.ToInt32(rd["AUXHOMEOFFICE"]);
            Bonificacao.AuxEstudo = Convert.ToInt32(rd["AUXESTUDO"]);
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
        }*/
        public void Excluir(Bonificacao Bonificacao)
        {
            string strSQL = "delete from Bonificacao where Comissao = @COMISSAO";

            SqlCommand comando = new SqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@COMISSAO", Bonificacao.Comissao);

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
