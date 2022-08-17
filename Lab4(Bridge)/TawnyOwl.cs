namespace Bridge
{
    /// <summary>
    /// Клас сірої сови
    /// </summary>
    public class TawnyOwl : Animal
    {
        /// <summary>
        /// Конструктор з параметром
        /// </summary>
        /// <param name="behavior">поведінка</param>
        public TawnyOwl(IBehavior behavior) : base(behavior)
        {
            _class = AnimalClasses.Aves;
        }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        /// <returns>Рядок з описом сови</returns>
        public override string ToString()
        {
            return string.Format("Tawny owl:" + $"\n{base.ToString()}");
        }
    }
}
