using System;

class Program
{
    static string[] level = {
        "###########",
        "#      #  #",
        "#   #     #",
        "#   #     #",
        "###########"
    };

    static int playerX = 1; // Kolumna
    static int playerY = 1; // Wiersz

    static void Main()
    {
        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();
            DrawLevel();

            ConsoleKey key = Console.ReadKey(true).Key;

            int newX = playerX;
            int newY = playerY;

            // Ruch
            switch (key)
            {
                case ConsoleKey.W: newY--; break;
                case ConsoleKey.S: newY++; break;
                case ConsoleKey.A: newX--; break;
                case ConsoleKey.D: newX++; break;
                case ConsoleKey.Escape: return; // Wyjście z gry
            }

            // Sprawdzenie kolizji
            if (level[newY][newX] != '#')
            {
                playerX = newX;
                playerY = newY;
            }
        }
    }

    static void DrawLevel()
    {
        for (int y = 0; y < level.Length; y++)
        {
            for (int x = 0; x < level[y].Length; x++)
            {
                if (x == playerX && y == playerY)
                    Console.Write('@'); // Gracz
                else
                    Console.Write(level[y][x]); // Ściana lub pusta przestrzeń
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nSterowanie: W A S D | ESC = wyjście");
    }
}
