using System;

namespace ZooManager
{
    public class Cat : Animal
    {
        public Cat(string name)
        {
            emoji = "🐱";
            species = "cat";
            this.name = name;
            reactionTime = new Random().Next(1, 6); // reaction time 1 (fast) to 5 (medium)Cat
        }

        public override void Activate()
        {
            base.Activate();
            Console.WriteLine("I am a cat. Meow.");
            TaskProcess();
        }

        public void TaskProcess() // Priority is to flee over hunt
        {
            TaskCheck = Flee("raptor");
            if (TaskCheck == false)
            {
                TaskCheck = Hunt("mouse");
                if (TaskCheck == false)
                {
                    TaskCheck = Hunt("chick");
                }
            }
            TurnCheck = true;
        }
    }
}

