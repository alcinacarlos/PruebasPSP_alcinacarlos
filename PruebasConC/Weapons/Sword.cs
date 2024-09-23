namespace PruebasConC;

public class Sword(String Name, int Damage) : Weapon(Name,Damage)
{
    public override void Apply(Character character)
    {
        character.CurrentDamage += Damage;
    }
}