using System;

namespace Model.AI.Behaviors
{
    public class InstantCondition: Behavior
    {
        private readonly Func<BehaviorStatus> _conditionFunction;
        public InstantCondition(Func<BehaviorStatus> sideEffectFunction) =>
            _conditionFunction = sideEffectFunction ?? throw new ArgumentNullException();
        public override BehaviorStatus Update()
        {
            return _conditionFunction.Invoke();
        }
    }
}