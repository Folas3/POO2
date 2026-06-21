using System;

public class PagamentoPix : Pagamento
{
    private string ChavePix;

    public void ReceberDadosPix()
    {
        ReceberDados();

        Console.Write("Chave Pix: ");
        ChavePix = Console.ReadLine();
    }

    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento via Pix aprovado instantaneamente.");
    }

    public override void MostrarPagamento()
    {
        Console.WriteLine("\n--- Pagamento Pix ---");
        Console.WriteLine("Cliente: " + NomeCliente);
        Console.WriteLine("Valor: R$ " + Valor.ToString("F2"));
        Console.WriteLine("Chave Pix: " + ChavePix);
        Console.WriteLine("Status: Aprovado");
    }
}