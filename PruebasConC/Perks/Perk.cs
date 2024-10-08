namespace PruebasConC.Perks;
public delegate void PerkEffect(Creature creature);

public class Perk
{
    public string Name { get; set; }
    public PerkEffect ApplyPerk { get; private set; }
    public PerkEffect CancelPerk { get; private set; }

    public Perk(string name, PerkEffect applyPerk, PerkEffect cancelPerk)
    {
        Name = name;
        ApplyPerk = applyPerk;
        CancelPerk = cancelPerk;
    }
}
