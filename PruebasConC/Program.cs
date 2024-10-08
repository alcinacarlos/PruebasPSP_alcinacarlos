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
        
        ignacio.MinionsAttack(alfredo);
        
        
    }
}