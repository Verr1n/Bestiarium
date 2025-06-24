using System;
using System.Collections.Generic;
using System.Drawing;

<<<<<<< HEAD
NPC npc = new NPC(5, 3);

int playerX = 1;
int playerY = 1;

Console.CursorVisible = false;

while (true)
=======
/// Wszystkie klasy w projekcie Bestiarium umieszczamy w tej przestrzeni nazw,
/// aby grupować kod, unikać konfliktów nazw i ułatwić wzajemne odwołania.
// Cały ten plik należy do przestrzeni nazw Bestiarium
namespace Bestiarium
>>>>>>> cb72cdea6ae8ef81e4be2ce2cdbc238d59f039bb
{

 class Program
 {
    static void Main()
    {
        string[] levelMap = {
            "###########",
            "#      #  #",
            "#   #     #",
            "#   #     #",
            "###########"
        };

<<<<<<< HEAD
    if (level[newY][newX] != '#')   // kod na kolizje
    {
        playerX = newX;
        playerY = newY;
    }


    npc.Move(level);

    if (playerX == npc.X && playerY == npc.Y)
    {
        bool passed = NPC.Interact();
        if (passed)
        {
            Console.WriteLine("Good Job");
            Console.ReadKey();
            return;
        }
        else
        {
            Console.WriteLine("L");
            Console.ReadKey();
        }
    }
}
void DrawLevel()
{
    for (int y = 0; y < level.Length; y++)
    {
        for (int x = 0; x < level[y].Length; x++)
        {
            if (x == playerX && y == playerY && x == npc.X && y == npc.Y)
                Console.Write('&'); // specjalny znak, np. że są na tym samym polu
            else if (x == playerX && y == playerY)
                Console.Write('@');
            else if (x == npc.X && y == npc.Y)
                Console.Write('N');
            else
                Console.Write(level[y][x]);

=======
        var bindings = new Dictionary<ConsoleKey, string>
        {
            { ConsoleKey.W, "up" },
            { ConsoleKey.S, "down" },
            { ConsoleKey.A, "left" },
            { ConsoleKey.D, "right" }
        };

        var levelObj = new Level(levelMap);

        int playerX = 1, playerY = 1;
        Console.CursorVisible = false;

        var player = new PlayerG(
            name: "SkutyG",
            avatar: "&",
            position: new Point(playerX, playerY),
            level: levelObj,
            keyActionMap: bindings,
            health: 21,
            speed: 12
        );

        while (true)
        {
            Console.Clear();
            DrawLevel(levelMap, player.Position.X, player.Position.Y, player.Avatar);

            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape) break;

            Point movement = key switch
            {
                ConsoleKey.W => new Point(0, -1),
                ConsoleKey.S => new Point(0, +1),
                ConsoleKey.A => new Point(-1, 0),
                ConsoleKey.D => new Point(+1, 0),
                _ => new Point(0, 0)
            };

            var newPos = new Point(player.Position.X + movement.X, player.Position.Y + movement.Y);
            if (levelMap[newPos.Y][newPos.X] != '#')
                player.Move(movement);

            Console.SetCursorPosition(0, levelMap.Length + 1);
            Console.Write($"Zdrowie: {player.Health} | Prędkość: {player.Speed}");
>>>>>>> cb72cdea6ae8ef81e4be2ce2cdbc238d59f039bb
        }
    }

<<<<<<< HEAD
    Console.WriteLine("\nSterowanie: W A S D | ESC = Wyjście");
    Console.WriteLine("& - oznacza gracza oraz NPC na tym samym polu");
}



=======
    static void DrawLevel(string[] map, int px, int py, string avatar)
    {
        for (int y = 0; y < map.Length; y++)
        {
            for (int x = 0; x < map[y].Length; x++)
                Console.Write(x == px && y == py ? avatar : map[y][x]);
            Console.WriteLine();
        }
        Console.WriteLine("\nSterowanie: W A S D | ESC = Wyjście");
    }
 } 
}
>>>>>>> cb72cdea6ae8ef81e4be2ce2cdbc238d59f039bb
