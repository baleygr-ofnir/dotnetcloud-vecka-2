namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        List<Human> family = new List<Human>()
        {
            new Human
            {
                Name = "Ingalill",
                Age = 72,
            },
            new Human
            {
                Name = "Thomas",
                Age = 73,
            },
            new Human
            {
                Name = "Bjarne",
                Age = 53,
            },
            new Human
            {
                Name = "Ambjörn",
                Age = 52,
            },
            new Human
            {
                Name = "Sanna",
                Age = 45,
            },
            new Human
            {
                Name = "Ylva-li",
                Age = 38,
            },
            new Human
            {
                Name = "Joar",
                Age = 37,
            },
            new Human
            {
                Name = "Jorma",
                Age = 29,
            }
        };
        
        family[7].Introduce();
        family[7].Greet(family[1]);
        family[1].Greet(family[7]);
    }
}