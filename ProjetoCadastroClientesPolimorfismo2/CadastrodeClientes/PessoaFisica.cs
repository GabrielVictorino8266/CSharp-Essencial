using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeClientes
{
    public class PessoaFisica : Pessoa
    {
        private string nome, endereco, rg, cpf;

        //o uso de override o torna concreto
        public override void GravarPessoa(string nome, string endereco, string documento1, string documento2)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.rg = documento1;
            this.cpf = documento2;
        }

        //Os métodos pertencem somente à PessoaFísica.
        public string MostrarNome()
        {
            return nome;
        }
        public string MostrarEndereco()
        {
            return endereco;
        }
        public string MostrarDocumento1()
        {
            return rg;
        }
        public string MostrarDocumento2()
        {
            return cpf;
        }
    }
}
