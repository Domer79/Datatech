using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Documents;

namespace Test.Wpf.ConfigurationSections
{
    public class StateCollection : ConfigurationElementCollection
    {
        /// <summary>
        /// ��������� ����� ������� ������������ � <see cref="T:System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <param name="element">����������� ������ <see cref="T:System.Configuration.ConfigurationElement"/>.</param>
        protected override void BaseAdd(ConfigurationElement element)
        {
            base.BaseAdd(element, false);
        }

        /// <summary>
        /// ���������� ��� <see cref="T:System.Configuration.ConfigurationElementCollection"/>.
        /// </summary>
        /// <returns>
        /// <see cref="T:System.Configuration.ConfigurationElementCollectionType"/> ������ ���������.
        /// </returns>
        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.AddRemoveClearMap;}
        }

        /// <summary>
        /// ��� ��������������� � ����������� ������ ������� ����� ������� <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </summary>
        /// <returns>
        /// ����� ������ <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new StateElement();
        }

        /// <summary>
        /// ��� ��������������� � ����������� ������ ���������� ���� ���������� �������� ������������.
        /// </summary>
        /// <returns>
        /// ������ <see cref="T:System.Object"/>, ������������ � �������� ����� ��� ���������� ������� <see cref="T:System.Configuration.ConfigurationElement"/>.
        /// </returns>
        /// <param name="element">������ <see cref="T:System.Configuration.ConfigurationElement"/>, ��� �������� ������������ ����.</param>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((StateElement) element).Id;
        }
    }
}