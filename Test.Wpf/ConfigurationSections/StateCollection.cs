using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Documents;

namespace Test.Wpf.ConfigurationSections
{
    public class StateCollection : ConfigurationElementCollection
    {
        /// <summary>
        /// Добавляет новый элемент конфигурации в <see cref="T:System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="element">Добавляемый объект <see cref="T:System.Configuration.ConfigurationElement"/>.</param>
        protected override void BaseAdd(ConfigurationElement element)
        {
            base.BaseAdd(element, false);
        }

        /// <summary>
        /// Возвращает тип <see cref="T:System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>
        /// <see cref="T:System.Configuration.ConfigurationElementCollectionType"/> данной коллекции.
        /// </returns>
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.AddRemoveClearMap;}
        }

        /// <summary>
        /// При переопределении в производном классе создает новый элемент <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </summary>
        /// <returns>
        /// Новый объект <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new StateElement();
        }

        /// <summary>
        /// При переопределении в производном классе возвращает ключ указанного элемента конфигурации.
        /// </summary>
        /// <returns>
        /// Объект <see cref="T:System.Object"/>, используемый в качестве ключа для указанного элемент <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </returns>
        /// <param name="element">Объект <see cref="T:System.Configuration.ConfigurationElement"/>, для которого возвращается ключ.</param>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((StateElement) element).Id;
        }
    }
}