using System;

class Program
{
    static void Main(string[] args)
    {
        FuncionarioCLT clt = new FuncionarioCLT();

        Console.WriteLine("=== Cadastro Funcionário CLT ===");
        clt.ReceberDadosCLT();
        clt.MostrarDados();

        Console.WriteLine();

        FuncionarioComissionado comissionado = new FuncionarioComissionado();

        Console.WriteLine("=== Cadastro Funcionário Comissionado ===");
        comissionado.ReceberDadosComissionado();
        comissionado.MostrarDados();

        Console.ReadKey();
    }
}