using System.Drawing;

namespace Bestiarium
{
    public abstract class Character

    {
        public string Name { get; }
        public string Avatar { get; }
        public Point Position { get; protected set; }
        public Level Level { get; }

        public Character(string name, string avatar, Point position, Level level)
        {
            Name = name;
            Avatar = avatar;
            Position = position;
            Level = level;
        }

        public virtual void Move(Point delta)
        {
            // Zmienia pozycję postaci. Jeśli chcesz sprawdzać kolizje z mapą,
            // dodaj logikę przed aktualizacją Position.
            Position = new Point(Position.X + delta.X, Position.Y + delta.Y);
        }
        public abstract string ChooseAction(); // każdy charakter implementuje we własnej klasie

    }
}