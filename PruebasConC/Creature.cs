namespace PruebasConC;

public abstract class Creature
{
    public string Name { get; set; }
    public int BaseArmor { get; set; }
    public int BaseDamage { get; set; }
    public int CurrentDamage { get; set; }
    public int CurrentArmor { get; set; }
    public int CurrentHit { get; set; }
    private int MaxHitPoints { get; set; }
    
    public abstract int Attack(Creature creature);
    public abstract int Defense(int damage);
    public List<IItem> _inventory { get; set; }

    public Creature(string name, int baseArmor, int baseDamage, int maxHitPoints)
    {
        Name = name;
        BaseArmor = baseArmor;
        BaseDamage = baseDamage;
        MaxHitPoints = maxHitPoints;
        CurrentHit = maxHitPoints;
        CurrentDamage = baseDamage;
        CurrentArmor = baseArmor;
        _inventory = new List<IItem>();
    }

}