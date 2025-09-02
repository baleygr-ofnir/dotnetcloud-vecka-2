namespace Array_exercise;

class Program
{
    static void Main(string[] args)
    {
        var numChecker = new NumChecker(4, 80, 22, 42, 60);
        Console.WriteLine($@"{numChecker.Average}
{numChecker.Highest}
{string.Join(", ", numChecker.Nums)}
{string.Join(", ", numChecker.ReverseNums)}");
        numChecker.SearchArray(80);
    }
}