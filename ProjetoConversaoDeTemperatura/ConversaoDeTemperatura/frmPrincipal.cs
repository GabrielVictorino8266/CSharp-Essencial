namespace ConversaoDeTemperatura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Quando Clicar na Label.
        }

        private void txtbValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double Valor;


            if (txtbValor.Text != "")
            {
                Valor = Convert.ToDouble(txtbValor.Text);

                if (rdbCelsiusEntrada.Checked == true)
                { 
                      if(rdbCelsiusSaida.Checked == true) 
                      {
                            txtbResultado.Text = txtbValor.Text + " °C";
                      }
                      else if (rdbKelvinSaida.Checked == true)
                      {
                            txtbResultado.Text = (Valor + 273) + " K";
                      }
                      else
                      {
                            txtbResultado.Text = ((Valor * 9 / 5) + 32) + " °F";
                      }
                }
                else if (rdbkelvinEntrada.Checked == true) 
                {
                    if (rdbKelvinSaida.Checked == true)
                    {
                        txtbResultado.Text = txtbValor.Text + " K";
                    }
                    else if (rdbCelsiusSaida.Checked == true)
                    {
                        txtbResultado.Text = (Valor - 273) + " °C";
                    }
                    else
                    {
                        txtbResultado.Text = ((Valor -273) * 9 / 5 + 32) + " °F";
                    }
                }
                else
                {
                    if (rdbFahrenheightSaida.Checked == true)
                    {
                        txtbResultado.Text = txtbValor.Text + " °F";
                    }
                    else if (rdbCelsiusSaida.Checked == true)
                    {
                        txtbResultado.Text = (Valor - 32) * 5 / 9 +  " °";
                    }
                    else
                    {
                        txtbResultado.Text = ((Valor - 32) * 5/9 + 273) + " K";
                    }
                }
            }
            else
            {
                string Message = "Insira um valor válido para a caixa Valor.";
                string Title = "Valor Inválido";
                
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbResultado.Text = "";
            txtbValor.Text = "";

            foreach(Control Componente in gbEntrada.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }

            foreach(Control Componente in gbSaida.Controls)
            {
                (Componente as RadioButton).Checked = false;
            }

        }
    }
}