using System;
namespace ZooManager
{
    public class Raptor : Bird
    {
        public Raptor(string name)
        {
            emoji = "🦅";
            species = "raptor";
            this.name = name;
            reactionTime = 1; // reaction time 1 (fast)
        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a raptor. RAAAAAAAAA 'Murica RAAAAAAA ");
            Hunt();
        }

        /* Note our raptor will eat cats and mice! */
        public void Hunt()
        {
            if (Game.Seek(location.x, location.y, Direction.up, "cat") || Game.Seek(location.x, location.y, Direction.up, "mouse"))
            {
                if (Game.Attack(this, Direction.up)) return;
            }
            else if (Game.Seek(location.x, location.y, Direction.down, "cat") || Game.Seek(location.x, location.y, Direction.down, "mouse"))
            {
                if (Game.Attack(this, Direction.down)) return;
            }
            else if (Game.Seek(location.x, location.y, Direction.left, "cat") || Game.Seek(location.x, location.y, Direction.left, "mouse"))
            {
                if (Game.Attack(this, Direction.left)) return;
            }
            else if (Game.Seek(location.x, location.y, Direction.right, "cat") || Game.Seek(location.x, location.y, Direction.right, "mouse"))
            {
                if (Game.Attack(this, Direction.right)) return;
            }
        }
    }
}