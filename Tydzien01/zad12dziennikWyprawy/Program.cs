Console.Write("Podaj imię bohatera: ");
string Hero = Console.ReadLine();
Console.Write("\nPodaj kraine do której wyrusza bohater: ");
string Land = Console.ReadLine();
Console.Write("\nPodaj liczbę dni wyprawy: ");
int Days = int.Parse(Console.ReadLine());
Console.Write("\nPodaj liczbę zdobytych punktów doświadczenia: ");
double Experience = double.Parse(Console.ReadLine());
Console.Write("\nPodaj liczbę zdobytego złota: ");
double Gold = double.Parse(Console.ReadLine());

double AverageExperience = (Experience / Days);
double AverageGold = (Gold / Days);

Console.WriteLine ("+--------------------------------+");
Console.WriteLine("| \tDZIENNIK WYPRAWY ");
Console.WriteLine ("+--------------------------------+");
Console.WriteLine("| Bohater: " + Hero );
Console.WriteLine("| Kraina: " + Land );
Console.WriteLine("| Liczba dni wyprawy: " + Days );
Console.WriteLine("| Liczba zdobytego złota: " + Gold );
Console.WriteLine("| Liczba zdobytego doświadczenia: " + Experience );
Console.WriteLine ("+--------------------------------+");
Console.WriteLine ("| Średnia ilość złota zdobytego na dzień: " + AverageGold );
Console.WriteLine ("| Średnia ilość doświadczenia zdobytego na dzień: " + AverageExperience );
Console.WriteLine ("+--------------------------------+");
