using static System.Net.Mime.MediaTypeNames;

namespace ControleFrota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        
        
        public class Carro
        {
            private string modelo, placa, Km;

            /* C�digos da Aula 07
            //Par�metro de Modelo
            public void gravaModelo(string modelo)
            {
                this.modelo = modelo;
            }

            public string mostraModelo()
            {
                return modelo;
            }


            //Par�metro de Placa
            public void gravaPlaca(string placa)
            {
                this.placa = placa;
            }

            public string mostraPlaca()
            {
                return placa;
            }


            //Par�metro de Km
            public void gravaKm(string Km)
            {
                this.Km = Km;
            }

            public string mostraKm()
            {
                return Km;
            }
            */

            public string propriedadeModelo
            {
                //gravar o que estar� em propriedadeModelo no atributo modelo.
                set {  modelo = value; }
                get { return modelo; }
            }

            public string propriedadePlaca
            {
                set { placa = value; }
                get { return placa; }
            }

            public string propriedadeKm
            {
                set { Km = value; }
                get { return Km; }
            }

        }

        public class Caminhao : Carro
        {
            public string propriedadeEixo { set; get; }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtbEixo.Visible == false)
            {
                //Instancia a classe para ser acessada.
                Carro novoCarro = new Carro();

                //Atribui os inputs das caixas de texto e envia para novoCarro.propriedade___
                novoCarro.propriedadeModelo = txtbModelo.Text;
                novoCarro.propriedadePlaca = txtbPlaca.Text;
                novoCarro.propriedadeKm = txtbKm.Text;

                txtbCarros.AppendText(novoCarro.propriedadeModelo + "\t");
                txtbCarros.AppendText(novoCarro.propriedadePlaca + "\t");
                txtbCarros.AppendText(novoCarro.propriedadeKm + "\r\n");
            }
            else
            {
                Caminhao novoCaminhao = new Caminhao();

                novoCaminhao.propriedadeModelo = txtbModelo.Text;
                novoCaminhao.propriedadePlaca = txtbPlaca.Text;
                novoCaminhao.propriedadeKm = txtbKm.Text;
                novoCaminhao.propriedadeEixo = txtbEixo.Text;

                txtbCaminhao.AppendText(novoCaminhao.propriedadeModelo + "\t");
                txtbCaminhao.AppendText(novoCaminhao.propriedadePlaca + "\t");
                txtbCaminhao.AppendText(novoCaminhao.propriedadeKm + "\t");
                txtbCaminhao.AppendText(novoCaminhao.propriedadeEixo + "\r\n");
            }

            Limpar();
            /*
            //Por meio do encapsulamento, acessamos os atributos indiretamente.
            novoVeiculo.propriedadesModelo(txtbModelo.Text);
            novoVeiculo.gravaPlaca(txtbPlaca.Text);
            novoVeiculo.gravaKm(txtbKm.Text);

            //Exibe as informa��es cadastradas em "txtbCarros."
            txtbCarros.Text += novoVeiculo.mostraModelo() + "\t";
            txtbCarros.Text += novoVeiculo.mostraPlaca() + "\t";
            txtbCarros.Text += novoVeiculo.mostraKm() + " Km." + "\r\n" ;*/
        }

        private void btnCaminhao_Click(object sender, EventArgs e)
        {
            //Ativa a exibi��o de itens destinados a camnih�es.
            txtbEixo.Visible = true;
            lblEixo.Visible = true;
        }

        private void btnCarros_Click(object sender, EventArgs e)
        {   
            //Tira a exibi��o de campos destinados a caminh�es.
            txtbEixo.Visible = false;
            lblEixo.Visible = false;
        }

        private void Limpar()
        {
            txtbModelo.Clear();
            txtbPlaca.Clear();
            txtbKm.Clear();
            txtbEixo.Clear();
        }
    }

   
}