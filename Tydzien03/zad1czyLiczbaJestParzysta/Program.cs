Console.Write ("Podaj liczbę całkowitą: ");
int liczba = int.Parse(Console.ReadLine());

if (liczba % 2 == 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Liczba jest parzysta.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Liczba jest nieparzysta.");
    Console.ResetColor();
}
