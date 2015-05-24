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
        /// Возвращает перечислитель, выполняющий итерацию в коллекции.
        /// </summary>
        /// <returns>
        /// Интерфейс <see cref="T:System.Collections.Generic.IEnumerator`1"/>, который может использоваться для перебора элементов коллекции.
        /// </returns>
        public IEnumerator<IState> GetEnumerator()
        {
            return StateCollection.OfType<StateElement>().GetEnumerator();
        }

        /// <summary>
        /// Возвращает перечислитель, осуществляющий итерацию в коллекции.
        /// </summary>
        /// <returns>
        /// Объект <see cref="T:System.Collections.IEnumerator"/>, который может использоваться для перебора коллекции.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}