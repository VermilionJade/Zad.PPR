using System.ComponentModel;

int[] zlotoWTurach = { 5, 12, 0, 8, 15 };

int numer = 1;
foreach (int zloto in zlotoWTurach)
{
    Console.WriteLine($"Tura {numer}: {zloto} sztuk złota.");
    numer++;
}



int index = 0;
int suma = 0;
for (index = 0; index < zlotoWTurach.Length; index++)
{
    suma = suma + zlotoWTurach[index];
}
Console.WriteLine($"Łącznie: {suma}");



index = 0;
double srednia = 0;
double sumaDoSredniej = 0;

for (index = 0; index < zlotoWTurach.Length; index++)
{
    sumaDoSredniej = sumaDoSredniej + zlotoWTurach[index];
}
srednia = (double)sumaDoSredniej / (double)zlotoWTurach.Length;

Console.WriteLine($"Średnio na turę: {(double)srednia}");


index = 0;
int higherThanTen = 0;

for (index = 0; index < zlotoWTurach.Length; index++)
{
    if (zlotoWTurach[index]>= 10)
    {
        higherThanTen++;
    }
}

Console.WriteLine($"Tury z wynikiem co najmniej 10: {higherThanTen}");


Console.Write("Od końca: ");

for (index = zlotoWTurach.Length-1; index > -1; index--)
{
    Console.Write($"{zlotoWTurach[index]} ");
}