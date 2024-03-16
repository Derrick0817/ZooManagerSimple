using System;
namespace ZooManager
{
	public class Chick : Bird
	{
        public Chick(string name)
        {
            emoji = "🐥";
            species = "chick";
            this.name = name; // "this" to clarify instance vs. method parameter
            reactionTime = new Random().Next(6, 10);
        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a chick. Beepbeep.");
            TaskProcess();
        }

        public void TaskProcess()
        {
            TaskCheck = Flee("cat");
            TurnCheck = true;
        }
    }
}

