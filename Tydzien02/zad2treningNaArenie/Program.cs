int Experience = 75;
int Gold = 100;
int TrainingDone = 0;
Console.WriteLine("===Stan początkowy===");
Console.WriteLine($"Experience (int): {Experience}");
Console.WriteLine($"Gold (int): {Gold}");
Console.WriteLine($"Training Done (int): {TrainingDone}\n\n");

Experience += 25;
Experience *= 2;
Gold -= 8;
Gold += 15;
TrainingDone += 1;

Console.WriteLine("===Stan po treningu===");
Console.WriteLine($"Experience (int): {Experience}");
Console.WriteLine($"Gold (int): {Gold}");
Console.WriteLine($"Training Done (int): {TrainingDone}");