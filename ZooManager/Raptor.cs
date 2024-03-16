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
            TaskProcess();
        }

        public void TaskProcess()
        {
            TaskCheck = Hunt("cat");
            if (TaskCheck == false)
            {
                TaskCheck = Hunt("mouse");
            }
            TurnCheck = true;
        }
    }
}