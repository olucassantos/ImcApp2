namespace ImcApp
{
    public partial class frmCalculaImc : Form
    {
        public frmCalculaImc()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Pega o numero do campo peso e guarda na variável
            decimal peso = numPeso.Value;

            // Pega o numero do campo altura e guarda na variável
            decimal altura = numAltura.Value;

            // Calcula o IMC
            decimal imc = peso / (altura * altura);

            // Cria a tela para o resultado
            frmResultado resultado = new frmResultado(imc);
            resultado.ShowDialog();

            // Coloca o resultado na legenda de resultado
            //lblResultado.Text = imc.ToString("N2");

            //posicionaSeta(imc);
        }

        private void posicionaSeta(decimal valor)
        {
            decimal x = 35 + ((valor - 18) * 510 / (40 - 18));
            lblSeta.Location = new Point((int)x, lblSeta.Location.Y);
        }

        private void btnAbreTela_Click(object sender, EventArgs e)
        {
            // Criando uma variável do tipo frmCalculaImc 
            frmCalculaImc formulario;

            // Cria uma instancia do frmCalculaImc e guarda na variavel
            formulario = new frmCalculaImc();

            formulario.Show();
        }
    }
}

