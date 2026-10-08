int maxHP = 100;
Console.WriteLine("Enter the hero's current HP: ");
int HP = int.Parse(Console.ReadLine());
Console.WriteLine("\nEnter the number of Elixirs: ");
int Elixir = int.Parse(Console.ReadLine());
Console.WriteLine("\nDoes the hero have a key? (true/false): ");
bool hasKey = bool.Parse(Console.ReadLine());
Console.WriteLine("\nDoes the hero have a map? (true/false): ");
bool hasMap = bool.Parse(Console.ReadLine());

bool isAlive = HP > 0;
bool hasFullHealth = HP == maxHP;
bool HasElixir = Elixir >= 1;
bool HasNavigationTools = hasKey || hasMap;
bool ReadyForAdventure = isAlive && HasElixir && HasNavigationTools;
bool needsHealing = !hasFullHealth;

Console.WriteLine($"\n\nAlive: {isAlive}");
Console.WriteLine($"Full Health: {hasFullHealth}");
Console.WriteLine($"Has Elixir: {HasElixir}");
Console.WriteLine($"Has Key or Map: {HasNavigationTools}");
Console.WriteLine($"Ready for Adventure: {ReadyForAdventure}");
Console.WriteLine($"Needs Healing: {needsHealing}");