using System;
using System.Collections.Generic;
using System.Drawing;

namespace Bestiarium
{
    // Klasa reprezentująca gracza, dziedziczy po Character
    public class PlayerG : Character
    {
        private readonly Dictionary<ConsoleKey, string> keyBindings;

        // Statystyki gracza 
        public int Health { get; private set; }
        public int Speed  { get; private set; }

        
        public PlayerG(
            string name,
            string avatar,
            Point position,
            Level level,
            Dictionary<ConsoleKey, string> keyActionMap,
            int health,
            int speed
        ) : base(name, avatar, position, level)
        {
            keyBindings = keyActionMap;
            Health      = health;  // przypisanie wartości parametru health
            Speed       = speed;   // przypisanie wartości parametru speed
        }

        
        public override string ChooseAction()
        {
            var key = Console.ReadKey(true).Key;
            return keyBindings.TryGetValue(key, out var action)
                ? action
                : "none";
        }

        // Metoda ruchu wywołuje bazową implementację z Character
        public override void Move(Point direction)
        {
            base.Move(direction);
        
        }
    }
}