using DungeonOrganizer.Characters;
using DungeonOrganizer.Items;
using DungeonOrganizer.UI;

Player player = new Player("Ada", 100);
Enemy enemy = new Enemy("Goblin", 30);
Item item = new Item("Mikstura", 15);

GamePrinter.ShowHeader("Dungeon Organizer");
GamePrinter.ShowCharacter(player.Name, player.Health);
GamePrinter.ShowCharacter(enemy.Name, enemy.Health);
GamePrinter.ShowItem(item.Name, item.Price);
