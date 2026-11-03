int heroHP = 60;
int opponentHP = 45;
int numberOfMixture = 2;
int numberOfTurn = 1;
int heroDMG = 12;
int opponentDMG = 7;
int mixtureHeal = 15;
bool runAway = false;
int playerFinalChoice;
while (heroHP > 0 && opponentHP>0 && !runAway)
{
    Console.WriteLine($"---\nTura {numberOfTurn}: \n---");
    Console.WriteLine($"Hero HP: {heroHP}\nOpponentHP: {opponentHP}\n---");

        while (true)
    {
        Console.WriteLine("Wybierz akcje(wpisz numer akcji):\n1. Atak\n2. Mikstura(leczenie)\n3. Ucieczka\n");
        bool isANumber = int.TryParse(Console.ReadLine(), out int playerChoice);
        if (!isANumber)
        {
            Console.WriteLine("Wpisz poprawna liczbe");
            continue;
        }

        if (playerChoice < 1 || playerChoice > 3)
        {
            Console.WriteLine("Wybierz opcje 1, 2 lub 3.");
            continue;
        }
        playerFinalChoice = playerChoice;
        break;
    }
    switch (playerFinalChoice)
    {
        case 1:
            Console.WriteLine($"Zadajesz przeciwnikowi {heroDMG}DMG!");
            opponentHP -= heroDMG;
            break;
        case 2:
            if (numberOfMixture > 0)
            {
                Console.WriteLine($"Uzywasz mikstury i odzyskujesz {mixtureHeal}HP!");
                heroHP += mixtureHeal;
                numberOfMixture--;
            }
            else
            {
                Console.WriteLine("Nie masz juz mikstur!");
            }
            break;
        case 3:
            Console.WriteLine("Uciekasz z walki!");
            runAway = true;
            break;
    }
    if (runAway==true || opponentHP <= 01)
    {
        break;
    }
    Console.WriteLine($"Przeciwnik zadaje {opponentDMG}DMG!");
    heroHP -= opponentDMG;
    numberOfTurn++;
}
if (heroHP <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Przegrywasz!");
    Console.ResetColor();
}
else if (opponentHP <= 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Wygrywasz!");
    Console.ResetColor();
}
else if (runAway)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Uciekles z walki!");
    Console.ResetColor();
}