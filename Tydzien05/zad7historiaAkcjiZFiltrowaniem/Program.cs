//DO ZROBIENIA i dalej

bool programEnd = false;
List<string> actionHistory = new List<string>();
while (programEnd == false)
{
    Console.WriteLine("1 - Eksploruj\n2 - Odpocznij\n3 - Znajdz przedmiot\n4 - Pokaz cala historie\n5 - Pokaz ostatnie trzy wpisy\n6 - Pokaz wybrana akcje\n7 - Wyczysc historie\n8 - Zakoncz");
    string playerChoice = Console.ReadLine();

    switch (playerChoice)
    {
        case "1":
            Console.WriteLine("Eksplorujesz...");
            actionHistory.Add("Eksploracja");
            break;
        case "2":
            Console.WriteLine("Odpoczywasz...");
            actionHistory.Add("Odpoczynek");
            break;
        case "3":
            Console.WriteLine("Znajdujesz przedmiot...");
            actionHistory.Add("Znaleziono przedmiot");
            break;
        case "4":
            Console.WriteLine("=== Historia Akcji ===");
            for (int i = 0; i < actionHistory.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + actionHistory[i]);
            }
            Console.WriteLine("===========================");
            break;
        case "5":
            Console.WriteLine("=== Ostatnie trzy wpisy ===");
            var lastThreeActions = actionHistory.Skip(Math.Max(0, actionHistory.Count - 3));
            for (int i = 0; i < lastThreeActions.Count(); i++)
            {
                Console.WriteLine(((i+1) + ". " + lastThreeActions.ElementAt(i)));
            }
            Console.WriteLine("============================");
            break;
            
        case "6":
            Console.Write("Podaj akcje do wyszukania: ");
            string searchAction = Console.ReadLine();
            var filteredActions = actionHistory.Where(a => a.Contains(searchAction));
            Console.WriteLine($"=== Akcje zawierajace '{searchAction}' ===");
            for (int i = 0; i < filteredActions.Count(); i++)
            {
                Console.WriteLine(((i+1) + ". " + filteredActions.ElementAt(i)));
            }
            Console.WriteLine("============================");
            break;
        case "7":
            actionHistory.Clear();
            Console.WriteLine("Historia akcji zostala wyczyszczona.");
            break;
        case "8":
            programEnd = true;
            break;
        default:
            Console.WriteLine("Nieprawidlowy wybor. Sprobuj ponownie.");
            break;
    }
}
Console.WriteLine("Program zakonczony.");