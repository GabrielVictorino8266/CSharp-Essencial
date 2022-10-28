using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeClientes
{
    public class Pessoa
    {
        private string Nome, Endereco;//Cria os atributos das classes

        //O void indica que o método não retornará nenhum valor.
        public void GravarPessoa(string Nome, string Endereco)//Cria um método para gravar nome e endereço.
        {
            this.Nome = Nome;//O atributo nome recebe values do parâmetro nome.
            this.Endereco = Endereco;//O atributo endereco recebe values do parâmetro endereco;
        }

        public string MostrarNome()//Método que exibe o texto do atributo nome;
        {
            return Nome;
        }

        public string MostrarEndereco()//Método que exibe o texto do
        {
            return Endereco;
        }
    }
}
