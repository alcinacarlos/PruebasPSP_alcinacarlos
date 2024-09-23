namespace PruebasConC;

public abstract class Weapon : IItem
{
    public string Name { get; set; }
    public int Damage { get; set; }

    public Weapon(int damage)
    {
        Damage = damage;
    }

    public abstract void Apply(Character character);
}