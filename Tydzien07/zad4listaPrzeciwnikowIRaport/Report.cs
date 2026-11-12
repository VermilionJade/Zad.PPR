public class Report
{
    public int EnemyTotalHealth { get; set; }
    public int HighestEnemyHealth { get; set; }
    public int NumberOfKilledEnemies { get; set; }

    public Report(int enemyTotalHealth, int highestEnemyHealth, int numberOfKilledEnemies)
    {
        EnemyTotalHealth = enemyTotalHealth;
        HighestEnemyHealth = highestEnemyHealth;
        NumberOfKilledEnemies = numberOfKilledEnemies;
    }
}