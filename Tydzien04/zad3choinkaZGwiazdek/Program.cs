
Console.WriteLine("Podaj wysokosc choinki: ");
int wysokosc = int.Parse(Console.ReadLine());
string gwiazdka = "*";
string spacja = " ";
int lewaStrona, prawaStrona, liczbaSpacji, wiersz;
int aktualneSpacje = wysokosc;
for (wiersz = 1; wiersz <= wysokosc; wiersz++)
{
    for( liczbaSpacji = 1; liczbaSpacji < aktualneSpacje; liczbaSpacji++)
    {
    Console.Write(spacja);
    }              
    for (lewaStrona = 1; lewaStrona <= wiersz; lewaStrona++)
    {
        Console.Write(gwiazdka);
    }
    for (prawaStrona = 1; prawaStrona <= wiersz -1; prawaStrona++)
    {
        Console.Write(gwiazdka);
    }
    aktualneSpacje--;
    Console.WriteLine();
}

int spacjePienia= wysokosc;
while (spacjePienia>1)
{
    Console.Write(spacja);
    spacjePienia--;
}
Console.WriteLine(gwiazdka);