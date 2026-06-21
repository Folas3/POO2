using System;

class Program
{
    static void Main(string[] args)
    {
        decimal valorCompra = 100m;

        IDesconto clienteComum = new DescontoClienteComum();
        IDesconto clienteVip = new DescontoClienteVip();

        Console.WriteLine("Valor original: R$ " + valorCompra.ToString("F2"));

        Console.WriteLine("\nCliente Comum (5% de desconto)");
        Console.WriteLine("Valor final: R$ " +
                          clienteComum.Calcular(valorCompra).ToString("F2"));

        Console.WriteLine("\nCliente VIP (10% de desconto)");
        Console.WriteLine("Valor final: R$ " +
                          clienteVip.Calcular(valorCompra).ToString("F2"));

        Console.ReadKey();
    }
}