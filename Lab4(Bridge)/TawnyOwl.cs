namespace Bridge
{
    /// <summary>
    /// Клас сірої сови
    /// </summary>
    public class TawnyOwl : Animal
    {
        /// <summary>
        /// Розмах крил(см) сови
        /// </summary>
        public double Wingspan { get; set; }

        /// <summary>
        /// Конструктор з параметром
        /// </summary>
        /// <param name="behavior">Поведінка</param>
        /// <param name="wingspan">Розмах крил(см)</param>
        public TawnyOwl(IBehavior behavior, double wingspan) : base(behavior)
        {
            Wingspan = wingspan;
        }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        /// <returns>Рядок з описом сови</returns>
        public override string ToString()
        {
            return string.Format(
                                 "Сіра сова:" +
                                 $"\nРозмах крил: {Wingspan}(см)" +
                                 $"{base.ToString()}"
                                );
        }
    }
}
