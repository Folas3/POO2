using System;

public class Veiculo
{
    protected string Modelo;
    protected int Ano;
    protected double ValorBaseManutencao;

    public virtual void ReceberDados()
    {
        Console.Write("Modelo: ");
        Modelo = Console.ReadLine();

        Console.Write("Ano: ");
        Ano = int.Parse(Console.ReadLine());

        Console.Write("Valor Base da Manutenção: ");
        ValorBaseManutencao = double.Parse(Console.ReadLine());
    }

    public virtual double CalcularCustoManutencao()
    {
        return ValorBaseManutencao;
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Custo da Manutenção: R$ " + CalcularCustoManutencao().ToString("F2"));
    }
}