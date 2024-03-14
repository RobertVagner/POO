using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_POO
{
    internal class DoacaoDeSangue : Pessoa
    {
        private string info1;
        private string info2;
        private double ValorExame;

        public string Info1 { get => info1; set => info1 = value; }
        public string Info2 { get => info2; set => info2 = value; }

        override public string MostraDados()
        {
            return base.MostraDados() + "\n" + "Valor do exame de Vista: " + Valor();
        }
        override public double Valor()
        {
            if (Condicao)
                return ValorExame;
            return ValorExame * 1.5;
        }
    }
}
