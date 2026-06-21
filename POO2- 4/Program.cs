using System;
using System.Collections.Generic;

class Program
{
    static List<Aluno> alunos = new List<Aluno>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Cadastrar Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Alterar Aluno");
            Console.WriteLine("4 - Remover Aluno");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarAluno();
                    break;

                case 2:
                    ListarAlunos();
                    break;

                case 3:
                    AlterarAluno();
                    break;

                case 4:
                    RemoverAluno();
                    break;

                case 5:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 5);
    }

    static void CadastrarAluno()
    {
        Console.Write("RA: ");
        string ra = Console.ReadLine();

        foreach (Aluno aluno in alunos)
        {
            if (aluno.RA == ra)
            {
                Console.WriteLine("RA já cadastrado!");
                return;
            }
        }

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        alunos.Add(new Aluno(ra, nome, idade));

        Console.WriteLine("Aluno cadastrado com sucesso!");
    }

    static void ListarAlunos()
    {
        if (alunos.Count == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado.");
            return;
        }

        Console.WriteLine("\n=== LISTA DE ALUNOS ===");

        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine("RA: " + aluno.RA);
            Console.WriteLine("Nome: " + aluno.Nome);
            Console.WriteLine("Idade: " + aluno.Idade);
            Console.WriteLine();
        }
    }

    static void AlterarAluno()
    {
        Console.Write("Informe o RA do aluno: ");
        string ra = Console.ReadLine();

        foreach (Aluno aluno in alunos)
        {
            if (aluno.RA == ra)
            {
                Console.Write("Novo nome: ");
                aluno.Nome = Console.ReadLine();

                Console.Write("Nova idade: ");
                aluno.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Aluno alterado com sucesso!");
                return;
            }
        }

        Console.WriteLine("Aluno não encontrado.");
    }

    static void RemoverAluno()
    {
        Console.Write("Informe o RA do aluno: ");
        string ra = Console.ReadLine();

        for (int i = 0; i < alunos.Count; i++)
        {
            if (alunos[i].RA == ra)
            {
                alunos.RemoveAt(i);
                Console.WriteLine("Aluno removido com sucesso!");
                return;
            }
        }

        Console.WriteLine("Aluno não encontrado.");
    }
}