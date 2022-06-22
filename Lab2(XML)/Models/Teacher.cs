namespace LabModels
{
    /// <summary>
    /// Клас викладач
    /// </summary>
    public class Teacher : Person
    {
        /// <summary>
        /// Стаж(кількість років викладання)
        /// </summary>
        public uint Experience { get; set; }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        public override string ToString()
        {
            return string.Format(
                                 $"(Первинний ключ: {Id};" +
                                 $" ПІБ: {LastName} {FirstName} {Patronymic};" +
                                 $" Стаж: {Experience})"
                                );
        }
    }
}
