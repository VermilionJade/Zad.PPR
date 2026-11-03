
List<string> items = new List<string>
{
    "Miecz",
    "Tarcza",
    "Mikstura",
    "Klucz"
};

for (int i = 0; i < items.Count; i++)
{
    Console.WriteLine($"{i + 1}. {items[i]}");
}

int numberToDelete;

while (true)
{
    Console.Write("Wybierz przedmiot do usuniecia: ");
    bool isANumber = int.TryParse(Console.ReadLine(), out numberToDelete);
    if (!isANumber)
    {
        Console.WriteLine("Wpisz liczbe calkowita.");
        continue;
    }

    if (numberToDelete < 1 || numberToDelete > items.Count)
    {
        Console.WriteLine($"Wpisz liczbe od 1 do {items.Count}.");
        continue;
    }
    break;
}
string itemRemoved = items[numberToDelete - 1];
items.RemoveAt(numberToDelete - 1);
Console.WriteLine($"Usunieto przedmiot: {itemRemoved}");