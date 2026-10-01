int monety = 0;
int bohaterzy = 0;
int lupNaLeb = 0;
int pozostaleMonety = 0;
Console.Write ("Ile monet chcesz podzielić? ");
monety = int.Parse(Console.ReadLine()!);
Console.Write ("\nIle jest bohaterów? ");
bohaterzy = int.Parse(Console.ReadLine()!);
if 
(bohaterzy == 0)
{
    Console.WriteLine("\nNie można podzielić łupu na 0 bohaterów!");
}
else
{
    lupNaLeb = (monety / bohaterzy);
    pozostaleMonety = (monety % bohaterzy);
    Console.WriteLine("\nKażdy bohater dostanie: " + lupNaLeb + " monet");
    Console.WriteLine("Pozostanie: " + pozostaleMonety + " monet");
}