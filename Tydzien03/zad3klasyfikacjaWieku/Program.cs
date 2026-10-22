Console.Write("Podaj wiek osoby: ");
int wiek = int.Parse(Console.ReadLine());

if ((wiek <= 12) && (wiek >= 0))
{
    Console.WriteLine("\nDziecko");
}
else if ((wiek <= 17) && (wiek >= 13))
{
    Console.WriteLine("\nNastolatek");
} 
else if ((wiek <= 64) && (wiek >= 18))
{
    Console.WriteLine("\nDorosły");
}
else if ((wiek >= 65) && (wiek <= 120))
{
    Console.WriteLine("\nSenior");
}
else 
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Nieprawidłowa wartość.");
    Console.ResetColor();
}