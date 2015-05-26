using System.ComponentModel;
using Test.Wpf.Infrastructure.StateMachine.Events;
using Test.Wpf.Interfaces;

namespace Test.Wpf.Infrastructure.StateMachine.States
{
    [Description("Экран №1")]
    public class Screen1State: IState
    {
        public string Name { get; set; }

        public IEvent[] Events
        {
            get { return new IEvent[]{new MainWindowButton1ClickEvent(), };}
        }
    }
}