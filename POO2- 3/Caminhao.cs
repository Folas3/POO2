using System;

public class Caminhao : Veiculo
{
    private double CapacidadeCarga;

    public void ReceberDadosCaminhao()
    {
        ReceberDados();

        Console.Write("Capacidade de Carga (kg): ");
        CapacidadeCarga = double.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 500;
    }

    public override void MostrarDados()
    {
        Console.WriteLine("\n--- Caminhão ---");
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Capacidade de Carga: " + CapacidadeCarga + " kg");
        Console.WriteLine("Custo da Manutenção: R$ " + CalcularCustoManutencao().ToString("F2"));
    }
}