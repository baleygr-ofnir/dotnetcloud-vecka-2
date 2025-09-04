namespace Classes;

class Human
{
    public string Name;
    public int Age;
    int _stepsWalked;
    
    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
    }
    
    public void Walk(int steps)
    {
        _stepsWalked += steps;
        Console.WriteLine($"{Name} walked {steps} steps. Total amount of steps walked are {_stepsWalked}.");
    }

    public void Greet(Human person)
    {
        Console.WriteLine($"{Name} greets {person.Name}: 'Hello!'");
    }
}

