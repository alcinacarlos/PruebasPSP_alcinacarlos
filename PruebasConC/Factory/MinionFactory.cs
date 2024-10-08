namespace PruebasConC;

using System;

public class MinionFactory
{
    private static Random _random = new Random();
    
    private static string[] _minionNames = { "Esqueleto", "Gólem", "Orco", "Lobo Fantasma", "Zombi", "Gárgola" };
    
    public static Minion GenerateRandomMinion()
    {
        string name = _minionNames[_random.Next(_minionNames.Length)];
        int baseDamage = _random.Next(5, 20);
        int baseArmor = _random.Next(1, 10);
        int maxHitPoints = _random.Next(20, 100);
        
        return new Minion(name, baseDamage, baseArmor, maxHitPoints);
    }
}
