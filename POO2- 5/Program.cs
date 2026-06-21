using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>();
        double total = 0;

        for (int i = 1; i <= 4; i++)
        {
            Produto produto = new Produto();

            Console.WriteLine($"Produto {i}");

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());

            produtos.Add(produto);
        }

        Console.WriteLine("\nProdutos cadastrados:");

        foreach (Produto produto in produtos)
        {
            Console.WriteLine($"{produto.Nome} - R$ {produto.Preco:F2}");
            total += produto.Preco;
        }

        Console.WriteLine($"\nValor total: R$ {total:F2}");

        Console.ReadKey();
    }
}