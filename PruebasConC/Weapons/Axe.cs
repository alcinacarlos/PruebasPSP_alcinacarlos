using PruebasConC.Perks;

namespace PruebasConC.Weapons;

public class Axe(string name, int damage, List<Perk>? perks = null) : Weapon(name, damage, perks)
{
}