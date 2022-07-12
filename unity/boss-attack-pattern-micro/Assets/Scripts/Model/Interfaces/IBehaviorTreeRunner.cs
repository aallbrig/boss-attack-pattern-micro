using System;

namespace Model.Interfaces
{
    public interface IBehaviorTreeRunner
    {
        public event Action BehaviorTreeTicked;
    }
}