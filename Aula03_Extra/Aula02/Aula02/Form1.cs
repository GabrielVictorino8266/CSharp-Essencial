using Aula03;

namespace Aula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkB_PessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        //Verify if checkbox Pessoa Fisica is marked or not.
        private void chkB_PessoaFisica_CheckStateChanged(object sender, EventArgs e)
        {

            if (chkB_PessoaFisica.Checked == true)
                {
                    pnlPessoaFisica.Visible = true;
                }
            else
                {
                    pnlPessoaFisica.Visible=false;
                };
        }

        //Verify if checkbox Pessoa Juridica is marked or not.
        private void chkB_PessoaJuridica_CheckedChanged(object sender, EventArgs e)

        {
            if(chkB_PessoaJuridica.Checked == true)
                {
                    pnlPessoaJuridica.Visible = true;
                }
            else
                {
                    pnlPessoaJuridica.Visible = false;
                }
        }

        private void btnTela2_Click(object sender, EventArgs e)
        {
            Tela2 segundaTela = new Tela2();
            segundaTela.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem-vindo ao Meu Primeiro Programa em C# .");
            btnTabuada.Enabled = true;
            btnTela2.Enabled = true;
            btnImagem.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisualizadorImagens Tela3 = new VisualizadorImagens();
            Tela3.ShowDialog();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            frmTabuada TelaTabuada = new frmTabuada();
            TelaTabuada.ShowDialog();
        }
    }
}