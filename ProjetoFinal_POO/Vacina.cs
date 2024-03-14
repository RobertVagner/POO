using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_POO
{
    internal class Vacina:Pessoa
    {
        private int dose;
        private string tipo;
        private string nomeVacina;
        private double valorVacina;

        public int Dose { get => dose; set => dose = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string NomeVacina { get => nomeVacina; set => nomeVacina = value; }
        public double ValorVacina { get => valorVacina; set => valorVacina = value; }
        

        override public string MostraDados()
        {
            return base.MostraDados() + "\n" + "Nome da Vacina: " + NomeVacina + "\n" + "Vacina: " + Tipo + " - " + Dose + "ª Dose" + "\n" + "Valor da Vacina: " + Valor();
        }
        override public double Valor()
        {
            if(Condicao)
                return ValorVacina;
            return ValorVacina * 1.2;
        }
    }
}
