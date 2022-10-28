using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeClientes
{
    public class PessoaJuridica:Pessoa
    {
        private string ie, cnpj;

        //Método Construtor
        public PessoaJuridica(string Nome, string Endereco, string ie, string cnpj)
        {
            base.GravarPessoa(Nome, Endereco);
            this.ie = ie;
            this.cnpj = cnpj;
        }

        //Sem método construtor (não há void)
        /*
        public void GravarPessoa(string Nome, string Endereco, string ie, string cnpj)
        {
            base.GravarPessoa(Nome, Endereco);
            this.ie = ie;
            this.cnpj = cnpj;
        }
        */
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
