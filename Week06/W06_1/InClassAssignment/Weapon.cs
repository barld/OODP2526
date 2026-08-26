namespace InClassAssignment;

public class Weapon
{
    public string Name { get;}
    public int Strength { get;}

    public Weapon(string name, int damage)
    {
        Name = name;
        Strength = damage;
    }
}