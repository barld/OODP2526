// Solution to in-class assignment
public class StartKnight
{
    public string Name { get; }
    public int X { get; private set; }
    public int Y { get; private set; }
    public string CurrentPosition => $"({X}, {Y})";

    private readonly int _maximumHitPoints;

    private int _currentHitPoints;
    public int CurrentHitPoints
    {
        get => _currentHitPoints;
        private set => _currentHitPoints = Math.Clamp(value,0,_maximumHitPoints);
    }

    public string ASCII => CurrentHitPoints > 0
        ? "{._.} -{---"
        : "{-_-}";

    public Weapon EquippedWeapon { get; set; }
    private static readonly Random _randomGenerator = new();

    public StartKnight(string name, int maximumHitPoints, Weapon equippedWeapon)
    {
        Name = name;
        _maximumHitPoints = maximumHitPoints;
        CurrentHitPoints = maximumHitPoints;
        EquippedWeapon = equippedWeapon;
    }

    public void MoveLeft(int distance)
    {
        X -= distance;
    }

    public void MoveRight(int distance)
    {
        X += distance;
    }

    public int Attack()
    {
        return _randomGenerator.Next(EquippedWeapon.Strength) + 1;
    }

    public void Defend(int damage)
    {
        if (_randomGenerator.Next(2) == 0)
        {
            CurrentHitPoints -= damage;
        }
    }
}
