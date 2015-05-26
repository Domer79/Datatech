using System.ComponentModel;
using Test.Wpf.Infrastructure.StateMachine.Events;
using Test.Wpf.Interfaces;

namespace Test.Wpf.Infrastructure.StateMachine.States
{
    [Description("Экран 1. Активирована кнопка №2")]
    public class Screen1EnableButton2State : IState
    {
        public string Name { get; set; }

        public IEvent[] Events
        {
            get { return new IEvent[] {new MainWindowButton2ClickEvent(),}; }
        }
    }
}