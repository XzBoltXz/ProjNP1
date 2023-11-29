
namespace ProjNP1.Views
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.telefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefoneTableAdapter = new ProjNP1.DB_PIMDataSetTableAdapters.TelefoneTableAdapter();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "CPF";
            // 
            // textBox5
            // 
            this.textBox5.AccessibleName = "";
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Location = new System.Drawing.Point(673, 72);
            this.textBox5.MaxLength = 11;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(208, 29);
            this.textBox5.TabIndex = 27;
            this.textBox5.Tag = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 36);
            this.button2.TabIndex = 26;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 25;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Editar_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(110, 29);
            this.textBox4.TabIndex = 24;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(887, 70);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(108, 36);
            this.btn_Consultar.TabIndex = 23;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Codigo";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(136, 72);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(112, 36);
            this.btn_Cadastrar.TabIndex = 18;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 29);
            this.textBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 39);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cadastro de Funcionarios";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(515, 176);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(212, 29);
            this.textBox6.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Bairro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(510, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Rua";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(515, 257);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(212, 29);
            this.textBox7.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(510, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "CEP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(728, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "N°";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(733, 176);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(212, 29);
            this.textBox9.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(248, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 25);
            this.label11.TabIndex = 43;
            this.label11.Text = "Salario";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(253, 324);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(212, 29);
            this.textBox10.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 25);
            this.label12.TabIndex = 41;
            this.label12.Text = "Cargo";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(253, 257);
            this.textBox11.MaxLength = 255;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(212, 29);
            this.textBox11.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(248, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 25);
            this.label13.TabIndex = 39;
            this.label13.Text = "Departamento";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(253, 176);
            this.textBox12.MaxLength = 255;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(212, 29);
            this.textBox12.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(248, 360);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 25);
            this.label14.TabIndex = 46;
            this.label14.Text = "Data Admissao";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 362);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 25);
            this.label15.TabIndex = 50;
            this.label15.Text = "Numero";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 360);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 25);
            this.label16.TabIndex = 48;
            this.label16.Text = "DDD";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(8, 390);
            this.textBox15.MaxLength = 2;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(47, 29);
            this.textBox15.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(510, 358);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 25);
            this.label17.TabIndex = 52;
            this.label17.Text = "Complemento";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(515, 388);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(212, 29);
            this.textBox16.TabIndex = 51;
            // 
            // telefoneTableAdapter
            // 
            this.telefoneTableAdapter.ClearBeforeFill = true;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(875, 377);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(120, 40);
            this.BtnVoltar.TabIndex = 53;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(490, 72);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(112, 36);
            this.Btn_Limpar.TabIndex = 54;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(8, 259);
            this.maskedTextBox1.Mask = "000.000.000-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(208, 29);
            this.maskedTextBox1.TabIndex = 55;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(8, 325);
            this.maskedTextBox2.Mask = "00.000.000-0";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(208, 29);
            this.maskedTextBox2.TabIndex = 56;
            this.maskedTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(515, 324);
            this.maskedTextBox3.Mask = "00000-000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(208, 29);
            this.maskedTextBox3.TabIndex = 57;
            this.maskedTextBox3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(61, 390);
            this.maskedTextBox4.Mask = "00000-0000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(155, 29);
            this.maskedTextBox4.TabIndex = 58;
            this.maskedTextBox4.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(253, 387);
            this.maskedTextBox5.Mask = "00/00/0000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(208, 29);
            this.maskedTextBox5.TabIndex = 59;
            this.maskedTextBox5.ValidatingType = typeof(System.DateTime);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 440);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.textBox1);
            this.Name = "Cadastro";
            this.Text = "Cadastro de Funcionarios";
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox15;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.BindingSource telefoneBindingSource;
        private DB_PIMDataSetTableAdapters.TelefoneTableAdapter telefoneTableAdapter;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
    }
}