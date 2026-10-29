using System.ComponentModel.Design.Serialization;

List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Pochodnia"
};


Console.WriteLine($"Plecak ({plecak.Count}/6):");
int i = 0;
for (i=0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i+1}. {plecak[i]}");
}


Console.Write("Znaleziono Przedmiot: ");
string przedmiot = Console.ReadLine();
plecak.Add(przedmiot);
Console.WriteLine($"Dodano: {plecak[plecak.Count-1]}");

bool maMiksture = plecak.Contains("Mikstura");
if (maMiksture == true)
{
    plecak.Remove("Mikstura");
    Console.WriteLine("Użyto Mikstury.");

}

Console.WriteLine($"Plecak ({plecak.Count}/6):");
for (i=0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i+1}. {plecak[i]}");
}
