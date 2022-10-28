namespace ProjetoCalculoMedia
{
    public partial class frmCalculoMedia : Form
    {
        public frmCalculoMedia()
        {
            InitializeComponent();
        }

        private void frmCalculoMedia_Load(object sender, EventArgs e)
        {
            //Ao carregar o Form.
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtbAproveitamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Calculando a Media Final
            double nota1, nota2, notaTrabalho;
            
            nota1 = Convert.ToDouble(txtNota1.Text) * Convert.ToDouble(cmbNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text) * Convert.ToDouble(cmbNota2.Text);
            notaTrabalho = double.Parse(txtTrabalho.Text) * double.Parse(cmbNotaTrabalho.Text)  ;

            double Media = nota1 + nota2 + notaTrabalho;

            txtbMediaFinal.Text = Media.ToString();

            //Variaveis de Quantidade de Faltas e Aulas
            double QtdeAulas, QtdeFaltas;

            //Converte a informação das caixas de textos de Qtdes. para números (double)
            QtdeFaltas = double.Parse(txtbQtdeFaltas.Text);
            QtdeAulas = double.Parse(txtbQtdeAulas.Text);

            //Cálculo da presença do aluno
            double PorcentagemPresenca = 100 - ((QtdeFaltas/ QtdeAulas) * 100);

            //Realiza a conta do aproveitamento do aluno e converte o valor em string para ser exibido em txtbAproveitamento.
            txtbAproveitamento.Text = Convert.ToString(((Media *10) + (PorcentagemPresenca)) / 2) + "%";

            if (txtbRecuperacao.Text == "")
            {
                if (Media >= Convert.ToDouble(numNotaCorte.Value) && PorcentagemPresenca >= 75)
                {
                    lblSituacao.Text = "Aprovado";
                    lblSituacao.ForeColor = Color.Green;
                }
                else 
                    if (Media <= 2.5 || PorcentagemPresenca < 75)
                    {
                        lblSituacao.Text = "Reprovado";
                        lblSituacao.ForeColor = Color.Red;
                    }
                    else 
                    {
                        lblSituacao.Text = "Recuperação";
                        lblSituacao.ForeColor = Color.Red;
                    }
            }
            else
            {
                Media = (Media + Convert.ToDouble(txtbRecuperacao.Text) / 2);

                txtbAproveitamento.Text = Convert.ToString(((Media * 10) + (PorcentagemPresenca)) / 2) + "%";

                if (Media >= 5)
                {
                    lblSituacao.Text = "Aprovado";
                    lblSituacao.ForeColor = Color.Green;
                }

                else
                {
                    lblSituacao.Text = "Reprovado";
                    lblSituacao.ForeColor = Color.Red;
                }

                txtbMediaFinal.Text = Media.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            // txtbAproveitamento.Text = "";
            // txtbMediaFinal.Text = "";
            //txtbQtdeAulas.Text = "";
            // txtbQtdeFaltas.Text = "";
            // txtNota1.Text = "";
            // txtNota2.Text = "";
            // txtTrabalho.Text = "";
            // txtbRecuperacao.Text = "";
            // cmbNota2.Items.Clear();
            // cmbNota1.Items.Clear();
            //  cmbNotaTrabalho.Items.Clear();
            //  numNotaCorte.Value = 5;

            lblSituacao.Text = "";
            //É igual receber vazio como o lblSituacao
            txtbRecuperacao.Text = string.Empty;

            foreach(Control Componente in this.Controls)
            {
                if(Componente is TextBox)
                {
                    (Componente as TextBox).Clear();
                }
                else
                    if(Componente is ComboBox)
                {
                    (Componente as ComboBox).SelectedIndex = -1;
                }
                else 
                    if(Componente is NumericUpDown)
                {
                    (Componente as NumericUpDown).Value = 5;
                }
            }
        }
    }
}