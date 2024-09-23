using PruebasConC;

public class Character()
{
    public string Name;
    public int BaseDamage;
    public int BaseArmor;
    public int MaxHitPoints;
    public int CurrentHit;
    public int CurrentDamage;
    public int CurrentArmor;
    public List<IItem> Inventory;

    public Character(string Name, int BaseDamage, int BaseArmor)
    {
        Name = Name;
        BaseDamage = BaseDamage;
        BaseArmor = BaseArmor;
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
}