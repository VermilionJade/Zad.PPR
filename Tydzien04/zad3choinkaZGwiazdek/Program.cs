int wysokosc = 0;
int star=0;
int oryginalnaWysokosc=0;
int iloscStar=0;

Console.Write("Podaj wysokość choinki(2-10): ");
oryginalnaWysokosc = int.Parse(Console.ReadLine());

for (wysokosc=oryginalnaWysokosc; wysokosc >=1; wysokosc--)
{
    int space = 0;
    star = -1;
    for (space=wysokosc - 1; space >=1; space--)
    {
        Console.Write(" ");
    }
    iloscStar = 0;

    for (star = star+1; star <= (wysokosc*2)-1; star += 1)
    {
        
        Console.Write("*");
        iloscStar=iloscStar+1;
        if (iloscStar==star)
        {
            break;
        }

    }
    for (space=wysokosc - 1; space >=1; space--)
    {
        Console.Write(" ");
    }
    Console.WriteLine();
}
