int ziola = 0;
int krysztaly = 0;
int plannedMikstury = 0;
Console.Write ("Ile mikstur chcesz zrobic? ");
plannedMikstury = int.Parse(Console.ReadLine()!);

krysztaly = (plannedMikstury * 3);
ziola = (plannedMikstury * 2);

Console.WriteLine("Do zrobienia " + plannedMikstury + " mikstur potrzebujesz: ");
Console.WriteLine("- " + krysztaly + " krysztalow");
Console.WriteLine("- " + ziola + " ziol");