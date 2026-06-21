using System;

public class Moto : Veiculo
{
    private int Cilindradas;

    public void ReceberDadosMoto()
    {
        ReceberDados();

        Console.Write("Cilindradas: ");
        Cilindradas = int.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 100;
    }

    public override void MostrarDados()
    {
        Console.WriteLine("\n--- Moto ---");
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Cilindradas: " + Cilindradas + " cc");
        Console.WriteLine("Custo da Manutenção: R$ " + CalcularCustoManutencao().ToString("F2"));
    }
}