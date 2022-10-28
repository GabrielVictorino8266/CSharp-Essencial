using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeClientes
{
    public class PessoaJuridica : Pessoa
    {
        //Cria os atributos da classe
        private string nome, endereco, ie, cnpj;

        public override void GravarPessoa(string nome, string endereco, string ie, string cnpj)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.ie = ie;
            this.cnpj = cnpj;
        }

        public string MostrarNome()
        {
            return nome;
        }

        public string MostrarEndereco()
        {
            return endereco;
        }

        public string MostrarIe()
        {
            return ie;
        }

        public string MostrarCnpj()
        {
            return cnpj;
        }


    }
}
