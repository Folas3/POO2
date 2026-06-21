using System;
using System.Collections.Generic;
using System.Text;

public class FuncionarioCLT : Funcionario
{
    private double Bonus;

    public void ReceberDadosCLT()
    {
        ReceberDados();

        Console.Write("Bônus: ");
        Bonus = double.Parse(Console.ReadLine());
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + Bonus;
    }

    public override void MostrarDados()
    {
        Console.WriteLine("\n--- Funcionário CLT ---");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Bônus: R$ " + Bonus.ToString("F2"));
        Console.WriteLine("Salário Final: R$ " + CalcularSalarioFinal().ToString("F2"));
    }
}