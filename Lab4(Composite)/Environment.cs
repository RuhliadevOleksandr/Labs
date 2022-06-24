using System.Text;
using System.Collections.Generic;

namespace Composite
{
    /// <summary>
    /// Клас середовище
    /// </summary>
    public class Environment : IBehavior
    {
        /// <summary>
        /// Назва середовища
        /// </summary>
        private string _name;

        /// <summary>
        /// Конструктор з параметром
        /// </summary>
        /// <param name="name">Назва середовища</param>
        public Environment(string name)
        {
            _name = name;
        }

        /// <summary>
        /// Група елементів
        /// </summary>
        private List<IBehavior> _elements = new List<IBehavior>();

        /// <summary>
        /// Додати новий елемент до групи
        /// </summary>
        /// <param name="element">Елемент, який необхідно додати</param>
        public void Add(IBehavior element)
        {
            _elements.Add(element);
        }

        /// <summary>
        /// Прибрати елемент групи
        /// </summary>
        /// <param name="element">Елемент, який необхідно прибрати</param>
        public void Remove(IBehavior element)
        {
            _elements.Remove(element);
        }

        /// <summary>
        /// Спосіб харчування
        /// </summary>
        /// <returns>Рядки з описами</returns>
        public string WaysOfEating() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{_name}:");
            foreach(IBehavior element in _elements)
            {
                sb.Append($"\n\t{element.WaysOfEating()}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Спосіб проживання
        /// </summary>
        /// <returns>Рядки з описами</returns>
        public string WaysOfLiving()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{_name}:");
            foreach (IBehavior element in _elements)
            {
                sb.Append($"\n\t{element.WaysOfLiving()}");
            }
            return sb.ToString();
        }
    }
}
