using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFuncionario.Funcionario
{
    internal class Funcionarios
    {

        private int codigo;
        private string nome;
        private int diasTrabalhados;
        private double salarioDiario;

        public Funcionarios(int codigo, string nome, int diasTrabalhados, double salarioDiario)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.diasTrabalhados = diasTrabalhados;
            this.salarioDiario = salarioDiario;
        }


        public double getSalarioDiario()
        {
            return salarioDiario;
        }

        public int getCodigo()
        {
            return codigo;
        }

        public string getNome()
        {
            return nome;
        }

        public int getDiasTrabalhados()
        {
            return diasTrabalhados;
        }

        public double salarioMensal()
        {
            return getSalarioDiario() * getDiasTrabalhados();
        }


    }
}
