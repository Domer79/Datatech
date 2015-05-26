using System;

namespace Test.Wpf.Interfaces
{
    public interface IState
    {
        string CurrentState { get; set; }
        Action 
        string NextState { get; set; }
        int GetHashCode();
        bool Equals(object compareTo);
    }
}