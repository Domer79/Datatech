namespace Test.Wpf.Interfaces
{
    internal interface IStateMachine
    {
        string CurrentState { get; }
        void ChangeState(string next, params object[] args);
        void ChangeState(string current, string next, params object[] args);
    }
}