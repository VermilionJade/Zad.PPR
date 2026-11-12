Player PlayerA = new Player("Player A", 100, 50);
Player PlayerB = new Player("Player B", 200, 100);

Console.WriteLine("Player A: Health = " + PlayerA.Health + ", Gold = " + PlayerA.Gold);
Console.WriteLine("Player B: Health = " + PlayerB.Health + ", Gold = " + PlayerB.Gold);

PlayerA.TakeDamage(30);
PlayerB.Heal(20);
Console.WriteLine("After taking damage and healing:");
Console.WriteLine("Player A: Health = " + PlayerA.Health + ", Gold = " + PlayerA.Gold);
Console.WriteLine("Player B: Health = " + PlayerB.Health + ", Gold = " + PlayerB.Gold);

Enemy EnemyA = new Enemy("Enemy A", 100, 20);
Enemy EnemyB = new Enemy("Enemy B", 150, 30);
Console.WriteLine("Enemy A: Health = " + EnemyA.Health + ", Damage = " + EnemyA.Damage);
Console.WriteLine("Enemy B: Health = " + EnemyB.Health + ", Damage = " + EnemyB.Damage);

EnemyA.TakeDamage(50);
EnemyB.TakeDamage(200);
Console.WriteLine("After taking damage:");
Console.WriteLine("Enemy A: Health = " + EnemyA.Health);
Console.WriteLine("Enemy B: Health = " + EnemyB.Health);