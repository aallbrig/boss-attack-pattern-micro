using System;
using Model.Interfaces;

namespace Model.AI
{
    public class Behavior: IBehavior
    {
        private BehaviorStatus _currentStatus;
        protected Behavior() => CurrentStatus = BehaviorStatus.Invalid;

        public event Action<BehaviorStatus> StatusChanged;

        public BehaviorStatus CurrentStatus
        {
            get => _currentStatus;
            private set
            {
                if (value != _currentStatus) StatusChanged?.Invoke(value);
                _currentStatus = value;
            }
        }

        public BehaviorStatus Tick()
        {
            if (CurrentStatus != BehaviorStatus.Running) Initialize();
            CurrentStatus = Update();
            if (CurrentStatus != BehaviorStatus.Running) Terminate();
            return CurrentStatus;
        }

        public void Initialize() {}
        public virtual BehaviorStatus Update()
        {
            return BehaviorStatus.Success;
        }
        public void Terminate() {}
    }
}