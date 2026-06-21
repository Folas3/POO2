using System;

class Program
{
    static void Main(string[] args)
    {
        PagamentoPix pix = new PagamentoPix();

        Console.WriteLine("=== Pagamento Pix ===");
        pix.ReceberDadosPix();
        pix.ProcessarPagamento();
        pix.MostrarPagamento();

        Console.WriteLine();

        PagamentoCartao cartao = new PagamentoCartao();

        Console.WriteLine("=== Pagamento Cartão de Crédito ===");
        cartao.ReceberDadosCartao();
        cartao.ProcessarPagamento();
        cartao.MostrarPagamento();

        Console.ReadKey();
    }
}