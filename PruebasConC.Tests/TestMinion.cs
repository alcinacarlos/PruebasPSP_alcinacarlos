using PruebasConC.Weapons;

namespace PruebasConC.Tests;
using Xunit;

public class MinionTests
{
    [Fact]
    public void Minion_Attack_ShouldDealCorrectDamage()
    {
        var minion = new Minion("Test Minion", 10, 5, 50);
        var target = new Minion("Target Creature", 10, 3, 50);
        
        int damageDealt = minion.Attack(target);

        Assert.Equal(7, damageDealt); // 10 - 3 = 7
        Assert.Equal(43, target.CurrentHit); // 50 - 7 = 43
    }

    [Fact]
    public void Minion_ShouldBlockCorrectAmountOfDamage()
    {
        var minion = new Minion("Test Minion", 10, 5, 50);
        
        int damageTaken = minion.Defense(7);

        Assert.Equal(2, damageTaken); // 7 - 5 = 2
        Assert.Equal(48, minion.CurrentHit); // 50 - 2 = 48
    }

    [Fact]
    public void Minion_Heal_ShouldNotExceedMaxHitPoints()
    {
        var minion = new Minion("Test Minion", 10, 5, 50);
        minion.Defense(20);

        minion.Heal(25);

        Assert.Equal(50, minion.CurrentHit);
    }
    
    [Fact]
    public void Minion_AddItem_ShouldIncreaseStats()
    {
        var minion = new Minion("Test Minion", 10, 5, 50);
        var axe = new Axe("Test Axe", 15);
        minion.AddItem(axe);

        Assert.Equal(25, minion.CurrentDamage);
    }
    
    [Fact]
    public void Minion_AddItem_ShouldReduceStats()
    {
        var minion = new Minion("Test Minion", 10, 5, 50);
        var axe = new Axe("Test Axe", 15);
        minion.AddItem(axe);
        minion.RemoveItem(axe);

        Assert.Equal(10, minion.CurrentDamage);
    }
}