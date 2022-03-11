// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Snake And Ladder Game");

int Position = 0;

Random random = new Random();

int numOnDie = random.Next(1, 7);
Console.WriteLine("No On Die "+ numOnDie);
