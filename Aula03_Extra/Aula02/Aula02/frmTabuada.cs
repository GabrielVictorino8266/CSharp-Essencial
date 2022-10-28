using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Verifica se o campo txtNumero é vazio
            if (txtbNumero.Text == "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                string Mensagem = "Insira um valor válido para a tabuada.";
                string Titulo = "Valor inválido para tabuada.";

                MessageBox.Show(Mensagem, Titulo, buttons, MessageBoxIcon.Warning);
            }
            else
            {
                double numero, resultado;//Declarando variaveis.
                
                numero = double.Parse(txtbNumero.Text);
                
                for(int i = 0; i <= 10; i++)
                {
                    resultado = numero * i;
                    txtTabuada.Text += numero + " X " + i + "=" + resultado + "\r\n";
                    
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbNumero.Text = "";
            txtTabuada.Text = "";
        }
    }
}
