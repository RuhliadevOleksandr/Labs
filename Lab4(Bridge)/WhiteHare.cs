namespace Bridge
{
    /// <summary>
    /// Клас білого зайця
    /// </summary>
    public class WhiteHare : Animal
    {
        /// <summary>
        /// Конструктор з параметром
        /// </summary>
        /// <param name="behavior">Поведінка</param>
        public WhiteHare(IBehavior behavior) : base(behavior)
        {
            _class = AnimalClasses.Mammalia;
        }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        /// <returns>Рядок з описом зайця</returns>
        public override string ToString()
        {
            return string.Format("White hare:" + $"\n{base.ToString()}");
        }
    }
}
