using System;

namespace Model.AI.Behaviors
{
    public class SideEffect: Behavior
    {
        private readonly Func<BehaviorStatus> _sideEffectFunction;
        public SideEffect(Func<BehaviorStatus> sideEffectFunction) =>
            _sideEffectFunction = sideEffectFunction ?? throw new ArgumentNullException();
        public override BehaviorStatus Update()
        {
            return _sideEffectFunction.Invoke();
        }
    }
}