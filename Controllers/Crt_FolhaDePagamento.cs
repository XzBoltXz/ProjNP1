using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjNP1.Models;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using ProjNP1.DAO;

namespace ProjNP1.Controllers
{
    class Crt_FolhaDePagamento
    {
       readonly Document doc;
        readonly Dao_FP dao_FP;
        public Crt_FolhaDePagamento()
        {
            dao_FP = new Dao_FP();
            doc = new Document(PageSize.A4);
        }
        public void AdicionarFolhaPgt(Funcionario funcionario)
        {            
            doc.SetMargins(30, 30, 30, 70);
            string caminho = @"C:\Users\Fabriciolopes\Desktop\pdf" + "relatorio.pdf";
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
            
            doc.Open();
           
            Paragraph titulo = new Paragraph();
            titulo.Font = new Font(Font.FontFamily.COURIER, 40);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Add("Folha de Pagamento\n\n");
            doc.Add(titulo);

            Paragraph paragrafo = new Paragraph("", new Font(Font.NORMAL,12));
            string conteudo = "Folha de pagamento referente ao mes trabalho \n\n";
            paragrafo.Add(conteudo);
            doc.Add(paragrafo);

            PdfPTable table = new PdfPTable(6);

            table.AddCell("NOME");
            table.AddCell("CPF");
            table.AddCell("RG");
            table.AddCell("DEPARTAMENTO");
            table.AddCell("CARGO");
            table.AddCell("SALARIO");

            table.AddCell(funcionario.Nome);
            table.AddCell(Convert.ToString(funcionario.CPF));
            table.AddCell(Convert.ToString(funcionario.RG));
            table.AddCell(funcionario.Departamento );
            table.AddCell(funcionario.Cargo);
            table.AddCell(Convert.ToString(funcionario.Salario));

            doc.Add(table);

            doc.Close();
            System.Diagnostics.Process.Start(caminho);
        }
        public Funcionario ConsultarFolhaPgt(Funcionario funcionario)
        {
            Funcionario temp = new Funcionario();
            temp = dao_FP.Consultar(funcionario);          
            return temp;
        }        
    }
}
