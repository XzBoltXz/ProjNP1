using ProjNP1.Controllers;
using ProjNP1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjNP1.Views
{
    public partial class Cadastro : Form
    {
        Funcionario funcionario;
        Ctr_Funcionario ctr_Funcionario;
        Financeiro financeiro;
        Ctr_Financeiro ctr_Financeiro;
        Endereco endereco;
        Ctr_Endereco ctr_Endereco;
        Telefone telefone;
        Ctr_Telefone ctr_Telefone;
        public Cadastro()
        {
            funcionario = new Funcionario();
            ctr_Funcionario = new Ctr_Funcionario();
            financeiro = new Financeiro();
            ctr_Financeiro = new Ctr_Financeiro();
            endereco = new Endereco();
            ctr_Endereco = new Ctr_Endereco();
            telefone = new Telefone();
            ctr_Telefone = new Ctr_Telefone();
            InitializeComponent();
        }

        private void btn_Cadastrar_Click_1(object sender, EventArgs e)
        {
            
            funcionario.nome = textBox1.Text;
            funcionario.CPF = Convert.ToDouble(textBox2.Text);
            funcionario.RG = Convert.ToDouble(textBox3.Text);
            funcionario.End.Bairro = textBox6.Text;
            funcionario.End.Rua = textBox7.Text;
            funcionario.End.CEP = Convert.ToInt32(textBox8.Text);
            funcionario.End.NumCasa  = Convert.ToInt32(textBox9.Text);
            funcionario.End.Complemento = textBox16.Text;
            funcionario.Departamento = textBox12.Text;
            funcionario.Cargo = textBox11.Text;
            funcionario.Salario = Convert.ToDouble(textBox10.Text);
            funcionario.DataAdmissao = Convert.ToDateTime(textBox13.Text);
            funcionario.End.DDD = textBox15.Text;
            funcionario.End.Numero = Convert.ToInt32(textBox14.Text);

            
            ctr_Funcionario.Adicionar(funcionario);
            MessageBox.Show("Funcionario cadastrado!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
                 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        ///private void btn_Consultar_Click(object sender, EventArgs e)
        //{
        //    funcionario.CPF = textBox5.Text;
        //    funcionario = ctr_Funcionario.Consultar(funcionario);
        //    atualiza_textbox();


        //}

       

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    funcionario.nome = textBox1.Text;
        //    textBox2.Text = funcionario.CPF;
        //    textBox3.Text = funcionario.RG;

        //    ctr_Funcionario.Editar(funcionario);
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    funcionario.cod = Convert.ToInt32(textBox4.Text);
        //    funcionario.nome = "";
        //    funcionario.CPF = "";
        //    funcionario.RG = "";
        //    ctr_Funcionario.Excluir(funcionario);
        //}

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void atualiza_textbox()
        {
            textBox1.Text = funcionario.nome;
            textBox2.Text = Convert.ToString(funcionario.CPF);
            textBox3.Text = Convert.ToString(funcionario.RG);
            textBox4.Text = Convert.ToString(funcionario.codFunc);
            textBox6.Text = Convert.ToString(funcionario.End.Bairro);
            textBox7.Text = Convert.ToString(funcionario.End.Rua);
            textBox8.Text = Convert.ToString(funcionario.End.CEP);
            textBox9.Text = Convert.ToString(funcionario.End.NumCasa);
            textBox10.Text = Convert.ToString(funcionario.Salario);
            textBox11.Text = Convert.ToString(funcionario.Cargo);
            textBox12.Text = Convert.ToString(funcionario.Departamento);
            textBox13.Text = Convert.ToString(funcionario.DataAdmissao);
            textBox14.Text = Convert.ToString(funcionario.End.Numero);
            textBox15.Text = Convert.ToString(funcionario.End.DDD);
            textBox16.Text = Convert.ToString(funcionario.End.Complemento);


        }
        private void btn_Consultar_Click(object sender, EventArgs e)
        {

            funcionario.CPF = Convert.ToDouble(textBox5.Text);
            

            funcionario = ctr_Funcionario.Consultar(funcionario);

            atualiza_textbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionario.nome = textBox1.Text;
            funcionario.CPF = Convert.ToInt64(textBox2.Text);
            funcionario.RG = Convert.ToDouble(textBox3.Text);
            funcionario.codFunc = Convert.ToInt32(textBox4.Text);
            funcionario.End.Bairro = textBox6.Text;
            funcionario.End.Rua = Convert.ToString(textBox7.Text);
            funcionario.End.CEP = Convert.ToInt32(textBox8.Text);
            funcionario.End.NumCasa = Convert.ToInt32(textBox9.Text);
            funcionario.Salario = Convert.ToDouble(textBox10.Text);
            funcionario.Cargo = textBox11.Text;
            funcionario.Departamento = textBox12.Text;
            funcionario.DataAdmissao = Convert.ToDateTime(textBox13.Text);
            funcionario.End.Numero = Convert.ToInt32(textBox14.Text);
            funcionario.End.DDD = Convert.ToString(textBox15.Text);
            funcionario.End.Complemento = Convert.ToString(textBox16.Text);

            ctr_Funcionario.Editar(funcionario);
            MessageBox.Show("Cadastro atualizado!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcionario.CPF = Convert.ToDouble(textBox5.Text);

            ctr_Funcionario.Excluir(funcionario);
            MessageBox.Show("Funcionario excluido!");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();

        }
    }
}
