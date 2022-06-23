namespace Builder
{
    public class Worker : Person, IEmployee
    {
        /// <summary>
        /// Посада
        /// </summary>
        public CompanyPosition Position { get; set; }

        public override string ToString()
        {
            return string.Format(
                                 $"\nПрізвище та ім'я: {LastName} {FirstName}" +
                                 $"\nПосада: {Position}"
                                );
        }
    }
}
