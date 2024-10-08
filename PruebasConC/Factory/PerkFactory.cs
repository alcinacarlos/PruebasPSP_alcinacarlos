using PruebasConC.Perks;

namespace PruebasConC.factory
{
    public static class PerkFactory
    {
        public static Perk IncreasedArmor(int amount)
        {
            return new Perk(
                "Increased Armor",
                creature => creature.CurrentArmor += amount,
                creature => creature.CurrentArmor -= amount
            );
        }

        public static Perk ExtraDamage(int amount)
        {
            return new Perk(
                "Extra Damage",
                creature => creature.CurrentDamage += amount,
                creature => creature.CurrentDamage -= amount
            );
        }

        public static Perk HealthBoost(int amount)
        {
            return new Perk(
                "Health Boost",
                creature => creature.MaxHitPoints += amount,
                creature => creature.MaxHitPoints -= amount
            );
        }
    }
}
