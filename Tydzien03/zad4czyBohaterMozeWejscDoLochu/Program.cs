Console.Write("Punkty życia(liczba całkowita): ");
int punktyZycia = int.Parse(Console.ReadLine());
Console.Write("Czy ma klucz?(True/False): ");
bool maKlucz = bool.Parse(Console.ReadLine());
Console.Write("Czy ma hasło(True/False)? ");
bool maHaslo = bool.Parse(Console.ReadLine());

if (punktyZycia <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("Bohater nie może wejść do lochu, bo nie żyje");
    Console.ResetColor();
}
else if (punktyZycia > 0 && (!maKlucz) && (!maHaslo))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Bohater nie może wejść do lochu, bo nie ma ani hasła ani klucza");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Bohater może wejść do lochu.");
    Console.ResetColor();

}
