using System;

namespace Model.Interfaces
{
    public interface IThinker
    {
        public event Action ThoughtCycleCompleted;
    }
}