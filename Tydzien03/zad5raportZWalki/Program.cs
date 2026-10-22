using System.IO.Compression;

Console.Write("Aktualne punkty życia bohatera: ");
int punktyZycia = int.Parse(Console.ReadLine());
Console.Write("Podstawowe obrazenia broni: ");
int obrazeniaBroni = int.Parse(Console.ReadLine());
Console.Write("Czy bohater ma miksture(true/false): ");
bool maMiksture = bool.Parse(Console.ReadLine());

Console.Write("Wybierz akcje(aby wybrać akcje wpisz liczbę dopisaną do wybranej opcji): \n 1. Atak\n 2. Leczenie\n 3. Ucieczka\n\n");
string akcja = Console.ReadLine()!;

if (punktyZycia <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Przegrana - Bohater nie żyje");
    Console.ResetColor();
}
else
{
    switch (akcja)
    {
        case "1":
            Console.WriteLine($"Ilość zadanych obrażeń: {obrazeniaBroni}");
            break;
        case "2":
            if (maMiksture == true)
            {
                maMiksture = false;
                punktyZycia = punktyZycia + 5;
                Console.WriteLine($"Bohater wyleczony. Aktualna ilośc HP: {punktyZycia}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Akcja nieudana, Bohater nie posiada mikstury");
                Console.ResetColor();
            }
            break;
        case "3":
            Console.WriteLine("Bohater uciekł!");
            break;
        default:
            Console.WriteLine("Nieznana akcja.");
            break;
    }
}

if (punktyZycia > 0 && punktyZycia < 20)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Uwaga, Niskie HP. Aktualne HP: {punktyZycia}");
    Console.ResetColor();
}

