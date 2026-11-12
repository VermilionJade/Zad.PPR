public class Enemy
{
    public string Name { get; }
    public int Health { get; set; }
    public int Damage { get; }

    public Enemy(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
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
            Console.WriteLine("Enemy is already dead.");
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

    public bool IsAlive()
    {
        return Health > 0;
    }


}


