using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionarios
{
    public class Designer : IFuncionario
    {
        private string nome, cargo;
        private decimal salario;

        public string MostraCargo()
        {
            return cargo;
        }

        public string MostraNome()
        {
            return nome;
        }

        public decimal MostraSalario()
        {
            return salario;
        }

        public void Salvar(string nome, string cargo, decimal salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }
    }
}
