namespace PruebasConC.Protections;

public abstract class Protection : IItem
{
    public string Name { get; set; }
    public int Armor { get; set; }

    public Protection(string name, int armor)
    {
        Name = name;
        Armor = armor;
    }

    public abstract void Apply(Creature creature);
    public abstract void Cancel(Creature creature);
}