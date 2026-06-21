using System;

public class Pagamento
{
    protected string NomeCliente;
    protected double Valor;

    public virtual void ReceberDados()
    {
        Console.Write("Nome do Cliente: ");
        NomeCliente = Console.ReadLine();

        Console.Write("Valor do Pagamento: ");
        Valor = double.Parse(Console.ReadLine());
    }

    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento processado.");
    }

    public virtual void MostrarPagamento()
    {
        Console.WriteLine("Cliente: " + NomeCliente);
        Console.WriteLine("Valor: R$ " + Valor.ToString("F2"));
    }
}