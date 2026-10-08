int weaponDamage = 0;
int strengthBonus = 0;
Console.Write ("Podaj obrazenia broni: ");
weaponDamage = int.Parse(Console.ReadLine()!);
Console.Write ("Podaj bonus do sily: ");
strengthBonus = int.Parse(Console.ReadLine()!);

int normalDamage =(weaponDamage + strengthBonus);
int critDamage = (normalDamage * 2);
int totalDamage = ((normalDamage * 3) + critDamage);

Console.WriteLine ("+--------------------------------+");
Console.WriteLine("| Obrażenia normalne: " + normalDamage + "\t\t |");
Console.WriteLine("| Obrażenia Specjalne: " + critDamage + "\t |");
Console.WriteLine("| Łączne obrażenia: " + totalDamage + "\t\t |");
Console.WriteLine ("+--------------------------------+");


