using System;
namespace ZooManager
{
    public class Animal
    {
        public string emoji;
        public string species;
        public string name;
        public int reactionTime = 5; // default reaction time for animals (1 - 10)
        public bool TaskCheck;
        public bool TurnCheck;

        public Point location;

        public void ReportLocation()
        {
            Console.WriteLine($"I am at {location.x},{location.y}");
        }

        virtual public void Activate()
        {
            Console.WriteLine($"Animal {name} at {location.x},{location.y} activated");
        }

        public bool Hunt(string prey)
        {
            if (Game.Seek(location.x, location.y, Direction.up, prey))
            {
                if (Game.Attack(this, Direction.up)) return true;
                return false;
            }
            else if (Game.Seek(location.x, location.y, Direction.down, prey))
            {
                if (Game.Attack(this, Direction.down)) return true;
                return false;
            }
            else if (Game.Seek(location.x, location.y, Direction.left, prey))
            {
                if (Game.Attack(this, Direction.left)) return true;
                return false;
            }
            else if (Game.Seek(location.x, location.y, Direction.right, prey))
            {
                if (Game.Attack(this, Direction.right)) return true;
                return false;
            }
            return false; // nothing to hunt
        }

        public bool Flee(string predator)
        {
            if (Game.Seek(location.x, location.y, Direction.up, predator))
            {
                if (Game.Seek(location.x, location.y, Direction.up, "null")) // check all directions for fleeing
                {
                    if (Game.Retreat(this, Direction.up)) return true;
                }
                if (Game.Seek(location.x, location.y, Direction.down, "null"))
                {
                    if (Game.Retreat(this, Direction.down)) return true;
                }
                if (Game.Seek(location.x, location.y, Direction.left, "null"))
                {
                    if (Game.Retreat(this, Direction.left)) return true;
                }
                if (Game.Seek(location.x, location.y, Direction.right, "null"))
                {
                    if (Game.Retreat(this, Direction.right)) return true;
                }
                return false; // can't run
            }
            if (Game.Seek(location.x, location.y, Direction.down, predator))
            {
                if (Game.Seek(location.x, location.y, Direction.up, "null")) // check all directions for fleeing
                {
                    if (Game.Retreat(this, Direction.up)) return true;
                }
                if (Game.Seek(location.x, location.y, Direction.down, "null"))
                {
                    if (Game.Retreat(this, Direction.down)) return true;
                }
                if (Game.Seek(location.x, location.y, Direction.left, "null"))
                {
                    if (Game.Retreat(this, Direction.left)) return true;
                }
                if (Game.Seek(location.x, location.y, Direction.right, "null"))
                {
                    if (Game.Retreat(this, Direction.right)) return true;
                }
                return false; // can't run
            }
            if (Game.Seek(location.x, location.y, Direction.left, predator))
            {
                if (Game.Seek(location.x, location.y, Direction.up, "null")) // check all directions for fleeing
                {
                    if (Game.Retreat(this, Direction.up)) return true;
                }
                if (Game.Seek(location.x, location.y, Direction.down, "null"))
                {
                    if (Game.Retreat(this, Direction.down)) return true;
                }
                if (Game.Seek(location.x, location.y, Direction.left, "null"))
                {
                    if (Game.Retreat(this, Direction.left)) return true;
                }
                if (Game.Seek(location.x, location.y, Direction.right, "null"))
                {
                    if (Game.Retreat(this, Direction.right)) return true;
                }
                return false; // can't run
            }
            if (Game.Seek(location.x, location.y, Direction.right, predator))
            {
                if (Game.Seek(location.x, location.y, Direction.up, "null")) // check all directions for fleeing
                {
                    if (Game.Retreat(this, Direction.up)) return true;
                }
                if (Game.Seek(location.x, location.y, Direction.down, "null"))
                {
                    if (Game.Retreat(this, Direction.down)) return true;
                }
                if (Game.Seek(location.x, location.y, Direction.left, "null"))
                {
                    if (Game.Retreat(this, Direction.left)) return true;
                }
                if (Game.Seek(location.x, location.y, Direction.right, "null"))
                {
                    if (Game.Retreat(this, Direction.right)) return true;
                }
                return false; // can't run
            }
            return false; // nothing to flee
        }
    }
}
