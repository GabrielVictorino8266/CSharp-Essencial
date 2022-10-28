namespace CadastrodeClientes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

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
            if (pnPessoaFisica.Visible == true)
            {
                PessoaFisica novaPessoaFisica = new PessoaFisica();

                novaPessoaFisica.GravarPessoa(txtbNomePF.Text, txtbEndPF.Text, txtbRG.Text, txtbCPF.Text);
                txtbInfoPF.AppendText(novaPessoaFisica.MostrarNome() + "\t");
                txtbInfoPF.AppendText(novaPessoaFisica.MostrarEndereco() + "\t");
                txtbInfoPF.AppendText(novaPessoaFisica.MostrarDocumento1() + "\t");
                txtbInfoPF.AppendText(novaPessoaFisica.MostrarDocumento2() + "\r\n");
            }
            else
            {
                PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

                novaPessoaJuridica.GravarPessoa(txtbNomePJ.Text, txtbEndPJ.Text, txtbie.Text, txtbcnpj.Text);
                txtbInfoPJ.AppendText(novaPessoaJuridica.MostrarNome() + "\t");
                txtbInfoPJ.AppendText(novaPessoaJuridica.MostrarEndereco() + "\t");
                txtbInfoPJ.AppendText(novaPessoaJuridica.MostrarIe() + "\t");
                txtbInfoPJ.AppendText(novaPessoaJuridica.MostrarCnpj() + "\r\n");
            }
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