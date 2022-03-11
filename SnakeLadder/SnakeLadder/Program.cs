// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Snake And Ladder Game");

const int LADDER = 1;
const int NOPLAY = 2;
const int SNAKE = 3;

int Position = 0;

Random random = new Random();
while (Position <= 100)
{

    int numOnDie = random.Next(1, 7);
    Console.WriteLine("No On Die " + numOnDie);


    int options = random.Next(1, 4);

    switch (options)
    {
        case LADDER:
            Position += numOnDie;
            break;

        case SNAKE:
            Position -= numOnDie;
            break;

        case NOPLAY:
            Console.WriteLine("POSITION " + Position);
            break;
    }
    Console.WriteLine("POSITION " + Position);
}

        
