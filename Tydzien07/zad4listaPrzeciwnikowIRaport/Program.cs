List<Enemy> enemies = new List<Enemy>
{
    new Enemy("Goblin", 30, 8),
    new Enemy("Nietoperz", 20, 5),
    new Enemy("Ork", 70, 15),
    new Enemy("Pająk", 35, 10),
    new Enemy("Szkielet", 15, 20)
};

int i = 0;
int enemyTotalHealth = 0;
int highestEnemyHealth = 0;
int NumberOfKilledEnemies = 0;

void DisplayReport()
{
    Console.WriteLine("Raport:");
    foreach (Enemy enemy in enemies)
    {
        if (enemy.IsAlive())
        {
            Console.WriteLine($"Przeciwnik {i + 1}: {enemy.Name}\nHP: {enemy.Health}\nDMG: {enemy.Damage}\n\n");
            enemyTotalHealth += enemy.Health;
            if (enemy.Health > highestEnemyHealth)
            {
                highestEnemyHealth = enemy.Health;
            }
        }
        else
        {
            Console.WriteLine($"Przeciwnik {i + 1}: {enemy.Name} jest martwy.\n\n");
            NumberOfKilledEnemies++;
        }
    }
    Console.WriteLine($"Łączne zdrowie przeciwników: {enemyTotalHealth}");
    Console.WriteLine($"Najwyższe zdrowie przeciwnika: {highestEnemyHealth}");
    Console.WriteLine($"Liczba zabitych przeciwników: {NumberOfKilledEnemies}");
    }


DisplayReport();
