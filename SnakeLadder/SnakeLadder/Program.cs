// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Snake And Ladder Game");

const int LADDER = 1;
const int NOPLAY = 2;
const int SNAKE = 3;

int Position = 0;

Random random = new Random();
int dieCount = 0;

while (Position != 100)
{

    int numOnDie = random.Next(1, 7);
    dieCount++;

    Console.WriteLine("No On Die " + numOnDie);


    int options = random.Next(1, 4);

    switch (options)
    {
        case LADDER:
            Position += numOnDie;
            Position = Position > 100 ? Position -= numOnDie : Position;
            break;

        case SNAKE:
            Position -= numOnDie;
            Position = Position < 0 ? 0 : Position;
            break;

        case NOPLAY:
            
            break;
    }

    Console.WriteLine($"die count:{dieCount} position: {Position}");

    Console.WriteLine("POSITION " + Position);
}

        
