namespace Bridge
{
    /// <summary>
    /// Назви груп тварин
    /// </summary>
    public enum AnimalGroups 
    { 
        /// <summary>
        /// Родина
        /// </summary>
        Family, 

        /// <summary>
        /// Група
        /// </summary>
        Group, 

        /// <summary>
        /// Колонія
        /// </summary>
        Colony, 

        /// <summary>
        /// Зграя
        /// </summary>
        Flock, 

        /// <summary>
        /// Стадо
        /// </summary>
        Herd
    };

    /// <summary>
    /// Груповий спосіб життя
    /// </summary>
    public class GroupLifestyle : IBehavior
    {

        /// <summary>
        /// Спосіб харчування тварини
        /// </summary>
        public WaysOfEating Eating { get; private set; }

        /// <summary>
        /// Спосіб проживання тварини
        /// </summary>
        public WaysOfLiving Living { get; private set; }

        /// <summary>
        /// Назва групи тварини
        /// </summary>
        public AnimalGroups AnimalGroup { get; private set; }

        /// <summary>
        /// Конструктор з параметрами
        /// </summary>
        /// <param name="animalGroup">Назва групи</param>
        /// <param name="eating">Спосіб харчування</param>
        public GroupLifestyle(WaysOfEating eating, WaysOfLiving living, AnimalGroups animalGroup)
        {
            Eating = eating;
            Living = living;
            AnimalGroup = animalGroup;
        } 
    }
}
