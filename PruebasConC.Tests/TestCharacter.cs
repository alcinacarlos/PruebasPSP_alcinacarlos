using PruebasConC.Weapons;

namespace PruebasConC.Tests;
using Xunit;

public class CharacterTests
{
    [Fact]
    public void Character_Attack_ShouldDealCorrectDamage()
    {
        var character = new Character("Test Character", 10, 5, 50);
        var target = new Character("Target Creature", 10, 3, 50);

        int damageDealt = character.Attack(target);

        Assert.Equal(7, damageDealt); // 10 - 3 = 7
        Assert.Equal(43, target.CurrentHit); // 50 - 7 = 43
    }

    [Fact]
    public void Character_Defense_ShouldBlockCorrectAmountOfDamage()
    {
        var character = new Character("Test Character", 10, 5, 50);

        int damageTaken = character.Defense(7);

        Assert.Equal(2, damageTaken); // 7 - 5 = 2
        Assert.Equal(48, character.CurrentHit); // 50 - 2 = 48
    }

    [Fact]
    public void Character_Heal_ShouldNotExceedMaxHitPoints()
    {
        var character = new Character("Test Character", 10, 5, 50);
        character.Defense(20); // Reduce HP to 30 (50 - 20)

        character.Heal(25);

        Assert.Equal(50, character.CurrentHit); // No debe exceder los 50 HP
    }
    
    [Fact]
    public void Character_AddItem_ShouldIncreaseStats()
    {
        var character = new Character("Test Character", 10, 5, 50);
        var axe = new Axe("Test Axe", 15);
        character.AddItem(axe);

        Assert.Equal(25, character.CurrentDamage);
    }
    
    [Fact]
    public void Character_AddItem_ShouldReduceStats()
    {
        var character = new Character("Test Character", 10, 5, 50);
        var axe = new Axe("Test Axe", 15);
        character.AddItem(axe);
        character.RemoveItem(axe);

        Assert.Equal(10, character.CurrentDamage);
    }
}