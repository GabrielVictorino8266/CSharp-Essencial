using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionarios
{
    public interface IFuncionario
    {
        void Salvar(string nome, string cargo, decimal salario);

        string MostraNome();
        string MostraCargo();
        decimal MostraSalario();
    }
}
