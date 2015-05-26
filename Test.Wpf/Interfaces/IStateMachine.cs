using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Wpf.Interfaces
{
    public interface IStateMachine
    {
        IState CurrentState { get; }
        void ChangeState(string eventName, params object[] args);
        void ChangeState<TEvent>(params object[] args) where TEvent: class, IEvent;
//        void ChangeState(string current, string next, params object[] args);
    }
}
