using System.Runtime.CompilerServices;
using System.Security.Cryptography;

Dictionary<string, int> ceny = new Dictionary<string, int>
{
    { "Mikstura", 15 },
    { "Pochodnia", 5 },
    { "Miecz", 40 }
};

int i =0;
foreach (KeyValuePair<string, int> para in ceny)
{
    i++;
    Console.WriteLine($"{i}. {para.Key}: {para.Value} sztuk złota.");
}

Console.Write("Jaki przedmiot chcesz wybrać? ");
string chosenObject = Console.ReadLine();

if (ceny.ContainsKey(chosenObject))
{
    Console.WriteLine($"Cena: {ceny[chosenObject]}");
}
else
{
    Console.WriteLine("Nie ma takiego przedmiotu");
}

ceny["Mikstura"] = 12;
foreach (KeyValuePair<string, int> para in ceny)
{
    i++;
    Console.WriteLine($"{i}. {para.Key}: {para.Value} sztuk złota.");
}
