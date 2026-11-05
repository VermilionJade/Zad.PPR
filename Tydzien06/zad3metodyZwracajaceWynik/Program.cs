int CalculateDamage(int strength, int weaponDamage)
{
    return strength + weaponDamage;
}

int Heal(int health, int amount, int maxHealth)
{
    if (amount <= 0)
    {
        return health;
    }
    int newHealth = health + amount;
    return Math.Min(newHealth, maxHealth);
}

bool IsGameOver(int health)
{
    return health <= 0;
}

Console.WriteLine($"Obrażenia: {CalculateDamage(6, 3)}");
Console.WriteLine($"Obrażenia: {CalculateDamage(0, 4)}");
Console.WriteLine($"Nowe zdrowie: {Heal(70, 10, 100)}");
Console.WriteLine($"Nowe zdrowie: {Heal(95, 10, 100)}");
Console.WriteLine($"Is game over: {IsGameOver(0)}");
Console.WriteLine($"Is game over: {IsGameOver(1)}");