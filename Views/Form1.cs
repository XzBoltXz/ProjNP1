using ProjNP1.Controllers;
using ProjNP1.Models;
using ProjNP1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ProjNP1
{
    public partial class Form1 : Form
    {
        Thread cadastro;
        Thread folhaPgto;
        public Form1()
        {
            
            InitializeComponent();
        }
       
        private void AbrirJanela(object obj)
        {
            Application.Run(new Cadastro());
            

        }

        private void AbrirJanela2(object obj)
        {
            
            Application.Run(new FolhaDePagamentoo());

        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            cadastro = new Thread(AbrirJanela);
            cadastro.SetApartmentState(ApartmentState.MTA);
            cadastro.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFolhaPgto_Click(object sender, EventArgs e)
        {
            this.Close();
            folhaPgto = new Thread(AbrirJanela2);
            folhaPgto.SetApartmentState(ApartmentState.MTA);
            folhaPgto.Start();
        }
    }
}
