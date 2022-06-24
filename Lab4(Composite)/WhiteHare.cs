using System;

namespace Composite
{
    /// <summary>
    /// Клас білого зайця
    /// </summary>
    class WhiteHare : Animal
    {
        /// <summary>
        /// Конструктор по замовчування
        /// </summary>
        public WhiteHare()
        {
            _species = "White hare";
        }

        public override string WaysOfEating()
        {
            return string.Format($"{_species} feeds on plants.");
        }

        public override string WaysOfLiving()
        {
            int time = DateTime.Now.Hour;
            if (time >= 6 && time <= 18)
            {
                return string.Format($"{_species} is jumping.");
            }
            else
            {
                return string.Format($"{_species} is sleeping.");
            }
        }
    }
}
