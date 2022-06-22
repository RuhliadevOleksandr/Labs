namespace LabModels
{
    /// <summary>
    /// Клас особа
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Первинний ключ
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Прізвище
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Ім'я
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// По батькові
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        public override string ToString()
        {
            return string.Format(
                                 $"(Первинний ключ: {Id};" + 
                                 $" ПІБ: {LastName} {FirstName} {Patronymic})"
                                );
        }
    }
}
