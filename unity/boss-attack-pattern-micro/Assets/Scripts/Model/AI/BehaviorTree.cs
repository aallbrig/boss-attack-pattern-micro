using System;
using Model.Interfaces;

namespace Model.AI
{
    public class BehaviorTree: IBehaviorTree
    {
        public event Action ThoughtCycleCompleted;

        public void Tick()
        {
            
        }
    }
}