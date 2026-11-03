

Console.WriteLine("Podaj ilość tur od 1-10: ");
int numberOfTurns = int.Parse(Console.ReadLine());
while ((numberOfTurns<=0)||(numberOfTurns>10))
{
    Console.WriteLine("Podano niewłaściwą wartość.");
    Console.WriteLine("Podaj ilość tur od 1-10: ");
    numberOfTurns = int.Parse(Console.ReadLine());
}
int[] turn = new int[numberOfTurns];

for (int i = 0; i < turn.Length; i++)
{
    Console.WriteLine("Podaj ilość zlota zdobytych w turze " + (i + 1) + ": ");
    turn[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < turn.Length; i++)
{
    sum += turn[i];
}
Console.WriteLine("Łączna ilość zdobytego zlota: " + sum);

int max = turn[0];
int min = turn[0];
for (int i = 1; i < turn.Length; i++)
{
    if (turn[i] > max)
    {
        max = turn[i];
    }
    if (turn[i] < min)
    {
        min = turn[i];
    }
}
Console.WriteLine("Maximum: " + max);
Console.WriteLine("Minimum: " + min);

int firstBestTurn = -1;

for (int i = 0; i < turn.Length; i++)
{
    if (turn[i] == max)
    {
        firstBestTurn = i;
        break;
    }
}
Console.WriteLine("Pierwszy najlepszy wynik: Tura " + (firstBestTurn + 1));

int howManyBestTurns = 0;
foreach (int i in turn)
{
    if (i == max)
    {
        howManyBestTurns++;
    }
}
Console.WriteLine("Liczba tur z maksimum: " + howManyBestTurns);

for (int i = 0; i < turn.Length; i++)
{
    if (turn[i] == 0)
    {
        Console.WriteLine("Pierwsza tura bez zlota: " + (i + 1));
    }
}