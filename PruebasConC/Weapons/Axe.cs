namespace PruebasConC;

public class Axe(string Name, int Damage) : Weapon(Name, Damage)
{
    public override void Apply(Character character)
    {
        character.CurrentDamage += Damage;
    }
}