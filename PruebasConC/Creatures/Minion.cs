using PruebasConC;

public class Minion(string name, int baseDamage, int baseArmor, int maxHitPoints): Creature(name, baseDamage, baseArmor, maxHitPoints)
{
    public override int Attack(Creature creature)
    {
        return creature.Defense(CurrentDamage);
    }

    public override int Defense(int damage)
    {
        var damagePoints = damage - CurrentArmor;
        if (damagePoints <= 0) return 0;
        ReceiveDamage(damagePoints);
        return damagePoints;
    }

    public void Heal(int amount)
    {
        CurrentHit += amount;
        if (CurrentHit > maxHitPoints)
        {
            CurrentHit = maxHitPoints;
        }
    }

    private void ReceiveDamage(int damage)
    {
        CurrentHit -= damage;
    }

    public void AddItem(IItem item)
    {
        _inventory.Add(item);
        item.Apply(this);
    }

    public void RemoveItem(IItem item)
    {
        _inventory.Remove(item);
        item.Cancel(this);
    }
}