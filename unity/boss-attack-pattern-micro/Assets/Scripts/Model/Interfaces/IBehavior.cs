using System;
using Model.AI;

namespace Model.Interfaces
{
    public interface IBehavior
    {
        public event Action<BehaviorStatus> StatusChanged;
        public BehaviorStatus CurrentStatus { get; }
        public void Initialize();
        public BehaviorStatus Update();
        public void Terminate();
    }
}