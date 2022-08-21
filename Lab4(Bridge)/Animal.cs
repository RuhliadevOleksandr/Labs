namespace Bridge
{
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
                                 $"\nСпосіб харчування: {_behavior.Eating};" +
                                 $"\nСпосіб проживання: {_behavior.Living}"
                                );
        }
    }
}
