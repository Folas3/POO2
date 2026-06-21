using System;

public class PagamentoCartao : Pagamento
{
    private int QuantidadeParcelas;
    private double ValorParcela;

    public void ReceberDadosCartao()
    {
        ReceberDados();

        Console.Write("Quantidade de Parcelas: ");
        QuantidadeParcelas = int.Parse(Console.ReadLine());

        if (QuantidadeParcelas <= 0)
        {
            QuantidadeParcelas = 1;
        }
    }

    public override void ProcessarPagamento()
    {
        ValorParcela = Valor / QuantidadeParcelas;
        Console.WriteLine("Pagamento aprovado no cartão de crédito.");
    }

    public override void MostrarPagamento()
    {
        Console.WriteLine("\n--- Pagamento Cartão de Crédito ---");
        Console.WriteLine("Cliente: " + NomeCliente);
        Console.WriteLine("Valor Total: R$ " + Valor.ToString("F2"));
        Console.WriteLine("Quantidade de Parcelas: " + QuantidadeParcelas);
        Console.WriteLine("Valor da Parcela: R$ " + ValorParcela.ToString("F2"));
    }
}