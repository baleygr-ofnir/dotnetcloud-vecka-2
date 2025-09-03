namespace NumberGuesser;

class NumberGuesser
{
    public NumberGuesser()
    {
        int guessNum;
        var randomNum = new Random().Next(1, 101);
        do
        {
            guessNum = ValidGuess();
            Console.Write("Guess a number: ");
            CheckGuess(guessNum, randomNum);
        } while (guessNum != randomNum);
    }

    static void CheckGuess(int guessNum, int randomNum)
    {
        if (guessNum == randomNum)
        {
            Console.WriteLine($"Correct, random number was {randomNum}. You win, thanks for playing!");
        } else 
        {
            Console.WriteLine("Incorrect Guess!");
            if (Math.Abs(guessNum - randomNum) <= 10)
            {
                Console.WriteLine("You are, however, 10 digits or less from the number!");
            }
        }
    }
    
    private static int ValidGuess()
    {
        bool validGuess = false;
        int num;
        do
        {
            if (!validGuess)
            {
                Console.Write("\nGuess valid integer between 1 and 100: ");
            }
            validGuess = int.TryParse(Console.ReadLine(), out num);
        } while (!validGuess);

        if (num < 1 || num > 100)
        {
            return ValidGuess();
        }
        return num;
    } 
}