using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal_POO
{
    public partial class Form1 : Form
    {
        List<Pessoa> Lista = new List<Pessoa>();
        Vacina v = null;
        DoacaoDeSangue ds = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVacina_Click(object sender, EventArgs e)
        {
            v = new Vacina();
            btnAddDoacao.Enabled = false;
            btnAddExameVista.Enabled = true;
            txtTipoSangue.Enabled = false;
            txtPeso.Enabled = false;
            txtTipoVacina.Enabled = true;
            txtDose.Enabled = true;
            txtNomeVacina.Enabled = true;
        }

        private void btnDoacaoDeSangue_Click(object sender, EventArgs e)
        {
            ds = new DoacaoDeSangue();
            btnAddDoacao.Enabled = true;
            btnAddExameVista.Enabled = false;
            txtTipoVacina.Enabled = false;
            txtDose.Enabled = false;
            txtTipoSangue.Enabled = true;
            txtPeso.Enabled = true;
            txtNomeVacina.Enabled = false;
        }
        private void cadastro(Pessoa p)
        {
            p.Nome = txtNome.Text;
            p.Telefone = double.Parse(txtTelefone.Text);
            p.Obj_cpf.Cpf = txtCPF.Text;
            p.Obj_data.Dia = int.Parse(txtDia.Text);
            p.Obj_data.Mes = int.Parse(txtMes.Text);
            p.Obj_data.Ano = int.Parse(txtAno.Text);
        }

        private void btnAddDoacao_Click(object sender, EventArgs e)
        {
            cadastro(ds);
            ds.TipoSangue = txtTipoSangue.Text;
            ds.Peso = double.Parse(txtPeso.Text);
            Lista.Add(ds);
            btnAddDoacao.Enabled = false;
            LimpaTextos();
        }
        private void LimpaTextos()
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtCPF.Text = "";
            txtDia.Text = "";
            txtMes.Text = "";
            txtAno.Text = "";
            txtTipoSangue.Text = "";
            txtPeso.Text = "";
            txtTipoVacina.Text = "";
            txtDose.Text = "";
        }

        private void btnAddVacina_Click(object sender, EventArgs e)
        {
            cadastro(v);
            v.NomeVacina = txtNomeVacina.Text;
            v.Tipo = txtTipoVacina.Text;
            v.Dose = int.Parse(txtDose.Text);
            Lista.Add(v);
            btnAddExameVista.Enabled = false;
            LimpaTextos();
        }

        private void btnPesquisaPorNome_Click(object sender, EventArgs e)
        {
            foreach (var item in Lista)
            {
                if (item.Nome == txtPesquisaPorNome.Text)
                    lblresultadopesquisa.Text = item.MostraDados();
            }
        }
    }
}
