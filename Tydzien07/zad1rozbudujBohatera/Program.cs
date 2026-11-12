Console.WriteLine("Witaj w grze! Podaj imie swojego bohatera:");
Player player = new Player(Console.ReadLine(), 100, 50);

Console.WriteLine($"Witaj, {player.Name}! Twoje zdrowie: {player.Health}/{player.MaxHealth}, Zloto: {player.Gold}, Poziom: {player.Level}, Doswiadczenie: {player.Experience}");
player.GainExperience(1500);
Console.WriteLine($"Po zdobyciu doswiadczenia: {player.Name}! Twoje zdrowie: {player.Health}/{player.MaxHealth}, Zloto: {player.Gold}, Poziom: {player.Level}, Doswiadczenie: {player.Experience}");