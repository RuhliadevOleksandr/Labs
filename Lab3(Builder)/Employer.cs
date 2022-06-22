namespace Builder
{
    /// <summary>
    /// Клас роботодавець
    /// </summary>
    public class Employer : Person
    {
        /// <summary>
        /// Кількість прийнятих робітників
        /// </summary>
        public int NumberOfEmployees { get; set; }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        public override string ToString()
        {
            return string.Format(
                                 $"\nПрізвище та ім'я: {LastName} {FirstName}; " +
                                 $"\nКількість прийнятих робітників: {NumberOfEmployees}"
                                );
        }
    }
}
