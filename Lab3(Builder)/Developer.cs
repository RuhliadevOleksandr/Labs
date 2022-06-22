namespace Builder
{
    /// <summary>
    /// Рівень розробника
    /// </summary>
    public enum DeveloperLevel { None, Junior, Middle, Senior };

    /// <summary>
    /// Клас розробник
    /// </summary>
    public class Developer : Person
    {
        /// <summary>
        /// Рівень розробника
        /// </summary>
        public DeveloperLevel Level { get; set; }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        public override string ToString()
        {
            if (Position == CompanyPosition.Director)
            {
                return string.Format($"\nПрізвище та ім'я: {LastName} {FirstName}");
            }
            else
            {

                return string.Format(
                                     $"\nПрізвище та ім'я: {LastName} {FirstName}; " +
                                     $"\nРівень: {Level}; " +
                                     $"\nПосада: {Position}"
                                    );
            }
        }
    }
}
