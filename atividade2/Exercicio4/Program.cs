using System;

public interface IServico
{
    void Executar();
}

public class ServicoFabrica<T> where T : IServico, new()
{
    public T NovaInstancia()
    {
        return new T();
    }
}

public class ExemploServico : IServico
{
    public void Executar()
    {
        Console.WriteLine("Executando o serviço...");
    }
}

public class Program
{
    public static void Main()
    {
        ServicoFabrica<ExemploServico> fabrica = new ServicoFabrica<ExemploServico>();
        ExemploServico servico = fabrica.NovaInstancia();
        servico.Executar();
    }
}
