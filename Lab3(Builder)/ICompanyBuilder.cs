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
        void CreateName(string companyName);

        /// <summary>
        /// Додати директора компанії
        /// </summary>
        void AddDirector(Person director);

        /// <summary>
        /// Додати роботодавця компанії
        /// </summary>
        void AddEmployer(Person director);

        /// <summary>
        /// Додати команду розробників
        /// </summary>
        void AddDeveloperTeam(List<Developer> developers, Developer teamLead);
    }
}
