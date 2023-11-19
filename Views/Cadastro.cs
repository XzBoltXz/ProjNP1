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

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            funcionario.nome = textBox1.Text;
            funcionario.CPF = textBox2.Text;
            funcionario.RG = textBox3.Text;
            endereco.Bairro = textBox6.Text;
            endereco.Rua = textBox7.Text;
            endereco.CEP = Convert.ToInt32(textBox8.Text);
            endereco.NumCasa = Convert.ToInt32(textBox9.Text);
            financeiro.Departamento = textBox12.Text;
            financeiro.Cargo = textBox11.Text;
            financeiro.Salario = Convert.ToDouble(textBox10.Text);
            financeiro.DataAdmissao = textBox13.Text;

            ctr_Financeiro.AdicioarFin(financeiro);
            ctr_Endereco.Adicionar(endereco);
            ctr_Funcionario.Adicionar(funcionario);           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            funcionario.CPF = textBox5.Text;
            funcionario = ctr_Funcionario.Consultar(funcionario);
            atualiza_textbox();


        }

        private void atualiza_textbox()
        {
            textBox1.Text = funcionario.nome;
            textBox2.Text = funcionario.CPF;
            textBox3.Text = funcionario.RG;
            textBox4.Text = Convert.ToString(funcionario.cod);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionario.nome = textBox1.Text;
            textBox2.Text = funcionario.CPF;
            textBox3.Text = funcionario.RG;

            ctr_Funcionario.Editar(funcionario);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcionario.cod = Convert.ToInt32(textBox4.Text);
            funcionario.nome = "";
            funcionario.CPF = "";
            funcionario.RG = "";
            ctr_Funcionario.Excluir(funcionario);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
