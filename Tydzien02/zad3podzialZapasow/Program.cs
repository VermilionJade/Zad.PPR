Console.WriteLine("Ilość racji żywnościowych: ");
int Food = int.Parse(Console.ReadLine());
Console.WriteLine("\nLiczba członków drużyny: ");
int TeamMembers = int.Parse(Console.ReadLine());
Console.WriteLine("\nLiczba dni ekspedycji: ");
int Days = int.Parse(Console.ReadLine());

int FoodPerPerson = Food / TeamMembers;
int FoodLeft = Food % TeamMembers;
double FoodPerDay = (double)Food / Days;
double FoodPerPersonPerDay = (double)FoodPerPerson / Days;

Console.WriteLine($"\nKażdy członek drużyny otrzyma {FoodPerPerson} racji żywnościowych.");
Console.WriteLine($"Po podziale zostanie {FoodLeft} racji żywnościowych.");
Console.WriteLine($"Każdy członek drużyny otrzyma średnio {FoodPerPersonPerDay} racji żywnościowych na dzień.");
Console.WriteLine($"Średnia ilość racji żywnościowych na dzień dla całej drużyny wynosi {FoodPerDay}.");