
namespace ProjNP1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFolhaPgto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(307, 138);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(173, 93);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastrar Funcionarios";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Gestão de Folha de Pagamento";
            // 
            // btnFolhaPgto
            // 
            this.btnFolhaPgto.Location = new System.Drawing.Point(307, 248);
            this.btnFolhaPgto.Name = "btnFolhaPgto";
            this.btnFolhaPgto.Size = new System.Drawing.Size(173, 93);
            this.btnFolhaPgto.TabIndex = 2;
            this.btnFolhaPgto.Text = "Gerar Folha de Pagamento";
            this.btnFolhaPgto.UseVisualStyleBackColor = true;
            this.btnFolhaPgto.Click += new System.EventHandler(this.btnFolhaPgto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFolhaPgto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFolhaPgto;
        private System.Windows.Forms.Button button1;
    }
}

