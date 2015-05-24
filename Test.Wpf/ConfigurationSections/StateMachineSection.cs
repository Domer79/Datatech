using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Test.Wpf.Interfaces;

namespace Test.Wpf.ConfigurationSections
{
    public class StateMachineSection : ConfigurationSection, IStateCollection
    {
        [ConfigurationProperty("states", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(StateCollection), AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
        private StateCollection StateCollection
        {
            get { return (StateCollection)base["states"]; }
        }

        /// <summary>
        /// ���������� �������������, ����������� �������� � ���������.
        /// </summary>
        /// <returns>
        /// ��������� <see cref="T:System.Collections.Generic.IEnumerator`1"/>, ������� ����� �������������� ��� �������� ��������� ���������.
        /// </returns>
        public IEnumerator<IState> GetEnumerator()
        {
            return StateCollection.OfType<StateElement>().GetEnumerator();
        }

        /// <summary>
        /// ���������� �������������, �������������� �������� � ���������.
        /// </summary>
        /// <returns>
        /// ������ <see cref="T:System.Collections.IEnumerator"/>, ������� ����� �������������� ��� �������� ���������.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}