namespace Test.Wpf.Interfaces
{
    public interface IState
    {
        string CurrentState { get; set; }
        string NextState { get; set; }
        int GetHashCode();
        bool Equals(object compareTo);
    }
}