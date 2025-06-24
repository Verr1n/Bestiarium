using System;
using System.Collections.Generic;
using System.Drawing;

namespace Bestiarium
{
    class Program
    {
        static void Main()
        {
            // 1) Definicja mapy
            string[] levelMap = {
                "###########",
                "#      #  #",
                "#   #     #",
                "#   #     #",
                "###########"
            };

            // Sterowanie
            var bindings = new Dictionary<ConsoleKey, string>
            {
                { ConsoleKey.W, "up" },
                { ConsoleKey.S, "down" },
                { ConsoleKey.A, "left" },
                { ConsoleKey.D, "right" }
            };

            // Ustawienie poziomu i gracza
            var levelObj = new Level(levelMap);
            var player   = new PlayerG(
                name:         "SkutyG",
                avatar:       "&",
                position:     new Point(1, 1),
                level:        levelObj,
                keyActionMap: bindings,
                health:       21,
                speed:        12
            );

            Console.CursorVisible = false;

            // Główna pętla gry
            while (true)
            {
                Console.Clear();
                DrawLevel(levelMap, player.Position.X, player.Position.Y, player.Avatar);

                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape)
                    break;

                // Obsługa ruchu i kolizji
                Point movement = key switch
                {
                    ConsoleKey.W => new Point(0, -1),
                    ConsoleKey.S => new Point(0, +1),
                    ConsoleKey.A => new Point(-1, 0),
                    ConsoleKey.D => new Point(+1, 0),
                    _             => new Point(0, 0)
                };

                var newPos = new Point(
                    player.Position.X + movement.X,
                    player.Position.Y + movement.Y
                );

                if (levelMap[newPos.Y][newPos.X] != '#')
                    player.Move(movement);

                // 6) Wyświetlanie statystyk
                Console.SetCursorPosition(0, levelMap.Length + 1);
                Console.Write($"Zdrowie: {player.Health} | Prędkość: {player.Speed}");
            }
        }

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