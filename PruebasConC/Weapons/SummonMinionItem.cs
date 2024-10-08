namespace PruebasConC.Weapons;

public class SummonMinionItem : IItem
{
    private Minion _minion;
    public string Name { get; set; }

    public SummonMinionItem(string name)
    {
        Name = name;
        _minion = MinionFactory.GenerateRandomMinion();
    }

    public void Apply(Creature creature)
    {
        if (creature is Character character)
        {
            character.SummonMinion(_minion);
        }
    }

    public void Cancel(Creature creature)
    {
        if (creature is Character character)
        {
            character.RemoveMinion(_minion);
        }
    }
}
