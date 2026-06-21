using System;

class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro();

        Console.WriteLine("=== Cadastro do Carro ===");
        carro.ReceberDadosCarro();
        carro.MostrarDados();

        Console.WriteLine();

        Moto moto = new Moto();

        Console.WriteLine("=== Cadastro da Moto ===");
        moto.ReceberDadosMoto();
        moto.MostrarDados();

        Console.WriteLine();

        Caminhao caminhao = new Caminhao();

        Console.WriteLine("=== Cadastro do Caminhão ===");
        caminhao.ReceberDadosCaminhao();
        caminhao.MostrarDados();

        Console.ReadKey();
    }
}