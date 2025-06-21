string[] level = {
    "###########",
    "#      #  #",
    "#   #     #",
    "#   #     #",
    "###########"
};

int playerX = 1;
int playerY = 1;

Console.CursorVisible = false;

while (true)
{
    Console.Clear();
    DrawLevel();

    ConsoleKey key = Console.ReadKey(true).Key;

    int newX = playerX;
    int newY = playerY;

    switch (key)
    {
        case ConsoleKey.W: newY--; break;
        case ConsoleKey.S: newY++; break;
        case ConsoleKey.A: newX--; break;
        case ConsoleKey.D: newX++; break;
        case ConsoleKey.Escape: return;
    }

    if (level[newY][newX] != '#')
    {
        playerX = newX;
        playerY = newY;
    }
}

void DrawLevel()
{
    for (int y = 0; y < level.Length; y++)
    {
        for (int x = 0; x < level[y].Length; x++)
        {
            if (x == playerX && y == playerY)
                Console.Write('@');
            else
                Console.Write(level[y][x]);
        }
        Console.WriteLine();
    }

    Console.WriteLine("\nSterowanie: W A S D | ESC = Wyjście");
}
