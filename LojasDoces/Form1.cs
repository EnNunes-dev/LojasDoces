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
                pedido.NomeDoce = txtNomeDoce.txt;

            }

        }
    }
}
