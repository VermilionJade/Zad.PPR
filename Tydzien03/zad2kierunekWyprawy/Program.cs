Console.Write("Podaj kierunek wyprawy (N, S, E, W): ");
string kierunek = Console.ReadLine();

if (kierunek == "N" || kierunek == "n" || kierunek == "Północ" || kierunek == "północ")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Kierunek wyprawy: Północ");
    Console.ResetColor();
}
else if (kierunek == "S" || kierunek == "s" || kierunek == "Południe" || kierunek == "południe")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Kierunek wyprawy: Południe");
    Console.ResetColor();
}
else if (kierunek == "E" || kierunek == "e" || kierunek == "Wschód" || kierunek == "wschód")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Kierunek wyprawy: Wschód");
    Console.ResetColor();
}
else if (kierunek == "W" || kierunek == "w" || kierunek == "Zachód" || kierunek == "zachód")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Kierunek wyprawy: Zachód");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Niepoprawny kierunek wyprawy.");
    Console.ResetColor();
}
