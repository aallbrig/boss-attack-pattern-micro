
using System;
using Model.AI;
using Model.Interfaces;

namespace MonoBehaviours.Boss
{
    public class BossAI : UnityEngine.MonoBehaviour, IThinker, IBehaviorTreeRunner
    {

        public event Action ThoughtCycleCompleted;
        public event Action BehaviorTreeTicked;

        private IBehaviorTree _bt;

        private void Start()
        {
            _bt = new BehaviorTreeBuilder().Build();
        }
        private void Update()
        {
            ThoughtCycleCompleted?.Invoke();
            _bt.Tick();
            BehaviorTreeTicked?.Invoke();
        }

    }
}

