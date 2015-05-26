using Test.Wpf.Infrastructure.StateMachine.States;
using Test.Wpf.Interfaces;

namespace Test.Wpf.Infrastructure.StateMachine.Events
{
    public class Window2Button3ClickEvent : IEvent
    {
        public string EventName
        {
            get { return "Window2Button3Click"; }
        }
        public void Transition(params object[] args)
        {
            var window = (Window2) args[0];
            window.MainWindow.Focus();
        }

        public IState State
        {
            get { return new Screen1EnableButton2State();}
        }
    }
}