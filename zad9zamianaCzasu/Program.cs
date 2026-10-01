
Console.Write ("Podaj całkowitą liczbę sekund: ");
int totalSeconds = int.Parse(Console.ReadLine()!);

int minutes = (totalSeconds / 60);
int seconds = (totalSeconds % 60);
Console.WriteLine("\nCzas: " + minutes + " minut " +seconds + " sekund");