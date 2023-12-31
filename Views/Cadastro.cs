﻿using ProjNP1.Controllers;
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
        Endereco endereco;        
        Telefone telefone;        
        public Cadastro()
        {
            funcionario = new Funcionario();
            ctr_Funcionario = new Ctr_Funcionario();
            financeiro = new Financeiro();           
            endereco = new Endereco();            
            telefone = new Telefone();            
            InitializeComponent();
        }       
        private void btn_Cadastrar_Click_1(object sender, EventArgs e)
        {            
            funcionario.Nome = textBox1.Text;
            funcionario.CPF = Convert.ToDouble(maskedTextBox1.Text);
            funcionario.RG = Convert.ToDouble(maskedTextBox2.Text);
            funcionario.End.Bairro = textBox6.Text;
            funcionario.End.Rua = textBox7.Text;
            funcionario.End.CEP = Convert.ToInt32(maskedTextBox3.Text);
            funcionario.End.NumCasa  = Convert.ToInt32(textBox9.Text);
            funcionario.End.Complemento = textBox16.Text;
            funcionario.Departamento = textBox12.Text;
            funcionario.Cargo = textBox11.Text;
            funcionario.Salario = Convert.ToDouble(textBox10.Text);
            funcionario.DataAdmissao = Convert.ToDateTime(maskedTextBox5.Text);
            funcionario.End.DDD = textBox15.Text;
            funcionario.End.Numero = Convert.ToInt32(maskedTextBox4.Text);
            
            ctr_Funcionario.Adicionar(funcionario);
            MessageBox.Show("Funcionario cadastrado!");
            textBox1.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            maskedTextBox3.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            maskedTextBox5.Clear();
            maskedTextBox4.Clear();
            textBox15.Clear();
            textBox16.Clear();
        }       
        private void atualiza_textbox()
        {
            textBox1.Text = funcionario.Nome;
            maskedTextBox1.Text = Convert.ToString(funcionario.CPF);
            maskedTextBox2.Text = Convert.ToString(funcionario.RG);
            textBox4.Text = Convert.ToString(funcionario.CodFunc);
            textBox6.Text = Convert.ToString(funcionario.End.Bairro);
            textBox7.Text = Convert.ToString(funcionario.End.Rua);
            maskedTextBox3.Text = Convert.ToString(funcionario.End.CEP);
            textBox9.Text = Convert.ToString(funcionario.End.NumCasa);
            textBox10.Text = Convert.ToString(funcionario.Salario);
            textBox11.Text = Convert.ToString(funcionario.Cargo);
            textBox12.Text = Convert.ToString(funcionario.Departamento);
            maskedTextBox5.Text = Convert.ToString(funcionario.DataAdmissao);
            maskedTextBox4.Text = Convert.ToString(funcionario.End.Numero);
            textBox15.Text = Convert.ToString(funcionario.End.DDD);
            textBox16.Text = Convert.ToString(funcionario.End.Complemento);
        }
        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            funcionario.CPF = Convert.ToDouble(textBox5.Text);           

            funcionario = ctr_Funcionario.Consultar(funcionario);

            atualiza_textbox();
        }
        private void Editar_Click(object sender, EventArgs e)
        {
            funcionario.Nome = textBox1.Text;
            funcionario.CPF = Convert.ToInt64(maskedTextBox1.Text);
            funcionario.RG = Convert.ToDouble(maskedTextBox2.Text);
            funcionario.CodFunc = Convert.ToInt32(textBox4.Text);
            funcionario.End.Bairro = textBox6.Text;
            funcionario.End.Rua = Convert.ToString(textBox7.Text);
            funcionario.End.CEP = Convert.ToInt32(maskedTextBox3.Text);
            funcionario.End.NumCasa = Convert.ToInt32(textBox9.Text);
            funcionario.Salario = Convert.ToDouble(textBox10.Text);
            funcionario.Cargo = textBox11.Text;
            funcionario.Departamento = textBox12.Text;
            funcionario.DataAdmissao = Convert.ToDateTime(maskedTextBox5.Text);
            funcionario.End.Numero = Convert.ToInt32(maskedTextBox4.Text);
            funcionario.End.DDD = Convert.ToString(textBox15.Text);
            funcionario.End.Complemento = Convert.ToString(textBox16.Text);

            ctr_Funcionario.Editar(funcionario);
            MessageBox.Show("Cadastro atualizado!");
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            funcionario.CPF = Convert.ToDouble(textBox5.Text);

            ctr_Funcionario.Excluir(funcionario);
            MessageBox.Show("Funcionario excluido!");
            textBox1.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            maskedTextBox3.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            maskedTextBox5.Clear();
            maskedTextBox4.Clear();
            textBox15.Clear();
            textBox16.Clear();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            maskedTextBox3.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            maskedTextBox5.Clear();
            maskedTextBox4.Clear();
            textBox15.Clear();
            textBox16.Clear();
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
