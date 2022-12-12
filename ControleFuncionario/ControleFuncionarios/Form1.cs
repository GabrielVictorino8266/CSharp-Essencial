namespace ControleFuncionarios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbCargo.Text == "Assistente Administrativo") 
            {
                Administrativo novoFuncionarioAdministrativo = new Administrativo();
                
                novoFuncionarioAdministrativo.Salvar(txtbNome.Text, cmbCargo.Text, Convert.ToDecimal(txtbSalario.Text));

                txtbInfo.AppendText(novoFuncionarioAdministrativo.MostraNome()+"\t");
                txtbInfo.AppendText(novoFuncionarioAdministrativo.MostraCargo() + "\t");
                txtbInfo.AppendText(novoFuncionarioAdministrativo.MostraSalario() + "\r\n");

            } 
            else
            {
                Designer novoFuncionarioDesigner = new Designer();

                novoFuncionarioDesigner.Salvar(txtbNome.Text, cmbCargo.Text, Convert.ToDecimal(txtbSalario.Text));

                txtbInfo.AppendText(novoFuncionarioDesigner.MostraNome() + "\t");
                txtbInfo.AppendText(novoFuncionarioDesigner.MostraCargo() + "\t");
                txtbInfo.AppendText(novoFuncionarioDesigner.MostraSalario() + "\r\n");
            }
        }
    }
}