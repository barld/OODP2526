public class Knight : Player
{
    public override string ASCII => CurrentHitPoints > 0
        ? "{._.} -{---"
        : "{-_-}";
    public Weapon EquippedWeapon { get; set; }

    public Knight(string name, int maximumHitPoints, Weapon weapon)
        : base(name, maximumHitPoints)
    {
        EquippedWeapon = weapon;
    }

    public override int Attack()
    {
        return RandomGenerator.Next(EquippedWeapon.Strength) + 1;
    }
}