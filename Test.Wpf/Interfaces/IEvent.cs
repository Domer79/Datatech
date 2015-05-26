namespace Test.Wpf.Interfaces
{
    public interface IEvent
    {
        string EventName { get; }
        void Transition(params object[] args);
        IState State { get; }
    }
}