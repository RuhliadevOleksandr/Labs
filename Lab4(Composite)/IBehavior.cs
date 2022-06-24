namespace Composite
{
    /// <summary>
    /// Інтерфейс поведінки
    /// </summary>
    public interface IBehavior
    {
        /// <summary>
        /// Спосіб харчування
        /// </summary>
        /// <returns>Рядок з описом</returns>
        string WaysOfEating();

        /// <summary>
        /// Спосіб проживання
        /// </summary>
        /// <returns>Рядок з описом</returns>
        string WaysOfLiving();
    }
}
