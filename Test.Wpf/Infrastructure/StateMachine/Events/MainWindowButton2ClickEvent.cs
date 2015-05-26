using Test.Wpf.Infrastructure.StateMachine.States;
using Test.Wpf.Interfaces;

namespace Test.Wpf.Infrastructure.StateMachine.Events
{
    public class MainWindowButton2ClickEvent : IEvent
    {
        public string EventName
        {
            get { return "MainWindowButton2Click"; }
        }
        public void Transition(params object[] args)
        {
            var mainWindow = (MainWindow) args[0];
            var window2 = new Window2();
            window2.MainWindow = mainWindow;
            window2.Show();
        }

        public IState State
        {
            get { return new Screen2State();}
        }
    }
}