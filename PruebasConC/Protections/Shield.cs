namespace PruebasConC.Protections;

public class Shield(string name, int armor) : Protection(name, armor)
{
    public override void Apply(Creature creature)
    {
        creature.CurrentArmor += Armor;
    }

    public override void Cancel(Creature creature)
    {
        creature.CurrentArmor -= Armor;
    }
}