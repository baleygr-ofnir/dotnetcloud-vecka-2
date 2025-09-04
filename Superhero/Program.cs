using System.Transactions;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        List<Superhero> superheroes = new List<Superhero>();
        superheroes.Add(new Superhero("Captain America", 50));
        superheroes.Add(new Superhero("Doctor Strange", 99)); 
        superheroes.Add(new Superhero("Hulk", 79)); 
        var villain = new Villain("Dormammu", 95);

        foreach (var superhero in superheroes)
        {
            superhero.Train();
            superhero.Introduce();
            superhero.Fight(villain);
        }
    }
}