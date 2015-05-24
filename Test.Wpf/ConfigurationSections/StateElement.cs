using System;
using System.Configuration;
using Test.Wpf.Interfaces;

namespace Test.Wpf.ConfigurationSections
{
    public class StateElement : ConfigurationElement, IState
    {
        [ConfigurationProperty("id", IsKey = true)]
        public int Id
        {
            get { return (int) Convert.ChangeType(base["id"], TypeCode.Int32); }
            set { base["id"] = value; }
        }

        [ConfigurationProperty("currentState", IsKey = false)]
        public string CurrentState
        {
            get { return (string)base["currentState"]; }
            set { base["currentState"] = value; }
        }

        [ConfigurationProperty("nextState", IsKey = false)]
        public string NextState
        {
            get { return (string) base["nextState"]; }
            set { base["nextState"] = value; }
        }

        /// <summary>
        /// ���������� ���������� ��������, �������������� ������� ��������� <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </summary>
        /// <returns>
        /// ���������� ��������, �������������� ������� ��������� <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </returns>
        public override int GetHashCode()
        {
            return CurrentState.GetHashCode() ^ NextState.GetHashCode();
        }

        /// <summary>
        /// ���������� ������� ��������� <see cref="T:System.Configuration.ConfigurationElement"/> � ��������� ��������.
        /// </summary>
        /// <returns>
        /// �������� true, ���� ������������ ������ ����� �������� ���������� <see cref="T:System.Configuration.ConfigurationElement"/>; � ��������� ������ � �������� false. �������� �� ��������� � false.
        /// </returns>
        /// <param name="compareTo">������, � ������� ����������� ���������.</param>
        public override bool Equals(object compareTo)
        {
            if (compareTo == null)
                return false;

            var stateElement = (IState) compareTo;

            return string.Equals(CurrentState, stateElement.CurrentState) &&
                   string.Equals(NextState, stateElement.NextState);
        }
    }
}
