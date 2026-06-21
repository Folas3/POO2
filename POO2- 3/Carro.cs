using System;

public class Carro : Veiculo
{
    private int QuantidadePortas;

    public void ReceberDadosCarro()
    {
        ReceberDados();

        Console.Write("Quantidade de Portas: ");
        QuantidadePortas = int.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 200;
    }

    public override void MostrarDados()
    {
        Console.WriteLine("\n--- Carro ---");
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Quantidade de Portas: " + QuantidadePortas);
        Console.WriteLine("Custo da Manutenção: R$ " + CalcularCustoManutencao().ToString("F2"));
    }
}