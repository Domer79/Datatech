using Test.Wpf.Infrastructure.StateMachine.States;
using Test.Wpf.Interfaces;

namespace Test.Wpf.Infrastructure.StateMachine.Events
{
    public class Window2TextBox1EnterTextEvent : IEvent
    {
        public string EventName
        {
            get { return "Window2TextBox1EnterText"; }
        }
        public void Transition(params object[] args)
        {
            var window = (Window2) args[0];
            window.Btn3.IsEnabled = false;
        }

        public IState State
        {
            get { return new Screen2Button3NotEnabledState();}
        }
    }
}