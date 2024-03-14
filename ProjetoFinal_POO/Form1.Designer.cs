namespace ProjetoFinal_POO
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
            this.btnVacina = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExameDeVista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTipoSangue = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtTipoVacina = new System.Windows.Forms.TextBox();
            this.txtDose = new System.Windows.Forms.TextBox();
            this.btnPesquisaPorNome = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPesquisaPorNome = new System.Windows.Forms.TextBox();
            this.lblresultadopesquisa = new System.Windows.Forms.Label();
            this.btnAddExameVista = new System.Windows.Forms.Button();
            this.btnAddDoacao = new System.Windows.Forms.Button();
            this.lblNomeVacina = new System.Windows.Forms.Label();
            this.txtNomeVacina = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVacina
            // 
            this.btnVacina.Location = new System.Drawing.Point(96, 42);
            this.btnVacina.Name = "btnVacina";
            this.btnVacina.Size = new System.Drawing.Size(343, 32);
            this.btnVacina.TabIndex = 0;
            this.btnVacina.Text = "Vacina";
            this.btnVacina.UseVisualStyleBackColor = true;
            this.btnVacina.Click += new System.EventHandler(this.btnVacina_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(158, 155);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // btnExameDeVista
            // 
            this.btnExameDeVista.Location = new System.Drawing.Point(96, 93);
            this.btnExameDeVista.Name = "btnExameDeVista";
            this.btnExameDeVista.Size = new System.Drawing.Size(343, 32);
            this.btnExameDeVista.TabIndex = 3;
            this.btnExameDeVista.Text = "Exame de Vista";
            this.btnExameDeVista.UseVisualStyleBackColor = true;
            this.btnExameDeVista.Click += new System.EventHandler(this.btnDoacaoDeSangue_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(181, 196);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(257, 22);
            this.txtTelefone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(144, 230);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(294, 22);
            this.txtCPF.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mês:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ano:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(134, 356);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(57, 22);
            this.txtDia.TabIndex = 13;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(246, 356);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(71, 22);
            this.txtMes.TabIndex = 14;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(367, 356);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(72, 22);
            this.txtAno.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tipo de Sangue:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Peso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 506);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tipo de Vacina:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(94, 538);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Dose da Vacina:";
            // 
            // txtTipoSangue
            // 
            this.txtTipoSangue.Location = new System.Drawing.Point(220, 408);
            this.txtTipoSangue.Name = "txtTipoSangue";
            this.txtTipoSangue.Size = new System.Drawing.Size(218, 22);
            this.txtTipoSangue.TabIndex = 20;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(146, 439);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(293, 22);
            this.txtPeso.TabIndex = 21;
            // 
            // txtTipoVacina
            // 
            this.txtTipoVacina.Location = new System.Drawing.Point(216, 503);
            this.txtTipoVacina.Name = "txtTipoVacina";
            this.txtTipoVacina.Size = new System.Drawing.Size(223, 22);
            this.txtTipoVacina.TabIndex = 22;
            // 
            // txtDose
            // 
            this.txtDose.Location = new System.Drawing.Point(222, 535);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(218, 22);
            this.txtDose.TabIndex = 23;
            // 
            // btnPesquisaPorNome
            // 
            this.btnPesquisaPorNome.Location = new System.Drawing.Point(644, 42);
            this.btnPesquisaPorNome.Name = "btnPesquisaPorNome";
            this.btnPesquisaPorNome.Size = new System.Drawing.Size(410, 45);
            this.btnPesquisaPorNome.TabIndex = 24;
            this.btnPesquisaPorNome.Text = "Pesquisar por Nome";
            this.btnPesquisaPorNome.UseVisualStyleBackColor = true;
            this.btnPesquisaPorNome.Click += new System.EventHandler(this.btnPesquisaPorNome_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(641, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Digite o Nome:";
            // 
            // txtPesquisaPorNome
            // 
            this.txtPesquisaPorNome.Location = new System.Drawing.Point(757, 118);
            this.txtPesquisaPorNome.Name = "txtPesquisaPorNome";
            this.txtPesquisaPorNome.Size = new System.Drawing.Size(297, 22);
            this.txtPesquisaPorNome.TabIndex = 26;
            // 
            // lblresultadopesquisa
            // 
            this.lblresultadopesquisa.AutoSize = true;
            this.lblresultadopesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultadopesquisa.Location = new System.Drawing.Point(641, 159);
            this.lblresultadopesquisa.Name = "lblresultadopesquisa";
            this.lblresultadopesquisa.Size = new System.Drawing.Size(158, 18);
            this.lblresultadopesquisa.TabIndex = 27;
            this.lblresultadopesquisa.Text = "Resultado da pesquisa";
            // 
            // btnAddExameVista
            // 
            this.btnAddExameVista.Enabled = false;
            this.btnAddExameVista.Location = new System.Drawing.Point(96, 593);
            this.btnAddExameVista.Name = "btnAddExameVista";
            this.btnAddExameVista.Size = new System.Drawing.Size(343, 23);
            this.btnAddExameVista.TabIndex = 28;
            this.btnAddExameVista.Text = "Adicionar Exame de Vista na Lista";
            this.btnAddExameVista.UseVisualStyleBackColor = true;
            this.btnAddExameVista.Click += new System.EventHandler(this.btnAddVacina_Click);
            // 
            // btnAddDoacao
            // 
            this.btnAddDoacao.Enabled = false;
            this.btnAddDoacao.Location = new System.Drawing.Point(96, 633);
            this.btnAddDoacao.Name = "btnAddDoacao";
            this.btnAddDoacao.Size = new System.Drawing.Size(343, 23);
            this.btnAddDoacao.TabIndex = 29;
            this.btnAddDoacao.Text = "Adicionar Doador na Lista";
            this.btnAddDoacao.UseVisualStyleBackColor = true;
            this.btnAddDoacao.Click += new System.EventHandler(this.btnAddDoacao_Click);
            // 
            // lblNomeVacina
            // 
            this.lblNomeVacina.AutoSize = true;
            this.lblNomeVacina.Location = new System.Drawing.Point(94, 474);
            this.lblNomeVacina.Name = "lblNomeVacina";
            this.lblNomeVacina.Size = new System.Drawing.Size(126, 16);
            this.lblNomeVacina.TabIndex = 30;
            this.lblNomeVacina.Text = "Nome da Vacina:";
            // 
            // txtNomeVacina
            // 
            this.txtNomeVacina.Location = new System.Drawing.Point(226, 471);
            this.txtNomeVacina.Name = "txtNomeVacina";
            this.txtNomeVacina.Size = new System.Drawing.Size(213, 22);
            this.txtNomeVacina.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 732);
            this.Controls.Add(this.txtNomeVacina);
            this.Controls.Add(this.lblNomeVacina);
            this.Controls.Add(this.btnAddDoacao);
            this.Controls.Add(this.btnAddExameVista);
            this.Controls.Add(this.lblresultadopesquisa);
            this.Controls.Add(this.txtPesquisaPorNome);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnPesquisaPorNome);
            this.Controls.Add(this.txtDose);
            this.Controls.Add(this.txtTipoVacina);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtTipoSangue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExameDeVista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnVacina);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVacina;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExameDeVista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTipoSangue;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtTipoVacina;
        private System.Windows.Forms.TextBox txtDose;
        private System.Windows.Forms.Button btnPesquisaPorNome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPesquisaPorNome;
        private System.Windows.Forms.Label lblresultadopesquisa;
        private System.Windows.Forms.Button btnAddExameVista;
        private System.Windows.Forms.Button btnAddDoacao;
        private System.Windows.Forms.Label lblNomeVacina;
        private System.Windows.Forms.TextBox txtNomeVacina;
    }
}

