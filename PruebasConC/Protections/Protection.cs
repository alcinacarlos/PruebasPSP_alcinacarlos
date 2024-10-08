using PruebasConC.Perks;

namespace PruebasConC.Protections;

public abstract class Protection : IItem
{
    public string Name { get; set; }
    public int Armor { get; set; }
    private List<Perk>? _perks;

    public Protection(string name, int armor, List<Perk>? perks = null)
    {
        Name = name;
        Armor = armor;
        _perks = perks;
    }

    public void Apply(Creature creature)
    {
        creature.CurrentArmor += Armor;
        if (_perks == null || _perks.Count == 0) return;
        foreach (var perk in _perks)
        {
            perk.ApplyPerk(creature);
        }
    }

    public  void Cancel(Creature creature)
    {
        creature.CurrentArmor -= Armor;
        if (_perks == null || _perks.Count == 0) return;
        foreach (var perk in _perks)
        {
            perk.CancelPerk(creature);
        }
    }
}