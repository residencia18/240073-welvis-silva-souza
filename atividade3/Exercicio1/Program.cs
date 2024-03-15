class Program
{
    static void Main()
    {
        List<double> numbers = new List<double> { 3, 7, 2, 4, 6 };

        List<double> dividedNumbers = numbers.ConvertAll(num => num / 2);

        dividedNumbers.ForEach(num => Console.WriteLine(num));
    }
}
