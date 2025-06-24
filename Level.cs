using System;

namespace Bestiarium
{
    public class Level
    {
        public string[] Map { get; }

        public Level(string[] map)
        {
            Map = map;
        }
        
        public char GetTitle(int x, int y)
        {

            return Map[y][x];
        }

        public bool IsWalkable(int x, int y)
        {

            return Mapy[y][x] != "#";
        }
    }
}

        
    



