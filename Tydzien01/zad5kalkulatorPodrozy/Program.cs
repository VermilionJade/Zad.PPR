Console.Write ("Ile kilometrów do celu? ");
double km = Convert.ToDouble(Console.ReadLine());
Console.Write ("\nIle kilometrów pokonujesz na dzień? ");
double kmDziennie = Convert.ToDouble(Console.ReadLine());
double dni = km / kmDziennie;
Console.WriteLine ("\n\nAby pokonać " + km + " km przy prędkości " + kmDziennie + " km/dzień potrzebujesz " + dni + " dni");
