using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Cliente> clientes = new List<Cliente>();
        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU DE CLIENTES =====");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Listar clientes");
            Console.WriteLine("3 - Buscar cliente por nome");
            Console.WriteLine("4 - Remover cliente");
            Console.WriteLine("5 - Sair");

            Console.Write("\nEscolha uma opção: ");
            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao)
            {
                case 1:
                    CadastrarCliente(clientes);
                    break;

                case 2:
                    ListarClientes(clientes);
                    break;

                case 3:
                    BuscarCliente(clientes);
                    break;

                case 4:
                    RemoverCliente(clientes);
                    break;

                case 5:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        } while (opcao != 5);
    }

    static void CadastrarCliente(List<Cliente> clientes)
    {
        Cliente cliente = new Cliente();

        Console.Write("Nome: ");
        cliente.Nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(cliente.Nome))
        {
            Console.WriteLine("Nome não pode ser vazio.");
            return;
        }

        Console.Write("Telefone: ");
        cliente.Telefone = Console.ReadLine();

        Console.Write("Cidade: ");
        cliente.Cidade = Console.ReadLine();

        clientes.Add(cliente);

        Console.WriteLine("Cliente cadastrado com sucesso!");
    }

    static void ListarClientes(List<Cliente> clientes)
    {
        if (clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
            return;
        }

        Console.WriteLine("\n=== CLIENTES CADASTRADOS ===");

        foreach (Cliente cliente in clientes)
        {
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("Telefone: " + cliente.Telefone);
            Console.WriteLine("Cidade: " + cliente.Cidade);
            Console.WriteLine();
        }
    }

    static void BuscarCliente(List<Cliente> clientes)
    {
        Console.Write("Digite o nome do cliente: ");
        string nome = Console.ReadLine();

        foreach (Cliente cliente in clientes)
        {
            if (cliente.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nCliente encontrado:");
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("Telefone: " + cliente.Telefone);
                Console.WriteLine("Cidade: " + cliente.Cidade);
                return;
            }
        }

        Console.WriteLine("Cliente não encontrado.");
    }

    static void RemoverCliente(List<Cliente> clientes)
    {
        Console.Write("Digite o nome do cliente que deseja remover: ");
        string nome = Console.ReadLine();

        for (int i = 0; i < clientes.Count; i++)
        {
            if (clientes[i].Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                clientes.RemoveAt(i);
                Console.WriteLine("Cliente removido com sucesso!");
                return;
            }
        }

        Console.WriteLine("Cliente não encontrado.");
    }
}