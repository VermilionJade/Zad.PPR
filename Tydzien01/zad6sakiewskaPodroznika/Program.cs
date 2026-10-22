int gold = 0;
int silver = 0;
int bronze = 0;

Console.Write ("Ile złotych monet posiadasz? ");
gold = int.Parse(Console.ReadLine()!);
Console.Write ("\nIle srebrnych monet posiadasz? ");
silver = int.Parse(Console.ReadLine()!);
Console.Write ("\nIle brązowych monet posiadasz? ");
bronze = int.Parse(Console.ReadLine()!);

int total = gold * 100 + silver * 10 + bronze;
Console.WriteLine ("\n\nŁączna wartość monet wynosi: " + total + " bronzowych monet");


