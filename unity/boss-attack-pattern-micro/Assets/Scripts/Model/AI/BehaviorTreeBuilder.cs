using System;
using Model.Interfaces;

namespace Model.AI
{
    public class BehaviorTreeBuilder
    {
        public IBehaviorTree Build()
        {
            return new BehaviorTree();
        }
    }
}