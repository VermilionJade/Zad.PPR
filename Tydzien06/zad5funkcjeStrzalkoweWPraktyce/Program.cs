string heroName = "Ada";
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;
int CalculateDamage(int strength, int weaponDamage) => strength + weaponDamage;
bool isRunning = false;

bool IsGameOver(int health) => health <= 0;

void ShowMenu()
{
    Console.WriteLine("1. Atak");
    Console.WriteLine("2. Leczenie");
    Console.WriteLine("3. Ucieczka");
}

string ReadCommand()
{
    while (true)
    {
        Console.Write("Wybór akcji: ");
        string? command = Console.ReadLine();

        if (command == "1")
        {
            
            Console.WriteLine($"Zadajesz {CalculateDamage(strength, weaponDamage)} obrażeń manekinowi.");
        }
        else if (command == "2")
        {
            health = Heal(health, 10, maxHealth);
            Console.WriteLine($"Odpoczywasz. Masz teraz {health} HP.");
        }
        else if (command == "3")
        {
            isRunning = true;
            return "Uciekasz z walki.";
        }
        else
        {
            Console.WriteLine("Nieznana komenda.");
        }
    }
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


while (IsGameOver(health) == false && isRunning == false)
{
    Console.WriteLine("====================");
    Console.WriteLine($"Bohater: {heroName}");
    Console.WriteLine($"Zdrowie: {health}/{maxHealth}");
    Console.WriteLine($"Złoto: {gold}");
    Console.WriteLine("====================");
    ShowMenu();
    ReadCommand();
    if (IsGameOver(health))
    {
        Console.WriteLine("Koniec gry! Twój bohater zginął.");
    }
    else if (isRunning)
    {
        Console.WriteLine("Uciekłeś z walki.");
    }
}

List<string> inventory = new List<string> { "miecz", "mikstura", "łuk" };

List<string> longNames = inventory.FindAll(item => item.Length > 5);
bool hasPotion = inventory.Exists(item => item == "mikstura");

Console.WriteLine("Przedmioty w ekwipunku o długości większej niż 5 znaków:");
foreach (string item in longNames)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Czy masz miksturę? {hasPotion}");

List<string> inventory2 = new List<string> { "miecz", "mikstura", "łuk" };

List<string> longNames2 = inventory2.FindAll(item => item.Length >= 5);
bool hasSword = inventory2.Exists(item => item == "miecz");
Console.WriteLine("Przedmioty w ekwipunku o długości większej lub równej 5 znaków:");
foreach (string item in longNames2)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Czy masz miecz? {hasSword}");