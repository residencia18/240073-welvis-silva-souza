using System;

enum Exercicio
{
    Academia = 1,
    Luta = 2,
    Corrida = 3
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Opções de exercícios existentes:");
        foreach (Exercicio exercicio in Enum.GetValues(typeof(Exercicio)))
        {
            Console.WriteLine($"{(int)exercicio}: {exercicio}");
        }

        Console.WriteLine("Digite o número do exercício desejado (1, 2 ou 3):");
        int exercicioEscolhido = int.Parse(Console.ReadLine());

        if (Enum.IsDefined(typeof(Exercicio), exercicioEscolhido))
        {
            Exercicio exercicioSelecionado = (Exercicio)exercicioEscolhido;
            Console.WriteLine($"Exercício selecionado: {exercicioSelecionado}");
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }
}
