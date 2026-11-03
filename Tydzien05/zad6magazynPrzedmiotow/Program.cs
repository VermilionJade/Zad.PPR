
Dictionary<string, int> magazyn = new Dictionary<string, int>
{
    { "Mikstura", 3 },
    { "Pochodnia", 2 },
    { "Klucz", 1 }
};
bool zakoncz = false;

while(zakoncz == false)
{
    Console.Write("===MENU===\n1. Pokaz magazyn\n2. Przyjmij dostawe\n3. Wydaj przedmiot\n4. Usuń pustą pozycję\n5. Zakoncz\n\nWybierz opcję: ");
    string userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "1":
            Console.WriteLine("===MAGAZYN===");
            foreach (var item in magazyn)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            break;
        case "2":
            Console.Write("Podaj nazwę przedmiotu: ");
            string itemName = Console.ReadLine();
            Console.Write("Podaj ilość: ");
            int itemQuantity = int.Parse(Console.ReadLine());
            if (magazyn.ContainsKey(itemName))
            {
                magazyn[itemName] += itemQuantity;
            }
            else
            {
                magazyn[itemName] = itemQuantity;
            }
            break;
        case "3":
            Console.Write("Podaj nazwę przedmiotu: ");
            string itemToRemove = Console.ReadLine();
            if (magazyn.ContainsKey(itemToRemove))
            {
                Console.Write("Podaj ilość do wydania: ");
                int quantityToRemove = int.Parse(Console.ReadLine());
                if (magazyn[itemToRemove] >= quantityToRemove)
                {
                    magazyn[itemToRemove] -= quantityToRemove;
                    if (magazyn[itemToRemove] == 0)
                    {
                        Console.WriteLine($"Wydano {quantityToRemove} {itemToRemove}. Pozycja {itemToRemove} jest teraz pusta.");
                    }
                    else
                    {
                        Console.WriteLine($"Wydano {quantityToRemove} {itemToRemove}. Pozostało {magazyn[itemToRemove]} {itemToRemove} w magazynie.");
                    }
                }
                else
                {
                    Console.WriteLine($"Nie można wydać {quantityToRemove} {itemToRemove}. W magazynie jest tylko {magazyn[itemToRemove]}.");
                }
            }
            else
            {
                Console.WriteLine($"Nie ma takiego przedmiotu w magazynie.");
            }
            break;
        case "4":
            List<string> emptyItems = new List<string>();
            foreach (var item in magazyn)
            {
                if (item.Value == 0)
                {
                    emptyItems.Add(item.Key);
                }
            }
            if (emptyItems.Count > 0)
            {
                foreach (var emptyItem in emptyItems)
                {
                    magazyn.Remove(emptyItem);
                    Console.WriteLine($"Usunięto pustą pozycję: {emptyItem}");
                }
            }
            else
            {
                Console.WriteLine("Brak pustych pozycji do usunięcia.");
            }
            break;
        case "5":
            zakoncz = true;
            break;
        default:
            Console.WriteLine("Niepoprawna opcja. Wybierz ponownie.");
            break;
    }
}
Console.WriteLine("Koniec programu.");