Random dice = new Random();
int roll1 =dice.Next();
int roll2 =dice.Next(301);
int roll3 = dice.Next(100,401);
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");