namespace Bridge
{
    /// <summary>
    /// Класи тварин
    /// </summary>
    public enum AnimalClasses { 
        /// <summary>
        /// Птахи
        /// </summary>
        Aves,
        /// <summary>
        /// Ссавці
        /// </summary>
        Mammalia
    }

    /// <summary>
    /// Ряди тварин
    /// </summary>
    public enum AnimalOrders {
        /// <summary>
        /// Совоподібні
        /// </summary>
        Strigiformes,
        /// <summary>
        /// Зайцеподібні
        /// </summary>
        Lagomorpha
    }

    /// <summary>
    /// Абстрактний клас тварина
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// Поведінка тварини
        /// </summary>
        protected IBehavior _behavior;

        /// <summary>
        /// Клас тварини
        /// </summary>
        protected AnimalClasses _class;

        /// <summary>
        /// Ряд тварини
        /// </summary>
        protected AnimalOrders _order;

        /// <summary>
        /// Отримати клас тварини
        /// </summary>
        public AnimalClasses Class 
        {
            get
            {
                return _class;
            }
        }

        /// <summary>
        /// Отримати ряд тварини
        /// </summary>
        public AnimalOrders Order 
        { 
            get 
            {
                return _order;
            }        
        }

        /// <summary>
        /// Конструктор з параметром
        /// </summary>
        /// <param name="behavior">Поведінка</param>
        public Animal(IBehavior behavior)
        {
            _behavior = behavior;
        }
    }
}
