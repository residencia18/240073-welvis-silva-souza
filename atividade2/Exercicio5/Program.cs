using System;

public struct Ponto<T>
{
    public T X { get; set; }
    public T Y { get; set; }
    public T Z { get; set; }
}

public struct Triangulo<T>
{
    public Ponto<T> P1 { get; set; }
    public Ponto<T> P2 { get; set; }
    public Ponto<T> P3 { get; set; }
}

class Program
{
    static void Main()
    {
        Triangulo<int> trianguloInt = new Triangulo<int>
        {
            P1 = new Ponto<int> { X = 1, Y = 2, Z = 3 },
            P2 = new Ponto<int> { X = 4, Y = 5, Z = 6 },
            P3 = new Ponto<int> { X = 7, Y = 8, Z = 9 }
        };

        Triangulo<double> trianguloDouble = new Triangulo<double>
        {
            P1 = new Ponto<double> { X = 1.5, Y = 2.5, Z = 3.5 },
            P2 = new Ponto<double> { X = 4.5, Y = 5.5, Z = 6.5 },
            P3 = new Ponto<double> { X = 7.5, Y = 8.5, Z = 9.5 }
        };

        Triangulo<string> trianguloString = new Triangulo<string>
        {
            P1 = new Ponto<string> { X = "A", Y = "B", Z = "C" },
            P2 = new Ponto<string> { X = "D", Y = "E", Z = "F" },
            P3 = new Ponto<string> { X = "G", Y = "H", Z = "I" }
        };

        // Validating the implementation
        Console.WriteLine($"Triangulo<int>: {trianguloInt.P1.X}, {trianguloInt.P2.Y}, {trianguloInt.P3.Z}");
        Console.WriteLine($"Triangulo<double>: {trianguloDouble.P1.X}, {trianguloDouble.P2.Y}, {trianguloDouble.P3.Z}");
        Console.WriteLine($"Triangulo<string>: {trianguloString.P1.X}, {trianguloString.P2.Y}, {trianguloString.P3.Z}");
    }
}
