namespace Builder
{
    /// <summary>
    /// Клас особа
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Прізвище
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Ім'я
        /// </summary>
        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format($"\nПрізвище та ім'я: {LastName} {FirstName}");
        }
    }
}
