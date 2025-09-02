namespace Array_exercise;

class Program
{
    static void Main(string[] args)
    {
        var NumChecker = new NumCheckr(4, 80, 22, 42, 60);
        Console.WriteLine($@"{NumChecker.Average}
{NumChecker.Highest}
{string.Join(", ", NumChecker.Nums)}
{string.Join(", ", NumChecker.ReverseNums)}");
        NumChecker.SearchArray(80);
    }
}