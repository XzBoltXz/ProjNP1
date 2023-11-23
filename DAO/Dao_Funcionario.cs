using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjNP1.Models;
using System.Data;
using ProjNP1.Controllers;
using System.Windows.Forms;
namespace ProjNP1.DAO
{
    class Dao_Funcionario
    {
        SqlConnection conexao;
        
        public Dao_Funcionario()
        {
            conexao = new SqlConnection(@"Data Source = SUP-025\SQLEXPRESS;
                                        Trusted_Connection = True;
                                          Initial Catalog = DB_PIM;");
            
        }       

        public void Adicionar(Funcionario funcionario)
        {
            string strSQL = "insert into Funcionarios(NOME, CPF, RG, DDD, Numero,SALARIO, CARGO, DEPARTAMENTO, DTADMISSAO, RUA, BAIRRO, NUMCASA, CEP, COMPLEMENTO )" +
                "values(@NOME, @CPF, @RG,@DDD, @Numero,@SALARIO, @CARGO, @DEPARTAMENTO, @DTADMISSAO,@RUA, @BAIRRO, @NUMCASA, @CEP,@COMPLEMENTO)";
            
            SqlCommand comando = new SqlCommand(strSQL,conexao);

            
            comando.Parameters.AddWithValue("@NOME" , Convert.ToString(funcionario.nome));
            comando.Parameters.AddWithValue("@CPF", Convert.ToDouble(funcionario.CPF));
            comando.Parameters.AddWithValue("@RG", Convert.ToDouble(funcionario.RG));
            comando.Parameters.AddWithValue("@DDD", Convert.ToDouble(funcionario.End.DDD));
            comando.Parameters.AddWithValue("@NUMERO", Convert.ToDouble(funcionario.End.Numero));
            comando.Parameters.AddWithValue("@DEPARTAMENTO", funcionario.Departamento);
            comando.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
            comando.Parameters.AddWithValue("@Salario", funcionario.Salario);
            comando.Parameters.AddWithValue("@DTADMISSAO", Convert.ToDateTime(funcionario.DataAdmissao));
            comando.Parameters.AddWithValue("@BAIRRO", funcionario.End.Bairro);
            comando.Parameters.AddWithValue("@RUA", funcionario.End.Rua);
            comando.Parameters.AddWithValue("@NUMCASA", funcionario.End.NumCasa);
            comando.Parameters.AddWithValue("@CEP", funcionario.End.CEP);
            comando.Parameters.AddWithValue("@COMPLEMENTO", funcionario.End.Complemento);


            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }

        public Funcionario Consultar(Funcionario funcionario)
        {
            string strSQL = "Select * from Funcionarios where CPF ="+ funcionario.CPF;

            SqlCommand comando = new SqlCommand(strSQL, conexao);            

            try
            {
                conexao.Open();
                SqlDataReader rd = comando.ExecuteReader();

                while(rd.Read())
                {
                    funcionario.codFunc = Convert.ToInt32(rd["COD_FUNC"]);
                    funcionario.nome = Convert.ToString(rd["NOME"]);
                    funcionario.CPF = Convert.ToDouble(rd["CPF"]);
                    funcionario.RG = Convert.ToDouble(rd["RG"]);
                    funcionario.End.DDD = Convert.ToString(rd["DDD"]);
                    funcionario.End.Numero = Convert.ToInt32(rd["NUMERO"]);
                    funcionario.Departamento = Convert.ToString(rd["DEPARTAMENTO"]);
                    funcionario.Cargo = Convert.ToString(rd["CARGO"]);
                    funcionario.Salario = Convert.ToDouble(rd["SALARIO"]);
                    funcionario.DataAdmissao = Convert.ToDateTime(rd["DTADMISSAO"]);
                    funcionario.End.Bairro = Convert.ToString(rd["BAIRRO"]);
                    funcionario.End.Rua = Convert.ToString(rd["RUA"]);
                    funcionario.End.NumCasa = Convert.ToInt32(rd["NUMCASA"]);
                    funcionario.End.CEP = Convert.ToInt32(rd["CEP"]);
                    funcionario.End.Complemento = Convert.ToString(rd["COMPLEMENTO"]);
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
            string strSQL = "Update Funcionarios set NOME = @NOME, RG = @RG, DDD= @DDD,NUMERO = @Numero,SALARIO = @SALARIO,CARGO = @CARGO," +
                " DEPARTAMENTO= @DEPARTAMENTO,RUA = @RUA, BAIRRO= @BAIRRO, NUMCASA = @NUMCASA, CEP = @CEP,COMPLEMENTO = @COMPLEMENTO where CPF = " + funcionario.CPF;
                //
                //"Update Funcionarios set NOME = @NOME, RG = @RG where CPF = @CPF";

            SqlCommand comando = new SqlCommand(strSQL, conexao);

            
            comando.Parameters.AddWithValue("@NOME", funcionario.nome);            
            comando.Parameters.AddWithValue("@RG", funcionario.RG);
            comando.Parameters.AddWithValue("@DDD", funcionario.End.DDD);
            comando.Parameters.AddWithValue("@NUMERO", Convert.ToDouble(funcionario.End.Numero));
            comando.Parameters.AddWithValue("@DEPARTAMENTO", funcionario.Departamento);
            comando.Parameters.AddWithValue("@Cargo", funcionario.Cargo);
            comando.Parameters.AddWithValue("@Salario", funcionario.Salario);
            comando.Parameters.AddWithValue("@BAIRRO", funcionario.End.Bairro);
            comando.Parameters.AddWithValue("@RUA", funcionario.End.Rua);
            comando.Parameters.AddWithValue("@NUMCASA", funcionario.End.NumCasa);
            comando.Parameters.AddWithValue("@CEP", funcionario.End.CEP);
            comando.Parameters.AddWithValue("@COMPLEMENTO", funcionario.End.Complemento);
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
            string strSQL = "delete from Funcionarios where CPF = @CPF";

            SqlCommand comando = new SqlCommand(strSQL, conexao);
            comando.Parameters.AddWithValue("@CPF", funcionario.CPF);

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
