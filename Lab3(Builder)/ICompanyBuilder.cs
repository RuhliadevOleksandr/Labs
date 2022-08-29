namespace Builder
{
    /// <summary>
    /// Інтерфейс будівельника компаній
    /// </summary>
    public interface ICompanyBuilder
    {
        /// <summary>
        /// Створення нової компанії
        /// </summary>
        void Reset();

        /// <summary>
        /// Сворити ім'я компанії
        /// </summary>
        void CreateName();

        /// <summary>
        /// Додати директора компанії
        /// </summary>
        void AddDirector();

        /// <summary>
        /// Додати роботодавця компанії
        /// </summary>
        void AddEmployer();

        /// <summary>
        /// Додати команду розробників
        /// </summary>
        void AddDeveloperTeam();
    }
}
