Console.WriteLine("Ile dni trwa wyprawa(1-7)? ");
int dniWyprawy = 0;
int dniPowyzej10sztuk = 0;
int dzien = 0;
int sumaZlota = 0;
for (dzien = 1,dniWyprawy = int.Parse(Console.ReadLine()); dniWyprawy > 0; dniWyprawy--, dzien +=1)
{
    Console.WriteLine($"Ilość złota znaleziona {dzien} dnia: ");
    int zloto = int.Parse(Console.ReadLine());
    sumaZlota = sumaZlota + zloto;
    if (zloto>=10)
    {
        dniPowyzej10sztuk++;
    }
    zloto = 0;
}

Console.WriteLine($"Łącznie znaleziono {sumaZlota} sztuk złota.");
Console.WriteLine($"Dni z wynikiem powyżej 10: {dniPowyzej10sztuk}");