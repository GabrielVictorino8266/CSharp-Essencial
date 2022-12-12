namespace ProjetoFinalCalculadora
{
    
    public partial class frmPrincipal : Form
    {
        //Declarando vari�veis necess�rias.
        double valorVisor = 0, valorAnterior = 0;
        string operacao = "";
        bool primeiraOperacao = true, botaoIgual = false;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ClicouBotao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0" || botaoIgual == true)
            {
                txtVisor.Clear();
                botaoIgual = false;
            }

            
            Button botaoAcionado = (Button)sender;

            switch (botaoAcionado.Name)
            {
                case "btn1":
                    txtVisor.Text += "1";
                    break;

                case "btn2":
                    txtVisor.Text += "2";
                    break;

                case "btn3":
                    txtVisor.Text += "3";
                    break;

                case "btn4":
                    txtVisor.Text += "4";
                    break;

                case "btn5":
                    txtVisor.Text += "5";
                    break;

                case "btn6":
                    txtVisor.Text += "6";
                    break;

                case "btn7":
                    txtVisor.Text += "7";
                    break;

                case "btn8":
                    txtVisor.Text += "8";
                    break;

                case "btn9":
                    txtVisor.Text += "9";
                    break;

                case "btn0":
                    txtVisor.Text += "0";
                    break;

                case "btnVirgula":
                    if (txtVisor.Text == "")
                    {
                        txtVisor.Text += "0,";
                    }
                    else
                    {
                        txtVisor.Text += ",";
                    }
                    break;
                   
                default:
                   
                    break;
            }

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //Se for a primeira opera��o
            if (primeiraOperacao) {

                valorAnterior = Convert.ToDouble(txtVisor.Text);

                //Se o bot�o igual n�o for pressionado.
                if (botaoIgual == false)
                {
                    //Adiciona o valor anterior ao hist�rico
                    txtHistorico.Text += txtVisor.Text;
                }
                //limpa o visor, permitindo recceber o pr�ximo n�mero.
                txtVisor.Clear();
                //Define o tipo de opera��o para a variavel operacao
                operacao = "+";
                primeiraOperacao = false;
            }
            else
            {//N�o ser� a primeira opera��o, ent�o:
                valorVisor = Convert.ToDouble(txtVisor.Text);

                //Indica no hist�rico a opera��o:
                txtHistorico.Text += operacao + txtVisor.Text;

                //Mostra o resultado
                txtVisor.Text = Convert.ToString(valorAnterior + valorVisor);

                operacao = "+";
                txtHistorico.Text += "=" + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Se for a primeira opera��o
            if (primeiraOperacao)
            {

                valorAnterior = Convert.ToDouble(txtVisor.Text);

                //Se o bot�o igual n�o for pressionado.
                if (botaoIgual == false)
                {
                    //Adiciona o valor anterior ao hist�rico
                    txtHistorico.Text += txtVisor.Text;
                }
                //limpa o visor, permitindo recceber o pr�ximo n�mero.
                txtVisor.Clear();
                //Define o tipo de opera��o para a variavel operacao
                operacao = "*";
                primeiraOperacao = false;
            }
            else
            {//N�o ser� a primeira opera��o, ent�o:
                valorVisor = Convert.ToDouble(txtVisor.Text);

                //Indica no hist�rico a opera��o:
                txtHistorico.Text += operacao + txtVisor.Text;

                //Mostra o resultado
                txtVisor.Text = Convert.ToString(valorAnterior * valorVisor);

                operacao = "*";
                txtHistorico.Text += "=" + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            //Se for a primeira opera��o
            if (primeiraOperacao)
            {

                valorAnterior = Convert.ToDouble(txtVisor.Text);

                //Se o bot�o igual n�o for pressionado.
                if (botaoIgual == false)
                {
                    //Adiciona o valor anterior ao hist�rico
                    txtHistorico.Text += txtVisor.Text;
                }
                //limpa o visor, permitindo recceber o pr�ximo n�mero.
                txtVisor.Clear();
                //Define o tipo de opera��o para a variavel operacao
                operacao = "-";
                primeiraOperacao = false;
            }
            else
            {//N�o ser� a primeira opera��o, ent�o:
                valorVisor = Convert.ToDouble(txtVisor.Text);

                //Indica no hist�rico a opera��o:
                txtHistorico.Text += operacao + txtVisor.Text;

                //Mostra o resultado
                txtVisor.Text = Convert.ToString(valorAnterior - valorVisor);

                operacao = "-";
                txtHistorico.Text += "=" + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //Se for a primeira opera��o
            if (primeiraOperacao)
            {

                valorAnterior = Convert.ToDouble(txtVisor.Text);

                //Se o bot�o igual n�o for pressionado.
                if (botaoIgual == false)
                {
                    //Adiciona o valor anterior ao hist�rico
                    txtHistorico.Text += txtVisor.Text;
                }
                //limpa o visor, permitindo recceber o pr�ximo n�mero.
                txtVisor.Clear();
                //Define o tipo de opera��o para a variavel operacao
                operacao = "/";
                primeiraOperacao = false;
            }
            else
            {//N�o ser� a primeira opera��o, ent�o:
                valorVisor = Convert.ToDouble(txtVisor.Text);

                //Indica no hist�rico a opera��o:
                txtHistorico.Text += operacao + txtVisor.Text;

                //Mostra o resultado
                txtVisor.Text = Convert.ToString(valorAnterior / valorVisor);

                operacao = "/";
                txtHistorico.Text += "=" + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valorVisor = Convert.ToDouble(txtVisor.Text);

            txtHistorico.Text += operacao + txtVisor.Text;

            txtVisor.Text = Convert.ToString(Calculo());

            txtHistorico.Text += "=" + txtVisor.Text;

            valorAnterior = Convert.ToDouble(txtVisor.Text);

            botaoIgual = true;
            primeiraOperacao = true;
        }

        //M�todo Calculo()
        public double Calculo()
        {
            //Switch Case para verificar a opera��o
            switch (operacao) { 
            case "+":
                valorAnterior = valorAnterior + valorVisor;
                break;

            case "*":
               valorAnterior = valorAnterior * valorVisor;
               break;

            case "/":
                valorAnterior = valorAnterior / valorVisor;
                break;

            case "-":
                valorAnterior = valorAnterior - valorVisor;
                break;

            default:
                break;
            }

            return valorAnterior;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            txtHistorico.Clear();
            valorVisor = 0;
            valorAnterior = 0;

            operacao = "";
            primeiraOperacao = true;
            botaoIgual = false;
        
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);//C�digo para apagar um carectere anterior.
        }
    }
}