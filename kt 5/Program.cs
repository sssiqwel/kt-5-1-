public interface IAnimal
{
    string Name { get; set; }
    void MakeSound();
}

public class Dog : IAnimal
{
    public string Name { get; set; }

    public Dog(string name)
    {
        Name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} говорит: Гав-гав!");
    }
}
public class Cat : IAnimal
{
    public string Name { get; set; }

    public Cat(string name)
    {
        Name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} говорит: Мяу-мяу!");
    }
}
class Program
{
    static void Main()
    {
        IAnimal dog = new Dog("Бобик");
        IAnimal cat = new Cat("Мурка");
        dog.MakeSound(); 
        cat.MakeSound(); 
        IAnimal[] animals = new IAnimal[] { dog, cat };

        Console.WriteLine("\nВсе животные издают звуки:");
        foreach (var animal in animals)
        {
            animal.MakeSound();
        }
    }
}