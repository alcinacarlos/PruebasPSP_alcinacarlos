using PruebasConC.Perks;

namespace PruebasConC;

public abstract class Weapon : IItem
{
    public string Name { get; set; }
    public int Damage { get; set; }
    private List<Perk>? _perks;

    public Weapon(string name, int damage, List<Perk>? perks = null)
    {
        Name = name;
        Damage = damage;
        _perks = perks;
    }

    public void Apply(Creature creature)
    {
        creature.CurrentDamage += Damage;
        if (_perks == null || _perks.Count == 0) return;
        foreach (var perk in _perks)
        {
            perk.ApplyPerk(creature);
        }
    }

    public void Cancel(Creature creature)
    {
        creature.CurrentDamage -= Damage;
        if (_perks == null || _perks.Count == 0) return;
        foreach (var perk in _perks)
        {
            perk.CancelPerk(creature);
        }
    }
}