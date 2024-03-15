class Program
{
    static async Task Main()
    {
        Task task1 = DoWorkAsync("Tarefa 1");
        Task task2 = DoWorkAsync("Tarefa 2");

        await Task.WhenAll(task1, task2);

        Console.WriteLine("Ambas as tarefas foram concluídas.");
    }

    static async Task DoWorkAsync(string taskName)
    {
        Console.WriteLine($"Iniciando a execução da {taskName}...");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Executando a {taskName} - Iteração {i}");
            await Task.Delay(1000);
        }

        Console.WriteLine($"Concluindo a execução da {taskName}...");
    }
}
