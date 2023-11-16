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

namespace ProjNP1
{
    public partial class Form1 : Form
    {
        Funcionario funcionario;
        Ctr_Funcionario ctr_Funcionario;
        public Form1()
        {
            funcionario = new Funcionario();
            ctr_Funcionario = new Ctr_Funcionario();
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {            
            funcionario.nome = textBox1.Text;
            funcionario.CPF = textBox2.Text;
            funcionario.RG = textBox3.Text;

            ctr_Funcionario.Adicionar(funcionario);
            MessageBox.Show("Funcionario cadastrado com sucesso!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {            
            funcionario.CPF =textBox5.Text;
            funcionario= ctr_Funcionario.Consultar(funcionario);
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
    }
}
