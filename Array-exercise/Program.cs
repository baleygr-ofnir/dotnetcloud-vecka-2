namespace Array_exercise;

class Program
{
    static void Main(string[] args)
    {
        var numChecker = new NumChecker(4, 80, 22, 42, 60);
        int numSearch = 50;
        Console.WriteLine($@"{numChecker.Average}
{numChecker.Highest}
{string.Join(", ", numChecker.Nums)}
{string.Join(", ", numChecker.ReverseNums(numChecker.Nums))}
{(numChecker.SearchArray(numSearch) ? $"{numSearch} exists" : $"{numSearch} does not exist")}");
        ;
    }
}