using PruebasConC;

public class Character
{
    public string Name { get; set; }
    public int BaseDamage { get; set; }
    public int BaseArmor { get; set; }
    public int MaxHitPoints { get; set; }
    public int CurrentHit { get; set; }
    public int CurrentDamage { get; set; }
    public int CurrentArmor { get; set; }
    public List<IItem> Inventory { get; set; }

    public Character(string name, int maxHitPoints, int baseDamage, int baseArmor)
    {
        Name = name;
        MaxHitPoints = maxHitPoints;
        CurrentHit = maxHitPoints;
        BaseDamage = baseDamage;
        BaseArmor = baseArmor;
        Inventory = new List<IItem>();
    }
    
    public void Attack(Character character)
    {
        character.Defense(CurrentDamage);
        Console.WriteLine("Atacar");
    }

    public void Defense(int damage)
    {
        Console.WriteLine("Defender");
        var damagePoints = damage - CurrentArmor;
        if (damagePoints <= 0) return;
        ReceiveDamage(damagePoints);
    }

    public void Heal(int amount)
    {
        Console.WriteLine("Curarse");
        
        CurrentHit += amount;
        if (CurrentHit > MaxHitPoints)
        {
            CurrentHit = MaxHitPoints;
        }
    }

    private void ReceiveDamage(int damage)
    {
        Console.WriteLine("Daño recibido");
        CurrentHit -= damage;
    }

    public void AddItem(IItem item)
    {
        Inventory.Add(item);
        item.Apply(this);
        Console.WriteLine("Item añadido");
    }
    
}