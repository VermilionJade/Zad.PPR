Console.WriteLine("Podaj ilość tur od 1-10: ");
int numberOfTurns = int.Parse(Console.ReadLine());
while ((numberOfTurns<=0)||(numberOfTurns>10))
{
    Console.WriteLine("Podano niewłaściwą wartość.");
    Console.WriteLine("Podaj ilość tur od 1-10: ");
    numberOfTurns = int.Parse(Console.ReadLine());
}
