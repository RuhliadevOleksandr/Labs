namespace LabModels
{
    /// <summary>
    /// Клас іспит
    /// </summary>
    public class Exam
    {
        /// <summary>
        /// Зовнішній ключ(ключ студента)
        /// </summary>
        public uint StudentId { get; set; }

        /// <summary>
        /// Зовнішній ключ(ключ дисципліни)
        /// </summary>
        public uint DisciplineId { get; set; }

        /// <summary>
        /// Номер семестру
        /// </summary>
        public uint Semester { get; set; }

        /// <summary>
        /// Оцінка
        /// </summary>
        public decimal Mark { get; set; }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        public override string ToString()
        {
            return string.Format(
                                 $"(Ключ студента : {StudentId};" + 
                                 $" Ключ дисципліни : {DisciplineId};" + 
                                 $" Семестр: {Semester};" + 
                                 $" Оцінка: {Mark})"
                                );
        }
    }
}
