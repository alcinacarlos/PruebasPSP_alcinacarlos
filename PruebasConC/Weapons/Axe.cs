namespace PruebasConC.Weapons;

public class Axe(string name, int damage) : Weapon(name, damage)
{
    public override void Apply(Creature creature)
    {
        creature.CurrentDamage += Damage;
    }

    public override void Cancel(Creature creature)
    {
        creature.CurrentDamage -= Damage;
    }
}