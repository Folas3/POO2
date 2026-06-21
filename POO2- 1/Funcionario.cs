using System;

public class Funcionario
{
    protected string Nome;
    protected string Cargo;
    protected double SalarioBase;

    public virtual void ReceberDados()
    {
        Console.Write("Nome: ");
        Nome = Console.ReadLine();

        Console.Write("Cargo: ");
        Cargo = Console.ReadLine();

        Console.Write("Salário Base: ");
        SalarioBase = double.Parse(Console.ReadLine());
    }

    public virtual double CalcularSalarioFinal()
    {
        return SalarioBase;
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Salário Final: R$ " + CalcularSalarioFinal().ToString("F2"));
    }
}