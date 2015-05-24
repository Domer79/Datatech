using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using Test.Wpf.ConfigurationSections;
using Test.Wpf.Interfaces;

namespace Test.Wpf
{
    internal class StateMachine : IStateMachine
    {
        private string _currentState;
        private readonly IStateCollection _section;
        private readonly StateMachineActionDispatcher _actionDispatcher;
        private readonly Dictionary<IState, MethodInfo> _stateActions;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="T:System.Object"/>.
        /// </summary>
        public StateMachine()
        {
            _section = (StateMachineSection)ConfigurationManager.GetSection("stateMachine");
            _actionDispatcher = new StateMachineActionDispatcher();
            _stateActions = new Dictionary<IState, MethodInfo>();
            StateActionsInit();
        }

        private void StateActionsInit()
        {
            var methodInfos = typeof(StateMachineActionDispatcher).GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (var stateElement in _section)
            {
                _stateActions.Add(stateElement, methodInfos.First(mi => mi.Name == stateElement.NextState));
            }
        }

        public string CurrentState
        {
            get { return _currentState; }
        }
        public void ChangeState(string next, params object[] args)
        {
            ChangeState(_currentState, next, args);
        }

        public void ChangeState(string current, string next, params object[] args)
        {
            RunState(current, next, args);
            _currentState = next;
        }

        public void RunState(string currentState, string nextState, params object[] args)
        {
            var stateElement = new StateMachineElement{CurrentState = currentState ?? "", NextState = nextState};

            if (!_stateActions.ContainsKey(stateElement))
                throw new InvalidOperationException("Состояние для перехода не найдено");

            _stateActions[stateElement].Invoke(_actionDispatcher, args ?? new object[] { });
        }

        class StateMachineElement : IState
        {
            public string CurrentState { get; set; }
            public string NextState { get; set; }

            public override int GetHashCode()
            {
                return CurrentState.GetHashCode() ^ NextState.GetHashCode();
            }

            public override bool Equals(object compareTo)
            {
                if (compareTo == null)
                    return false;

                var stateElement = (IState)compareTo;

                return string.Equals(CurrentState, stateElement.CurrentState) &&
                       string.Equals(NextState, stateElement.NextState);
            }
        }
    }
}
