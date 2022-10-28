using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrodeClientes
{
    public abstract class Pessoa
    {//Uma classe abstrata é só um conceito
        public abstract void GravarPessoa(string nome, string endereco, string documento1, string documento2);
    }
}
