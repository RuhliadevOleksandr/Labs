using System.Collections.Generic;

namespace Builder
{
    /// <summary>
    /// Інтерфейс будівельника компаній
    /// </summary>
    public interface ICompanyBuilder
    {
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
