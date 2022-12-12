using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionarios
{
    public class Administrativo : Funcionario
    {
        private string nome, cargo;
        private decimal salario;

        public override string MostraCargo()
        {
           return cargo;
        }

        public override string MostraNome()
        {
            return nome;
        }

        public override decimal MostraSalario()
        {
            return salario;
        }

        public override void Salvar(string nome, string cargo, decimal salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }
    }
}
