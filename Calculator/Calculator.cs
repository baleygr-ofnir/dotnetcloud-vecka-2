namespace Calculator;

class Calculator
{
    public Calculator()
    {
        bool running = true;
        while (running)
        {
            Console.Write("Calculator running... (Q/q or Ctrl+C to exit)\nEnter operator: ");
            //string mathOp = Console.ReadLine()!.ToLower();
            char mathOp = Console.ReadKey().KeyChar;
            switch (mathOp)
            {
                case '+':
                    Console.WriteLine(Add(ValidInt(), ValidInt()));
                    break;
                case '-':
                    Console.WriteLine(Subtract(ValidInt(), ValidInt()));
                    break;
                case '*':
                    Console.WriteLine(Multiply(ValidInt(), ValidInt()));
                    break;
                case '/':
                    Console.WriteLine(Divide(ValidDouble(), ValidDouble()));
                    break;
                case 'q':
                    running = false;
                    break;
            }
        }
    }

    private static int Add(int a, int b)
    {
        return a + b;
    }

    private static int Subtract(int a, int b)
    {
        return a - b;
    }

    private static int Multiply(int a, int b)
    {
        return a * b;
    }

    private static double Divide(double a, double b)
    {
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