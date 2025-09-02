using System.Runtime.CompilerServices;

namespace Calculator;

class Calculator
{
    public static int Add()
    {
        return ValidInt() + ValidInt();
    }

    public static int Subtract()
    {
        return ValidInt() - ValidInt();
    }

    public static int Multiply()
    {
        return ValidInt() * ValidInt();
    }

    public static double Divide()
    {
        double a = ValidDouble();
        double b = ValidDouble();
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero, please enter new integer.");
            b = ValidDouble();
        }

        return a / b;
    }

    private static int ValidInt()
    {
        bool validInt = false;
        int num;
        do
        {
            if (!validInt)
            {
                Console.Write("\nEnter valid integer: ");
            }
            validInt = int.TryParse(Console.ReadLine(), out num);
        } while (!validInt);
        return num;
    }

    private static double ValidDouble()
    {
        bool validInt = false;
        double num;
        do
        {
            if (!validInt)
            {
                Console.Write("\nEnter valid integer: ");
            }
            validInt = double.TryParse(Console.ReadLine(), out num);
        } while (!validInt);
        return num;
    }
}