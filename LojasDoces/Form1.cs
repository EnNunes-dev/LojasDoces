namespace LojasDoces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // =======================================================================================
                // INSTANCIA(Criação do projeo na memória)
                // =======================================================================================

                Pedido pedido = new Pedido();

                // =======================================================================================
                //PROPRIEDADE(ATRIBUIÇÃO DE DADOS)
                //PEGAMOS O TEXT DAS CAIXAS TEXTBOX E CONVERTEMOS
                // =======================================================================================
                pedido.NomeDoce = txtNomeDoce.Text;
                pedido.PrecoUnitario = Convert.ToDouble(txtPrecoUnitario.Text);
                pedido.Quantidade = int.Parse(txtQuantidade.Text);
                pedido.IdadeCliente = int.Parse(txtIdadeCliente.Text);
                //UTILIZACAO DO OBJETO

                double desconto = pedido.CalcularDesconto();
                double valorFinal = pedido.CalcularValorFinal();
                double parcela = pedido.CalcularParcela();
                bool brindeAprovado = pedido.ValidarBrinde();

                //EXIBIR OS DADOS FORMATADOS
                lblNome.Text = $"{pedido.NomeDoce.ToUpper()}";
                lblDesconto.Text = $"R$ {desconto:N2}";
                lblValorFinal.Text = $"R$ {valorFinal:N2}";
                lblParcela.Text = $"3x de R$ {parcela:N2}";
                //Limpando campos
                txtNomeDoce.Clear();
                txtPrecoUnitario.Clear();
                txtQuantidade.Clear();
                txtIdadeCliente.Clear();
                if (brindeAprovado)
                {
                    lblStatus.Text = "PARABÉNS! Você ganhou um brinde surpresa!";
                    lblStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblStatus.Text = "Compra padrão realizada com sucesso!";
                    lblStatus.ForeColor = Color.Blue;
                }
            }
            catch (FormatException)
            {
                // Tratamento simples caso o usuario digite texto onde deveria ser número
                MessageBox.Show("Preencha os campos numéricos corretamente!",
                "Erro de Digitação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            }

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
