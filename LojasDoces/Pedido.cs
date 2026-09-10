
namespace LojasDoces
{
    class Pedido
    {
        //ATRIBUTOS
        public string? NomeDoce {  get; set; }

        public double PrecoUnitario {  get; set; }

        public int Quantidade { get; set; }

        public int IdadeCliente {  get; set; }

        //MÉTODOS

        public double CalcularDesconto()
        {
            double valorTotal = PrecoUnitario * Quantidade;

            if (Quantidade >= 10)
            {
                return valorTotal * 0.10;
            }
            return 0.0;
        }
        //MÉTODO PARA CALCULAR O VALOR FINAL COM DESCONTO APLICADO
        public double CalcularValorFinal()
        {
            double ValorTotalBruto = PrecoUnitario * Quantidade;
            double desconto = CalcularDesconto();
            return ValorTotalBruto - desconto;
        }

        //MÉTODO PARA CALCULAR PARCELAMENTO EM 3X SEM JUROS(SE O VALOR FOR VALIDO)
        public double CalcularParcela()
        {
            return CalcularValorFinal() / 3.0;
        }

        //MÉTODO PARA VALIDADE SE O CLIENTE TEM ACCESO A UM BRINDE ESPECIAL( EXEMPLO MAIOR DE 18 ANOS OU UMA COMPRA GRANDE)
        public bool ValidarBrinde()
        {
            return (IdadeCliente >= 18 && Quantidade >= 5) || (CalcularValorFinal() > 100.0);
        }

    }
}
