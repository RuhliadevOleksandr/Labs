namespace Builder
{
    /// <summary>
    /// Клас особа
    /// </summary>
    public class Person : IEmployee
    {
        /// <summary>
        /// Прізвище
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Ім'я
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Посада
        /// </summary>
        public CompanyPosition Position { get; set; }

        public override string ToString()
        {
            if(Position == CompanyPosition.None)
            {
                return string.Format($"\nПрізвище та ім'я: {LastName} {FirstName}");
            }
            else
            {

                return string.Format(
                                     $"\nПрізвище та ім'я: {LastName} {FirstName}" +
                                     $"\nПосада: {Position}"
                                    );
            }
        }
    }
}
