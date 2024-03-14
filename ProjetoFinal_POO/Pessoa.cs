using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal_POO
{
    abstract internal class Pessoa
    {
        protected TCPF obj_cpf;
        protected TData obj_data;
        private string nome;
        private double telefone;
        private bool condicao;

        public Pessoa()
        {
            Obj_cpf = new TCPF();
            Obj_data = new TData();
        }

        public string Nome { get => nome; set => nome = value; }
        public double Telefone { get => telefone; set => telefone = value; }
        public TCPF Obj_cpf { get => obj_cpf; set => obj_cpf = value; }
        public TData Obj_data { get => obj_data; set => obj_data = value; }
        public bool Condicao { get => condicao; set => condicao = value; }

        public string Valcpf()
        {
            string auxcpf = Obj_cpf.Cpf;
            if (Obj_cpf.ValidaCpf(auxcpf) == false)
                return "Cpf inválido";
            else
                return "Cpf válido";
        }
        virtual public string MostraDados()
        {
            return "Nome: " + Nome + "\n" + "Telefone: " + Telefone + "\n" + Obj_cpf.MostraCPF() + "\n" + "Status: " + Valcpf() + "\n" + "Data de Nascimento: " + Obj_data.BigData();
        }

        abstract public double Valor();
    }
}
