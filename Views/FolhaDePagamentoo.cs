using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ProjNP1.Controllers;
using ProjNP1.Models;

namespace ProjNP1.Views
{
    public partial class FolhaDePagamentoo : Form
    {
        Funcionario funcionario;
        Crt_FolhaDePagamento crt_folhapgt;        
        public FolhaDePagamentoo()
        {            
            crt_folhapgt = new Crt_FolhaDePagamento();
            funcionario = new Funcionario();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionario.Nome = textNome.Text;
            funcionario.CPF = Convert.ToDouble(textCPF.Text);
            funcionario.RG = Convert.ToDouble(textRG.Text);           
            funcionario.Departamento = textDep.Text;
            funcionario.Cargo = textCargo.Text;
            funcionario.Salario = Convert.ToDouble(textSalario.Text);
             crt_folhapgt.AdicionarFolhaPgt(funcionario); 
        }

        private void Atualiza_textbox()
        {

            textNome.Text = funcionario.Nome;
            textCPF.Text = Convert.ToString(funcionario.CPF);
            textRG.Text = Convert.ToString(funcionario.RG);
            textCOD.Text = Convert.ToString(funcionario.CodFunc);           
            textSalario.Text = Convert.ToString(funcionario.Salario);
            textCargo.Text = Convert.ToString(funcionario.Cargo);
            textDep.Text = Convert.ToString(funcionario.Departamento);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            funcionario.CPF = Convert.ToDouble(txtBuscar.Text);

             funcionario = crt_folhapgt.ConsultarFolhaPgt(funcionario);

            Atualiza_textbox();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
