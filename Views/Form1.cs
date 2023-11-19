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

namespace ProjNP1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            
            InitializeComponent();
        }
       
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
        }
    }
}
