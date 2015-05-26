using Test.Wpf.Infrastructure.StateMachine.States;
using Test.Wpf.Interfaces;

namespace Test.Wpf.Infrastructure.StateMachine.Events
{
    public class Window2TextBox2EnterHelloEvent : IEvent
    {
        public string EventName
        {
            get { return "Window2TextBox3EnterHello"; }
        }
        public void Transition(params object[] args)
        {
            var window = (Window2) args[0];
            window.TextBlock1.Text = "thank you";
            window.Btn3.IsEnabled = true;
        }

        public IState State
        {
            get
            {
                return new Screen2TextThankYouButton3EnabledState();
            }
        }
    }
}