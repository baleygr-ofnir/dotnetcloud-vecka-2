namespace for_exercise;

class Program
{
    static void Main(string[] args)
    {
        // for (var i = 2; i <= 20; i++)
        // {
        //     if (i % 2 == 0)
        //     {
        //         Console.WriteLine(i);
        //     }
        // }
        // Console.Write("Enter a number: ");
        // int multiplyNum;
        // bool validNum = int.TryParse(Console.ReadLine(), out multiplyNum);
        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine($"{multiplyNum} * {i} = {multiplyNum * i}");
        // }
        // int totalSum = 0;
        // for (int i = 1; i <= 100; i++)
        // {
        //     totalSum += i;
        // }
        // Console.WriteLine(totalSum);
        int factorial;
        Console.Write("Enter a number: ");
        bool validInt = int.TryParse(Console.ReadLine(), out factorial);
        for (int i = factorial - 1; i > 0; i--)
        {
            factorial *= i;
        }
        Console.WriteLine($"{factorial}");
    }
}