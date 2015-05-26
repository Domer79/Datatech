using Test.Wpf.Infrastructure.StateMachine.Events;
using Test.Wpf.Interfaces;

namespace Test.Wpf.Infrastructure.StateMachine.States
{
    public class Screen2TextThankYouButton3EnabledState: IState
    {
        public string Name { get; set; }

        public IEvent[] Events
        {
            get { return new IEvent[] {new Window2Button3ClickEvent(),}; }
        }
    }
}