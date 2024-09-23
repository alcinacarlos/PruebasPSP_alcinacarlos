namespace PruebasConC;

public class Shield(string Name, int Armor) : Protection(Name, Armor)
{
    public override void Apply(Character character)
    {
        character.CurrentArmor += Armor;
    }
}