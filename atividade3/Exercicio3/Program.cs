public class Worker
{
    public void Work()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: Working on task {i}");
            Thread.Sleep(1000);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Worker worker1 = new Worker();
        Worker worker2 = new Worker();

        Thread thread1 = new Thread(worker1.Work);
        Thread thread2 = new Thread(worker2.Work);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("All threads have finished executing. Press any key to exit.");
        Console.ReadKey();
    }
}
