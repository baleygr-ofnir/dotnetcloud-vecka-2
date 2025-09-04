namespace ConsoleApp1;

public class Superhero(string Name, int PowerLevel)
{
    public void Introduce()
    {
        Console.WriteLine($"Hero: {Name}, power level {PowerLevel}");
    }

    public void Taunt(Villain v)
    {
        Console.WriteLine("It's time to meet your demise.");
    }

    public void Fight(Villain v)
    {
        int powerBonus = new Random().Next(0, 3);
        int evilBonus = new Random().Next(0, 3);
        if (PowerLevel + powerBonus >= v.EvilLevel + evilBonus)
        {
            Console.WriteLine($"Power level {PowerLevel} and power bonus {powerBonus} of {Name} is superior to {v.Name} with evil level {v.EvilLevel} and evil bonus {evilBonus}.");
        }
        else
        {
            Console.WriteLine($"{v.Name} with evil level {v.EvilLevel} and evil bonus {evilBonus} strikes {Name} with power level {PowerLevel} and power bonus {powerBonus} down with ease.");
        }
    }

    public void Train()
    {
        PowerLevel++;
    }
}