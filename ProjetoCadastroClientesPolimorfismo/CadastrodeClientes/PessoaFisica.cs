using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeClientes
{
    public class PessoaFisica : Pessoa
    {
        private string rg, cpf;

        public void GravarPessoa(string Nome, string Endereco, string rg, string cpf)
        {
            //base. é usado para acessar privates de outras classes (não os atributos, mas os métodos).
            base.GravarPessoa(Nome, Endereco);
            this.rg = rg;
            this.cpf = cpf;
        }

        public string MostrarRg()
        {
            return rg;
        }

        public string MostrarCpf()
        {
            return cpf;
        }
    }
}
