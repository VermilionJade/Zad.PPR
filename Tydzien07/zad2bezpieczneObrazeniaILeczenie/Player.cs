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
        if (damage < 0)
        {
            Console.WriteLine("Damage cannot be negative.");
        }
        else if (damage == 0)
        {
            Console.WriteLine("Damage cannot be zero.");
        }
        else if (Health <= 0)
        {
            Console.WriteLine("Player is already dead.");
        }
        else
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
            }
        }


    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Healing amount cannot be negative.");
        }
        else if (amount == 0)
        {
            Console.WriteLine("Healing amount cannot be zero.");
        }
        else
        {
            Health += amount;
        }

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
