using Test.Wpf.Infrastructure.StateMachine.States;
using Test.Wpf.Interfaces;

namespace Test.Wpf.Infrastructure.StateMachine.Events
{
    public class MainWindowButton1ClickEvent : IEvent
    {
        public string EventName
        {
            get { return "MainWindowButton1Click"; }
        }
        public void Transition(params object[] args)
        {
            var mainWindow = (MainWindow) args[0];
            mainWindow.Btn2.IsEnabled = true;
        }

        public IState State
        {
            get { return new Screen1EnableButton2State();}
        }
    }
}