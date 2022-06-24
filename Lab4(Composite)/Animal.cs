namespace Composite
{
    /// <summary>
    /// Абстрактний клас тварина
    /// </summary>
    public abstract class Animal : IBehavior
    {
        /// <summary>
        /// Вид тварини
        /// </summary>
        protected string _species;

        public abstract string WaysOfEating();

        public abstract string WaysOfLiving();
    }
}
