using PruebasConC.Perks;

namespace PruebasConC.Protections;

public class Helmet(string name, int armor, List<Perk>? perks = null) : Protection(name, armor, perks)
{
}