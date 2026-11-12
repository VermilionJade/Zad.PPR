Player player = new Player(Console.ReadLine(), 100, 50);
Enemy enemy = new Enemy("Goblin", 50, 20);

Console.WriteLine($"Witaj, {player.Name}! Twoje zdrowie: {player.Health}/{player.MaxHealth}, Zloto: {player.Gold}");
Console.WriteLine($"Spotykasz wroga: {enemy.Name}! Jego zdrowie: {enemy.Health}");

player.TakeDamage(-10);
player.TakeDamage(0);
player.TakeDamage(30);

player.Heal(-20);
player.Heal(0);
player.Heal(30);

enemy.TakeDamage(-15);
enemy.TakeDamage(0);
enemy.TakeDamage(60);
if (!enemy.IsAlive())
{
    Console.WriteLine($"Pokonałeś wroga: {enemy.Name}!");
}
else
{
    Console.WriteLine($"Wrog: {enemy.Name} nadal zyje! Jego zdrowie: {enemy.Health}");
}