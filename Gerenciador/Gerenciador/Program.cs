using System;
using System.Collections.Generic;
using Gerenciador_Tarefas.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Olá, Bem Vindo ao Gerenciador de Tarefas!!");
        Console.WriteLine("------------------------------------------");

        Gerenciador gerenciador = new Gerenciador();

        bool Ativo = true;

        while (Ativo == true)
        {
            Console.WriteLine();
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1- Adicionar tarefa");
            Console.WriteLine("2- Ver a Lista de tarefas");
            Console.WriteLine("3- Apagar tarefa");
            Console.WriteLine("4- Encerrar o programa");
            Console.WriteLine();

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.WriteLine("Data:");
                    string Dia = Console.ReadLine();
                    Console.WriteLine("Tarefa:");
                    string Tarefa = Console.ReadLine();

                    gerenciador.AdicionarTarefa(Dia, Tarefa);

                    Console.WriteLine("Tarefa adicionada!!");
                    break;

                case "2":
                    Console.WriteLine("Lista de Tarefas:");
                    var tarefas = gerenciador.ObterTarefas();
                    foreach (var tarefa in tarefas)
                    {
                        Console.WriteLine(tarefa);
                    }
                    break;

                case "3":
                    Console.WriteLine("Digite o número da tarefa a ser apagada");
                    string numero = Console.ReadLine();
                    if (int.TryParse(numero, out int numeroReal))
                    {
                        gerenciador.ApagarTarefa(numeroReal);
                        Console.WriteLine("Tarefa Apagada!!");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido. Tente novamente.");
                    }
                    break;

                case "4":
                    Ativo = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
