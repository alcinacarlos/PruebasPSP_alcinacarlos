using PruebasConC.Weapons;

namespace PruebasConC;
class Program
{
    static void Main(string[] args)
    {
        var alfredo = new Character("Alfredo", 100, 20 , 100);
        var ignacio = new Character("Alfredo", 100, 20 , 100);

        Console.WriteLine(alfredo);

        var axe = new Axe("Hacha de mano", 20);
        var minionItem = new SummonMinionItem("Corazon Helado");
        ignacio.AddItem(minionItem);
        alfredo.AddItem(axe);
        
        //ignacio.MinionsAttack(alfredo);
        
        var minion = new Minion("Test Minion", 111, 33, 50);
        var target = new Character("Target Creature", 111, 33, 50);

        // Act
        int damageDealt = minion.Attack(target);
        Console.WriteLine(damageDealt);
        
    }
}