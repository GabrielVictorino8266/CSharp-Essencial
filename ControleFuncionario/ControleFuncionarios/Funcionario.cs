using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionarios
{
    public abstract class Funcionario
    {
        public abstract void Salvar(string nome, string cargo, decimal salario);

        public abstract string MostraNome();
        public abstract string MostraCargo();
        public abstract decimal MostraSalario();


        /*Sem a classe abstrata
         * 
         * private string nome, cargo;
        private decimal salario;

        public void Salvar(string nome, string cargo, decimal salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public string MostrarNome()
        {
            return nome;
        }

        public string MostrarCargo()
        {
            return cargo;
        }

        public decimal MostrarSalario()
        {
            return salario;
        }*/
    }
}
