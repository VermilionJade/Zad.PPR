
while (true)
{
    Console.Write("Podaj liczbe tur (1-10): ");
    bool isANumber = int.TryParse(Console.ReadLine(), out int numberOfTurns);
    if (!isANumber)
    {
        Console.WriteLine("Wpisz liczbe calkowita.");
        continue;
    }

    if (numberOfTurns < 1 || numberOfTurns > 10)
    {
        Console.WriteLine("Wpisz liczbe od 1-10.");
        continue;
    }
    break;
}