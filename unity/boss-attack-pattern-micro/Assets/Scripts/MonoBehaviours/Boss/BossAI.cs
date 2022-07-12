
using System;
using Model.Interfaces;

namespace MonoBehaviours.Boss
{
    public class BossAI : UnityEngine.MonoBehaviour, IThinker, IBehaviorTreeRunner
    {

        public event Action ThoughtCycleCompleted;
        public event Action BehaviorTreeTicked;

        private void Update()
        {
            ThoughtCycleCompleted?.Invoke();
            BehaviorTreeTicked?.Invoke();
        }

    }
}

