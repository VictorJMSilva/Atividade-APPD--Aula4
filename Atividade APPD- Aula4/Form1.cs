namespace Atividade_APPD__Aula4
{
    public partial class Funcionário : Form
    {
        public Funcionário()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            //chamando
            funcionario.Nome = TxtNome.Text;
            funcionario.CPF = TxtCPF.Text;
            funcionario.Horas = float.Parse(TxtValorHora.Text);
            funcionario.ValorHora = float.Parse(TxtValorTrabalhado.Text);
            funcionario.CalcularSalario();
            //
            TxtSalario.Text = funcionario.Salario.ToString();
        }
    }
}