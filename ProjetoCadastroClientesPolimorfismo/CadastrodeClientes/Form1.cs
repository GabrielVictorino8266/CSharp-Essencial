namespace CadastrodeClientes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        /*
        public class Pessoa
        {
            
            //Declara as variaveis gerais para Pessoa Fisica e Juridica
            private string Nome, Endereco;

            public string propriedadeNome
            {
                set { Nome = value; }
                get { return Nome; }
            }

            public string propriedadeEndereco
            {
                set { Endereco = value;  }
                get { return Endereco;  }
            }
        }

        //Classe Pessoa Física (Nome, Endereco, CPF, RG)
        public class PessoaFisica : Pessoa
        {
            public string propriedadeCpf { set; get; }
            public string propriedadeRg { set; get; }
        }

        //Classe Pessoa jurídica (Nome, Endereco, CNPJ, IE)
        public class PessoaJuridica : Pessoa
        {
            public string propriedadeCnpj { set; get; }
            public string propriedadeIe { set; get; }
        }
        */

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Quando carregar o form
            MessageBox.Show("Bem-Vindo!");
        }

        private void btnPessoaFisica_Click(object sender, EventArgs e)
        {
            pnPessoaFisica.Visible = true;
            pnPessoaJuridica.Visible = false;
        }

        private void btnPessoaJuridica_Click(object sender, EventArgs e)
        {
            pnPessoaJuridica.Visible = true;
            pnPessoaFisica.Visible = false;
        }
        

        //Botão Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Se pessoa Fisica ativo
            if (pnPessoaFisica.Visible == true) 
            {
                //Instancia Pessoa Fisica
                PessoaFisica novaPessoaFisica = new PessoaFisica();

                //Usando a sobrecarga de métodos
                novaPessoaFisica.GravarPessoa(txtbNomePF.Text, txtbEndPF.Text, txtbRG.Text, txtbCPF.Text);

                txtbInfoPF.AppendText(novaPessoaFisica.MostrarNome() + "\t");
                txtbInfoPF.AppendText(novaPessoaFisica.MostrarEndereco() + "\t");
                txtbInfoPF.AppendText(novaPessoaFisica.MostrarCpf() + "\t");
                txtbInfoPF.AppendText(novaPessoaFisica.MostrarRg() + "\r\n");

                /*Sem a sobrecarga de métodos,
                 * 
                 *   novaPessoa.propriedadeNome = txtbNomePF.Text;
                 *   novaPessoa.propriedadeEndereco = txtbEndPF.Text;
                 *   novaPessoa.propriedadeCpf = txtbCPF.Text;
                 *   novaPessoa.propriedadeRg = txtbRG.Text;
                 *
                 *   txtbInfoPF.AppendText(novaPessoa.propriedadeNome+ "\t");
                 *   txtbInfoPF.AppendText(novaPessoa.propriedadeEndereco + "\t");
                 *   txtbInfoPF.AppendText(novaPessoa.propriedadeCpf + "\t");
                 *   txtbInfoPF.AppendText(novaPessoa.propriedadeRg+ "\r\n");
                 */

            }
            else
            { //Então é pessoa Juridica Ativo

                PessoaJuridica novaPessoaJuridica = new PessoaJuridica(txtbNomePJ.Text, txtbEndPJ.Text, txtbie.Text, txtbcnpj.Text);

               // novaPessoaJuridica.GravarPessoa(txtbNomePJ.Text, txtbEndPJ.Text, txtbie.Text,txtbcnpj.Text);

                txtbInfoPJ.AppendText(novaPessoaJuridica.MostrarNome() + "\t");
                txtbInfoPJ.AppendText(novaPessoaJuridica.MostrarEndereco() + "\t");
                txtbInfoPJ.AppendText(novaPessoaJuridica.MostrarIe() + "\t");
                txtbInfoPJ.AppendText(novaPessoaJuridica.MostrarCnpj() + "\r\n");

                /*Sem o polimorfismo
                 * PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

                novaPessoaJuridica.propriedadeNome = txtbNomePJ.Text;
                novaPessoaJuridica.propriedadeEndereco = txtbEndPJ.Text;
                novaPessoaJuridica.propriedadeCnpj = txtbcnpj.Text;
                novaPessoaJuridica.propriedadeIe = txtbie.Text;

                txtbInfoPJ.AppendText(novaPessoaJuridica.propriedadeNome + "\t");
                txtbInfoPJ.AppendText(novaPessoaJuridica.propriedadeEndereco + "\t");
                txtbInfoPJ.AppendText(novaPessoaJuridica.propriedadeCnpj + "\t");
                txtbInfoPJ.AppendText(novaPessoaJuridica.propriedadeIe + "\r\n");
                */
            }
            //Após salvar e exibir no painel, os campos serão limpos para inserir novos.
            Limpar();
        }

        private void Limpar()
        {
            if (pnPessoaFisica.Visible == true)
            {//PesssoaFisica Ativo, limpa o conteúdo dos TxtBox
                txtbNomePF.Clear();
                txtbEndPF.Clear();
                txtbCPF.Clear();
                txtbRG.Clear();
            }
            else
            {//Pessoa Juridica Ativo, limpa o conteúdo dos TxtBox
                txtbNomePJ.Clear();
                txtbEndPJ.Clear();
                txtbie.Clear();
                txtbcnpj.Clear();
            }
        }
    }
}