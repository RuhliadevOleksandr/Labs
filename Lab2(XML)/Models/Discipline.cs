namespace LabModels
{
    public enum FormOfKnoledgeControl { Залік, Екзамен }

    /// <summary>
    /// Клас дисципліна
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Первинний ключ
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Назва
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Форма контролю знань
        /// </summary>
        public FormOfKnoledgeControl Form { get; set; }

        /// <summary>
        /// Ключ викладача(лектор)
        /// </summary>
        public uint LecturerId { get; set; }

        /// <summary>
        /// Ключ викладача(практик)
        /// </summary>
        public uint PractitionerId { get; set; }

        /// <summary>
        /// Приведення до рядкового типу
        /// </summary>
        public override string ToString()
        {
            return string.Format(
                                 $"(Первинний ключ: {Id};" + 
                                 $" Назва дисципліни: {Name};" + 
                                 $" Форма контролю знань: {Form};" + 
                                 $" Лектор: {LecturerId};" + 
                                 $" Практик: {PractitionerId})"
                                );
        }
    }
}
