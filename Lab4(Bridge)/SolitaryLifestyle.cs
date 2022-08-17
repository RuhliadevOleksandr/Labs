namespace Bridge
{
    /// <summary>
    /// Одиночний спосіб життя
    /// </summary>
    public class SolitaryLifestyle : IBehavior
    {
        /// <summary>
        /// Чи має тварина пару
        /// </summary>
        public bool HasCouple { get; private set; }

        /// <summary>
        /// Спосіб харчування тварини
        /// </summary>
        public WaysOfEating Eating { get; private set; }

        /// <summary>
        /// Спосіб проживання тварини
        /// </summary>
        public WaysOfLiving Living { get; private set; }

        /// <summary>
        /// Створити сім'ю
        /// </summary>
        public void CreateFamily() { HasCouple = true; }

        /// <summary>
        /// Покинути сім'ю
        /// </summary>
        public void LeaveFamily() { HasCouple = false; }

        /// <summary>
        /// Конструктор з параметрами
        /// </summary>
        /// <param name="eating">спосіб харчування</param>
        /// <param name="hasCouple">чи має пару</param>
        public SolitaryLifestyle(WaysOfEating eating, WaysOfLiving living, bool hasCouple = false)
        {
            HasCouple = hasCouple;
            Eating = eating;
            Living = living;
        }
    }
}
