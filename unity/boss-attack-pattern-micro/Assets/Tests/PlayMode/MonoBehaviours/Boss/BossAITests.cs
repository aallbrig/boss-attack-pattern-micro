using System.Collections;
using MonoBehaviours.Boss;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests.PlayMode.MonoBehaviours.Boss
{
    public class BossAITests
    {
        [UnityTest]
        public IEnumerator BossAICanThink()
        {
            var sut = new GameObject().AddComponent<BossAI>();
            var eventCalled = false;
            sut.ThoughtCycleCompleted += () => eventCalled = true;
            yield return null;

            Assert.IsTrue(eventCalled);
        }
        [UnityTest]
        public IEnumerator BossAI_ThinksUsing_ABehaviorTree()
        {
            var sut = new GameObject().AddComponent<BossAI>();
            var eventCalled = false;
            sut.BehaviorTreeTicked += () => eventCalled = true;
            yield return null;

            Assert.IsTrue(eventCalled);
        }
    }
}