using PruebasConC.factory;
using PruebasConC.Perks;
using PruebasConC.Protections;
using PruebasConC.Weapons;

namespace PruebasConC;
class Program
{
    static void Main(string[] args)
    {
        var alfredo = new Character("Alfredo", 100, 20 , 100);
        var ignacio = new Character("Alfredo", 100, 20 , 100);

        var armorPerk = PerkFactory.IncreasedArmor(0);
        var damagePerk = PerkFactory.ExtraDamage(10);
        
        var axe = new Axe("Hacha de mano", 20, new List<Perk>(){damagePerk});
        var helmet = new Helmet("Casco", 10, new List<Perk>(){armorPerk});
        
        var minionItem = new SummonMinionItem("Corazon Helado");
        
        
        ignacio.AddItem(minionItem);
        ignacio.AddItem(helmet);
        alfredo.AddItem(axe);
        
        ignacio.MinionsAttack(alfredo);
        
    }
}