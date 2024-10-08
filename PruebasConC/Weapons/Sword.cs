using PruebasConC.Perks;

namespace PruebasConC.Weapons;

public class Sword(string name, int damage, List<Perk>? perks = null) : Weapon(name, damage, perks)
{
}