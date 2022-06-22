namespace LabModels
{
    /// <summary>
    /// Клас студент
    /// </summary>
    public class Student : Person
    {
        /// <summary>
        /// Номер курсу
        /// </summary>
        public uint Course { get; set; }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        public override string ToString()
        {
            return string.Format(
                                 $"(Первинний ключ: {Id};" +
                                 $" ПІБ: {LastName} {FirstName} {Patronymic};" + 
                                 $" Номер курсу: {Course})"
                                );
        }
    }
}
