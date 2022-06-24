using System;

namespace Composite
{
    /// <summary>
    /// Клас сірої сови
    /// </summary>
    public class TawnyOwl : Animal
    {
        /// <summary>
        /// Конструктор по замовчування
        /// </summary>
        public TawnyOwl()
        {
            _species = "Tawny owl";
        }

        public override string WaysOfEating()
        {
            return string.Format($"{_species} hunts for prey.");
        }

        public override string WaysOfLiving()
        {
            int time = DateTime.Now.Hour;
            if(time >= 6 && time <= 18)
            {
                return string.Format($"{_species} is sleeping.");
            }
            else
            {
                return string.Format($"{_species} is flying.");
            }
        }
    }
}
