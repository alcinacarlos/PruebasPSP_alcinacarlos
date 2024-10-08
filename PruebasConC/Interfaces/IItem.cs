namespace PruebasConC;

public interface IItem
{
    void Apply(Creature creature);
    void Cancel(Creature creature);
}