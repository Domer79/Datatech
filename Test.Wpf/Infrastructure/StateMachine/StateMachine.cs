using System.Linq;
using Test.Wpf.Interfaces;

namespace Test.Wpf.Infrastructure.StateMachine
{
    public class StateMachine : IStateMachine
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="T:System.Object"/>.
        /// </summary>
        public StateMachine(IEvent startEvent, params object[] args)
        {
            startEvent.Transition(args);
            CurrentState = startEvent.State;
        }

        public IState CurrentState { get; private set; }

        public void ChangeState(string eventName, params object[] args)
        {
            var @event = CurrentState.Events.First(e => e.EventName == eventName);
            @event.Transition(args);
            CurrentState = @event.State;
        }

        public void ChangeState<TEvent>(params object[] args) where TEvent : class, IEvent
        {
            var @event = CurrentState.Events.First(e => e.GetType() == typeof (TEvent));
            ChangeState(@event.EventName, args);
        }

//        public void ChangeState(string current, string next, params object[] args)
//        {
            
//        }

    }
}
