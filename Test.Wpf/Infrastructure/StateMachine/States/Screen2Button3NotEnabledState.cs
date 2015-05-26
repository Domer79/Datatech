using System.ComponentModel;
using Test.Wpf.Infrastructure.StateMachine.Events;
using Test.Wpf.Interfaces;

namespace Test.Wpf.Infrastructure.StateMachine.States
{
    [Description("����� �2. ������ �3 ���������")]
    public class Screen2Button3NotEnabledState : IState
    {
        public string Name { get; set; }

        public IEvent[] Events
        {
            get { return new IEvent[] {new Window2TextBox2EnterHelloEvent()}; }
        }
    }
}