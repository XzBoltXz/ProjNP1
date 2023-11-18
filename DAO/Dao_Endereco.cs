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
    class Dao_Endereco
    {
        SqlConnection conexao;


        public Dao_Endereco()
        {
            conexao = new SqlConnection(@"Data Source = SUP-025\SQLEXPRESS;
                                        Trusted_Connection = True;
                                          Initial Catalog = DB_PIM;");
        }

        public void Adicionar(Endereco Endereco)
        {
            string strSQL = "insert into Bonicacao(Rua, Bairro, NumCasa, CEP, Complemento  )values(@RUA, @BAIRRO, @NUMCASA, @CEP, @COMPLEMENTO)";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            comando.Parameters.AddWithValue("@RUA", Endereco.Rua);
            comando.Parameters.AddWithValue("@BAIRRO", Endereco.Bairro);
            comando.Parameters.AddWithValue("@NUMCASA", Endereco.NumCasa);
            comando.Parameters.AddWithValue("@CEP", Endereco.CEP);
            comando.Parameters.AddWithValue("@Complemento", Endereco.Complemento);

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

        public Endereco Consultar(Endereco Endereco)
        {
            string strSQL = "Select * from Endereco where CEP = " + Endereco.CEP;

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            try
            {
                conexao.Open();
                SqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    Endereco.Rua = Convert.ToString(rd["RUA"]);
                    Endereco.Bairro = Convert.ToString(rd["BAIRRO"]);
                    Endereco.NumCasa = Convert.ToInt32(rd["NUMCASA"]);
                    Endereco.CEP = Convert.ToInt32(rd["CEP"]);
                    Endereco.Complemento = Convert.ToString(rd["COMPLEMENTO"]);

                }
                return Endereco;
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
        public void Editar(Endereco Endereco)
        {
            string strSQL = "Update Endereco set Rua = @RUA, Bairro = @BAIRRO, Numcasa = @NUMCASA, CEP = @CEP where Complemento = @Complemento";
            //
            //"Update Funcionarios set NOME = @NOME, RG = @RG where CPF = @CPF";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            Endereco.Rua = Convert.ToString(rd["RUA"]);
            Endereco.Bairro = Convert.ToString(rd["BAIRRO"]);
            Endereco.NumCasa = Convert.ToInt32(rd["NUMCASA"]);
            Endereco.CEP = Convert.ToInt32(rd["CEP"]);
            Endereco.Complemento = Convert.ToString(rd["COMPLEMENTO"]);
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
        public void Excluir(Endereco Endereco)
        {
            string strSQL = "delete from Endereco where CEP = @CEP";

            SqlCommand comando = new SqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@CEP", Endereco.CEP);

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
