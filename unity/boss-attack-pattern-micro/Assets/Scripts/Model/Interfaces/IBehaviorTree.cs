namespace Model.Interfaces
{
    public interface IBehaviorTree: IThinker
    {
        public void Tick();
    }
}