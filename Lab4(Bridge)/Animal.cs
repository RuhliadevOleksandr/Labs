namespace Bridge
{
    /// <summary>
    /// Класи тварин
    /// </summary>
    public enum AnimalClasses { 
        /// <summary>
        /// Птахи
        /// </summary>
        Aves,

        /// <summary>
        /// Ссавці
        /// </summary>
        Mammalia
    }

    /// <summary>
    /// Абстрактний клас тварина
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Поведінка тварини
        /// </summary>
        protected IBehavior _behavior;

        /// <summary>
        /// Клас тварини
        /// </summary>
        protected AnimalClasses _class;

        /// <summary>
        /// Отримання класу тварини
        /// </summary>
        public AnimalClasses Class 
        {
            get
            {
                return _class;
            }
        }

        /// <summary>
        /// Конструктор з параметром
        /// </summary>
        /// <param name="behavior">Поведінка тварини</param>
        public Animal(IBehavior behavior)
        {
            _behavior = behavior;
        }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        /// <returns>Рядок з описом тварини</returns>
        public override string ToString()
        {
            return string.Format(
                                 $"Клас тварини: {_class};" +
                                 $"\nСпосіб харчування: {_behavior.Eating};" +
                                 $"\nСпосіб проживання: {_behavior.Living}"
                                );
        }
    }
}
