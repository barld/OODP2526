public class Animal
{
    public string Sound { get; }
    public Animal(string sound) => Sound = sound;
}

public interface IFly
{
    void Fly();
}

public class Bird : Animal, IFly
{
    public Bird() : base("Tweet") { }
    public void Fly() => Console.WriteLine("Flying Bird");
}

public class Bee : Animal, IFly
{
    public Bee() : base("Bzzzz") { }
    public void Fly() => Console.WriteLine("Bee flies");
}

public class Cat : Animal
{
    public int Lives = 9;
    public Cat() : base("Meow") { }
}

public class Airplane : IFly
{
    public void Fly() => Console.WriteLine("Flying Airplane");
}

public class FlyingAnimalUtilities
{
    // In a generic definition, use the where clause to 
    // specify constraints on the types that you use as 
    // arguments for type parameters in a generic type (class) or method.
    // FlyAndMakeNoise Generic method where T : A, B
    public static void FlyAndMakeNoise<T>(T flyingAnimal) where T : Animal, IFly
    {
        flyingAnimal.Fly();
        Console.WriteLine(flyingAnimal.Sound);
    }
}