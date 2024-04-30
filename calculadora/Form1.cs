namespace calculadora
{
    public partial class Form1 : Form
    {
        private Operacao OperacaoSelecionada { get; set; }
        public double Resultado { get; set; }
        public double Valor { get; set; }

        enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
            Porcentagem
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
            }
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = double.Parse(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "+";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "X";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "/";
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada     = Operacao.Porcentagem;
            Valor = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "%";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDouble(txtResultado.Text);
            txtResultado.Text = "";
            try
            {
                if (Valor < 0)
                {
                    MessageBox.Show("Valor inválido");
                }
                else
                {
                    Resultado = Math.Sqrt(Valor);
                    Resultado = Math.Round(Resultado, 5);
                    lblOperacao.Text = "√";
                    txtResultado.Text = Convert.ToString(Resultado);
                }
            }
            catch (Exception) { }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + double.Parse(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDouble(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDouble(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDouble(txtResultado.Text);
                    break;
                case Operacao.Porcentagem:
                    Resultado = (Valor / 100) * Convert.ToDouble(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }
    }
}

