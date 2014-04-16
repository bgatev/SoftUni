using System;
using System.Threading;

class FallingRocks
{
    struct Position
    {
        public int X, Y;
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    static void Main()
    {
        string dwarf = " (0) ";
        char[] rocks = new char[11];
        int width, height, rockwidth, rockheight, flag = 0;
        char fallingRock;
        Random ranrock = new Random();

        rocks[0] = '^'; rocks[1] = '@'; rocks[2] = '*'; rocks[3] = '&';
        rocks[4] = '+'; rocks[5] = '%'; rocks[6] = '$'; rocks[7] = '#';
        rocks[8] = '!'; rocks[9] = '.'; rocks[10] = ';';

        // The game speed
        double sleepTime = 150;
        fallingRock = rocks[ranrock.Next(0, 10)];

        // Console settings
        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight;
        width = Console.WindowWidth / 2 - 1;
        height = Console.WindowHeight - 1;
        rockwidth = width;
        rockheight = 1;

        // Draw dwarf on the screen
        Console.SetCursorPosition(width, height);
        Console.Write(dwarf);

        while (true)
        {

            // Display Rock on the screen
            if (flag == height)
            {
                fallingRock = rocks[ranrock.Next(0, 10)];
                rockwidth += 5;
                flag = 0;
            }
            Console.SetCursorPosition(rockwidth, rockheight++);
            if (rockheight > height) rockheight = 0;
            if (rockwidth > width) rockwidth = 0;

            Console.Write(fallingRock);

            // Read user key
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.RightArrow) width++;
                if (pressedKey.Key == ConsoleKey.LeftArrow) width--;
            }
            if (width < 0) width = 0;
            if (width > Console.WindowWidth - 6) width = Console.WindowWidth - 6;

            // Draw new Dwarf
            Console.SetCursorPosition(width, height);
            Console.Write(dwarf);

            // Slow the motion
            Thread.Sleep((int)sleepTime);

            // Change the speed
            sleepTime -= 0.05;
            flag++;
        }


    }
}

