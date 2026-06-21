using System;

public class FuncionarioComissionado : Funcionario
{
    private double TotalVendas;
    private double PercentualComissao;

    public void ReceberDadosComissionado()
    {
        ReceberDados();

        Console.Write("Total de Vendas: ");
        TotalVendas = double.Parse(Console.ReadLine());

        Console.Write("Percentual de Comissão (%): ");
        PercentualComissao = double.Parse(Console.ReadLine());
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + (TotalVendas * PercentualComissao / 100);
    }

    public override void MostrarDados()
    {
        Console.WriteLine("\n--- Funcionário Comissionado ---");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Total de Vendas: R$ " + TotalVendas.ToString("F2"));
        Console.WriteLine("Percentual de Comissão: " + PercentualComissao + "%");
        Console.WriteLine("Salário Final: R$ " + CalcularSalarioFinal().ToString("F2"));
    }
}