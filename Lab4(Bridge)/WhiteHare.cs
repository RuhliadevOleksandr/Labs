namespace Bridge
{
    /// <summary>
    /// Клас білого зайця
    /// </summary>
    public class WhiteHare : Animal
    {
        /// <summary>
        /// Довжина вух(см) зайця
        /// </summary>
        public double EarsLength { get; set; }

        /// <summary>
        /// Конструктор з параметром
        /// </summary>
        /// <param name="behavior">Поведінка</param>
        /// <param name="earsLength">Довжина вух(см)</param>
        public WhiteHare(IBehavior behavior, double earsLength) : base(behavior)
        {
            EarsLength = earsLength;
        }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        /// <returns>Рядок з описом зайця</returns>
        public override string ToString()
        {
            return string.Format(
                                 "Білий заєць:" + 
                                 $"\nДовжина вух: {EarsLength}(см)" +
                                 $"{base.ToString()}"
                                );
        }
    }
}
