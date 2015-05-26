using Test.Wpf.Infrastructure.StateMachine.States;
using Test.Wpf.Interfaces;

namespace Test.Wpf.Infrastructure.StateMachine.Events
{
    public class StartupEvent : IEvent
    {
        public string EventName
        {
            get { return "Load"; }
        }
        public void Transition(params object[] args)
        {
            
        }

        public IState State
        {
            get { return new Screen1State(); }
        }
    }
}