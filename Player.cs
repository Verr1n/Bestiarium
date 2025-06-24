using System;
using System.Collections.Generic;
using System.Drawing;

namespace Bestiarium
{

 {
    public class PlayerG : Character

    {
        private Dictionary<ConsoleKey, string> keyBindings;

        // Statystyki gracza
        public int Health { get; public set; }
        public int Speed { get; public set; }

        public PlayerG(
            string name,
             string avatar,
              Point position,
               Level level,
                Dictionary<ConsoleKey, string> keyActionMap,
                 int Health,
                  int Speed) 
                  : base(name, avatar, position, level)
        {
            keyBindings = keyActionMap;
            Health = 21;
            Speed = 9;
        }

        public override string ChooseAction()
        {
            var key = Console.ReadKey(true).Key;
            return keyBindings.TryGetValue(key, out var action)
                ? action

            : "none";


            return chosenAction;
        }

        public override void Move(Point direction)

        {
            base.Move(direction);
            // speed += 1;
        }
    }
 }
}