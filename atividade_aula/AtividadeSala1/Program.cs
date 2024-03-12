// Exercício 1
// Crie uma classe Lampada que possui um field ligada, que indica se a lâmpada está ligada ou 
// desligada.
// Ao construir uma lâmpada, o estado dela (ligada ou desligada) deve ser fornecido. Para ligar e 
// desligar a lâmpada, os métodos Ligar() e Desligar() devem ser chamados, respectivamente. 
// Aliás, esta é a única forma de alterar o estado da lâmpada, já que o field ligada não pode ser 
// acessado de fora da classe.
// A lâmpada também possui um método Imprimir(). Quando chamado, ele mostra as mensagens 
// “Lâmpada ligada” ou “Lâmpada desligada”, dependendo do estado atual.
// Construa uma aplicação que cria uma lâmpada ligada, muda o estado dela e também imprime o 
// estado atual após cada chamada a Ligar() e Desligar().

public class Lampada
{
    private bool ligada;

    public Lampada(bool estadoInicial)
    {
        ligada = estadoInicial;
    }

    public void Ligar()
    {
        ligada = true;
    }

    public void Desligar()
    {
        ligada = false;
    }

    public void Imprimir()
    {
        if (ligada)
            Console.WriteLine("Lâmpada ligada");
        else
            Console.WriteLine("Lâmpada desligada");
    }
}


class Program
{
    static void Main()
    {
        Lampada lampada = new Lampada(true);
        lampada.Imprimir();

        lampada.Desligar();
        lampada.Imprimir();

        lampada.Ligar();
        lampada.Imprimir();
    }
}
