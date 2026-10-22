Console.Write("While: ");
int liczba = 1;

while (liczba <= 10)
{
    Console.Write($"{liczba}, ");
    liczba++;
}

liczba = 0;

Console.Write("\n\nDo-while: ");

do
{
    liczba++;
    Console.Write($"{liczba}, ");
}
while (liczba < 10);

liczba = 0;

Console.WriteLine("\n\nFor: \n Rosnąco: ");

for (liczba = 1; liczba <= 10; liczba++)
{
    Console.Write($"{liczba}, ");
}

liczba = 0;
Console.WriteLine("\n Malejąco: ");

for (liczba = 10; liczba >= 1; liczba--)
{
    Console.Write($"{liczba}, ");
}

liczba = 0;
Console.WriteLine("\n Parzyste: ");

for (liczba = 0; liczba <= 20; liczba +=2 )
{
    Console.Write($"{liczba}, ");
}