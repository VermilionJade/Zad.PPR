decimal cenaNocleg = 0;
int liczbaNocy = 0;

Console.Write("Podaj cene noclegu: ");
cenaNocleg = decimal.Parse(Console.ReadLine()!);
Console.Write("\nPodaj liczbe nocy: ");
liczbaNocy = int.Parse(Console.ReadLine()!);    

decimal kosztNoclegu = cenaNocleg * liczbaNocy;
Console.WriteLine("\nKoszt noclegu wynosi: " + kosztNoclegu);