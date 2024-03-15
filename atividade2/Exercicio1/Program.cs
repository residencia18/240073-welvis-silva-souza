using System;

public class ContaBancaria
{
    private double saldo;

    public ContaBancaria()
    {
        saldo = 0;
    }

    public void Sacar(double valor)
    {
        if (valor <= 0)
        {
            throw new ValorInvalidoException("Valor inválido para saque.", valor);
        }

        if (valor > saldo)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente para saque.", saldo);
        }

        saldo -= valor;
    }

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ValorInvalidoException("Valor inválido para depósito.", valor);
        }

        saldo += valor;
    }

    public void Transferir(double valor, ContaBancaria contaDestino)
    {
        if (valor <= 0)
        {
            throw new ValorInvalidoException("Valor inválido para transferência.", valor);
        }

        if (valor > saldo)
        {
            throw new SaldoInsuficienteException("Saldo insuficiente para transferência.", saldo);
        }

        saldo -= valor;
        contaDestino.Depositar(valor);
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria conta1 = new ContaBancaria();
        ContaBancaria conta2 = new ContaBancaria();

        try
        {
            conta1.Depositar(100);
            conta1.Sacar(50);
            conta1.Transferir(30, conta2);
            conta1.Sacar(200);
        }
        catch (ValorInvalidoException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}. Valor inválido: {ex.ValorInvalido}");
        }
        catch (SaldoInsuficienteException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}. Saldo disponível: {ex.SaldoDisponivel}");
        }
    }
}

public class ValorInvalidoException : Exception
{
    public double ValorInvalido { get; }

    public ValorInvalidoException(string message, double valorInvalido) : base(message)
    {
        ValorInvalido = valorInvalido;
    }
}

public class SaldoInsuficienteException : Exception
{
    public double SaldoDisponivel { get; }

    public SaldoInsuficienteException(string message, double saldoDisponivel) : base(message)
    {
        SaldoDisponivel = saldoDisponivel;
    }
}
