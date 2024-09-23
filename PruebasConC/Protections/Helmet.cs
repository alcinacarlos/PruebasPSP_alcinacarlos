namespace PruebasConC;

public class Helmet(string name, int armor): Protection(name, armor)
{
    public override void Apply(Character character)
    {
        character.CurrentArmor += armor;
    }
}