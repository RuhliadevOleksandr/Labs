namespace Bridge
{
    /// <summary>
    /// Способи харчування тварин
    /// </summary>
    public enum WaysOfEating 
    { 
        /// <summary>
        /// Рослиноїдний
        /// </summary>
        Herbivorous, 

        /// <summary>
        /// Хижак
        /// </summary>
        Carnivorous, 

        /// <summary>
        /// Всеїдний
        /// </summary>
        Omnivorous, 

        /// <summary>
        /// Падальник
        /// </summary>
        Detritivorous 
    };

    /// <summary>
    /// Способи проживання тварин
    /// </summary>
    public enum WaysOfLiving
    {
        /// <summary>
        /// Нічний спосіб проживання
        /// </summary>
        Nocturnal,

        /// <summary>
        /// Сутінковий спосіб проживання
        /// </summary>
        Crepuscular,

        /// <summary>
        /// Денний спосіб проживання
        /// </summary>
        Diurnal
    };

    /// <summary>
    /// Поведінка тварини
    /// </summary>
    public interface IBehavior
    {
        /// <summary>
        /// Спосіб харчування тварини
        /// </summary>
        WaysOfEating Eating { get; }

        /// <summary>
        /// Спосіб проживання тварини
        /// </summary>
        WaysOfLiving Living { get; }
    }
}
