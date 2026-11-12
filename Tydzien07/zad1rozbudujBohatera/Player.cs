public class Player
{
    public string Name { get; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Gold { get; set; }
    public int Level { get; set; } = 0;
    public int Experience { get; set; } = 0;

    public Player(string name, int maxHealth, int gold)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Gold = gold;
        Level = 0;
        Experience = 0;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
    }

    public void Heal(int amount)
    {
        Health += amount;

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }

    public void LevelUp()
    {
        Level++;
        MaxHealth += 10;
        Health += 10;
    }
    public void GainExperience(int amount)
    {
        Experience += amount;

        if (Experience >= 1000)
        {
            LevelUp();
            Experience -= 1000;
        }
    }
}
