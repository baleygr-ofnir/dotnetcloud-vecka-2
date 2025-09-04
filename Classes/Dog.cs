namespace Classes;

class Dog
{
    public string Name;
    public int Age;

    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} barks: Voff voff!");
    }
}