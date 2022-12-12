using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        //variáveis globais
        double valorVisor = 0, valorAnterior = 0;
        string operacao = "";
        bool primeiraOperacao = true, botaoIgual = false;


        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void ClicouBotao_Click(object sender, EventArgs e) //Evento Click dos botões
        {
            if (txtVisor.Text == "0" || botaoIgual == true) //Se o visor estiver com o número 0 ou botaoIgual estiver como true
            {
                txtVisor.Clear();    //É para limpá-lo
                botaoIgual = false; //e deixa a variável botaoIgual como false
            }

            Button botaoAcionado = (Button)sender; //O objeto botão que foi clicado será carregado no botaoAcionado  

            switch (botaoAcionado.Name) //Verifica o nome do botão acionado
            {
                case "btn1":                    //Caso seja btn1
                    txtVisor.Text += "1";       //A propriedade Text do visor receberá o número 1
                    break;                      //Parar a verificação

                case "btn2":                    //Os próximos casos verificam qual foi o botão acionado e envia para a
                    txtVisor.Text += "2";       //propriedade Text do mesmo, o número relacionado a ele.
                    break;                      //Após a detecção de qual botão foi acionado, a verificação é finalizada

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

        private void btnLimpar_Click(object sender, EventArgs e) //Botão responsável por limpar os campos e os atributos, "resentando" as configurações da calculadora
        {
            txtVisor.Clear();
            txtHistorico.Clear();
            valorAnterior = 0;
            valorVisor = 0;

            operacao = "";
            primeiraOperacao = true;
            botaoIgual = false;
        }

        private void btnBackspace_Click(object sender, EventArgs e) //Botão responsável por apagar o último número
        {
            txtVisor.Text = txtVisor.Text.Remove(txtVisor.Text.Length - 1);
        }

        private void btnAdicao_Click(object sender, EventArgs e) //Botão responsável por realizar somas
        {
            if (primeiraOperacao) //se for a primeira operação realizada
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor

                if (botaoIgual == false) //se o botaoIgual estiver como false
                {
                    txtHistorico.Text += txtVisor.Text; //o txtHistorico adiciona o que estiver no txtVisor
                }

                txtVisor.Clear(); //limpa o txtVisor
                operacao = "+"; //determina que a operação realizada é adição
                primeiraOperacao = false; //primeiraOperação a passa a ser false
            }
            else //senão
            {
                valorVisor = Convert.ToDouble(txtVisor.Text); //converte o numero do txtVisor para double

                txtHistorico.Text += operacao + txtVisor.Text; //o txtHistorico recebe a operação realizada anteriormente e o número do txtVisor

                txtVisor.Text = Convert.ToString(valorAnterior + valorVisor); //realiza a soma dos números e exibe no txtVisor

                operacao = "+"; //determina que a operação realizada é adição
                txtHistorico.Text += "=" + txtVisor.Text; //txtHistorico recebe o sinal de = e o último numero inserido no txtVisor
                valorAnterior = Convert.ToDouble(txtVisor.Text); //valor anterior passa a ser o que estiver no txtVisor
                botaoIgual = true; //a variável botaoIgual passa a ser true
            }
        }

        //a seguir estão os demais botões de operações que são semelhantes ao btnAdicao

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text;
                }

                txtVisor.Clear();
                operacao = "-";
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txtVisor.Text);

                txtHistorico.Text += operacao + txtVisor.Text;

                txtVisor.Text = Convert.ToString(valorAnterior - valorVisor);

                operacao = "-";
                txtHistorico.Text += "=" + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text;
                }

                txtVisor.Clear();
                operacao = "x";
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txtVisor.Text);

                txtHistorico.Text += operacao + txtVisor.Text;

                txtVisor.Text = Convert.ToString(valorAnterior * valorVisor);

                operacao = "x";
                txtHistorico.Text += "=" + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (primeiraOperacao)
            {
                valorAnterior = Convert.ToDouble(txtVisor.Text);

                if (botaoIgual == false)
                {
                    txtHistorico.Text += txtVisor.Text;
                }

                txtVisor.Clear();
                operacao = "/";
                primeiraOperacao = false;
            }
            else
            {
                valorVisor = Convert.ToDouble(txtVisor.Text);

                txtHistorico.Text += operacao + txtVisor.Text;

                txtVisor.Text = Convert.ToString(valorAnterior / valorVisor);

                operacao = "/";
                txtHistorico.Text += "=" + txtVisor.Text;
                valorAnterior = Convert.ToDouble(txtVisor.Text);
                botaoIgual = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e) //botão responsável por mostrar o resultado das operações
        {
            valorVisor = Convert.ToDouble(txtVisor.Text);

            txtHistorico.Text += operacao + txtVisor.Text;

            txtVisor.Text = Convert.ToString(Calculo());

            txtHistorico.Text += "=" + txtVisor.Text;

            valorAnterior = Convert.ToDouble(txtVisor.Text);

            botaoIgual = true;
            primeiraOperacao = true;
        }
    }
}
